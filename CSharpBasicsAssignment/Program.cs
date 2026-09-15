

// =========================================================================
// PART A: Top-Level Statements (Execution Entry Point)
// =========================================================================

Console.WriteLine("=== PART A: Project & Structure ===");
Console.WriteLine("Project setup initialized successfully!\n");

RunTypesDemo();
RunValueVsReferenceDemo();

ScopeDemo scopeDemo = new ScopeDemo();
scopeDemo.RunScopeDemo();

RunLeetCodeSingleNumber();

// =========================================================================
// PART B: Methods & Demos
// =========================================================================

static void RunTypesDemo()
{
    Console.WriteLine("=== PART B: Variables, Types & Casting ===");

    int age = 19;
    long population = 1000000L;
    double height = 177.5;
    decimal price = 150.50m;
    bool isStudent = true;
    char grade = 'A';
    string name = "Mohamed";
    var country = "Egypt";

    Console.WriteLine($"age: {age} (Type: {age.GetType()})");
    Console.WriteLine($"population: {population} (Type: {population.GetType()})");
    Console.WriteLine($"height: {height} (Type: {height.GetType()})");
    Console.WriteLine($"price: {price} (Type: {price.GetType()})");
    Console.WriteLine($"isStudent: {isStudent} (Type: {isStudent.GetType()})");
    Console.WriteLine($"grade: {grade} (Type: {grade.GetType()})");
    Console.WriteLine($"name: {name} (Type: {name.GetType()})");
    Console.WriteLine($"country (inferred): {country} (Type: {country.GetType()})\n");

    int smallNum = 25;
    long bigNum = smallNum;
    char myChar = 'A';
    int charAscii = myChar;

    Console.WriteLine($"Implicit int to long: {bigNum}");
    Console.WriteLine($"Implicit char ('A') to int: {charAscii}");

    double doubleVal = 10.7;
    int castResult = (int)doubleVal;
    int convertResult = Convert.ToInt32(doubleVal);

    Console.WriteLine($"Explicit (int) cast: {castResult}");
    Console.WriteLine($"Convert.ToInt32: {convertResult}");

    int intDiv = 5 / 2;
    double doubleDiv = 5.0 / 2;

    Console.WriteLine($"5 / 2 (int division): {intDiv}");
    Console.WriteLine($"5.0 / 2 (double division): {doubleDiv}");

    int numToBox = 42;
    object boxedObj = numToBox;
    int unboxedNum = (int)boxedObj;

    Console.WriteLine($"Boxed value: {boxedObj}");
    Console.WriteLine($"Unboxed value: {unboxedNum}");

    string validStr = "42";
    int parsedNum = int.Parse(validStr);
    Console.WriteLine($"int.Parse result: {parsedNum}");

    string invalidStr = "abc";
    bool parseSuccess = int.TryParse(invalidStr, out int parseResult);
    Console.WriteLine($"int.TryParse succeeded: {parseSuccess}");

    if (!parseSuccess)
    {
        Console.WriteLine("Safely handled invalid input without crashing the app!");
    }

    float floatVal = 10.5f;
    decimal explicitDecimal = (decimal)floatVal;
    Console.WriteLine($"Float to explicit decimal: {explicitDecimal}\n");
}

static void RunValueVsReferenceDemo()
{
    Console.WriteLine("=== PART C: Value vs Reference Types ===");

    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;
    p2.X = 99;

    Console.WriteLine($"p1.X: {p1.X}, p2.X: {p2.X}");

    Order o1 = new Order
    {
        OrderId = 101,
        CustomerName = "Mohamed",
        Quantity = 2,
        UnitPrice = 100m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 10,
        ShippingCity = "Cairo",
        Priority = 'H',
        ItemCode = 1001L
    };

    o1.CalculateTotal();
    Order o2 = o1;
    o2.IsPaid = true;

    Console.WriteLine($"o1.IsPaid: {o1.IsPaid}, o2.IsPaid: {o2.IsPaid}");

    object boxedOrder = o1;
    Order o3 = (Order)boxedOrder;

    Console.WriteLine($"Are o1 and o3 the same instance? {object.ReferenceEquals(o1, o3)}");
    o2.PrintSummary();
    Console.WriteLine();
}

static int FindSingleNumber(int[] nums)
{
    int single = 0;
    foreach (int num in nums)
    {
        single ^= num;
    }
    return single;
}

static void RunLeetCodeSingleNumber()
{
    Console.WriteLine("=== PART F: LeetCode Single Number ===");

    int[] nums1 = { 4, 1, 2, 1, 2 };
    int[] nums2 = { 2, 2, 1 };

    Console.WriteLine($"Input [4, 1, 2, 1, 2] -> Single Number: {FindSingleNumber(nums1)}");
    Console.WriteLine($"Input [2, 2, 1] -> Single Number: {FindSingleNumber(nums2)}");
    Console.WriteLine();
}

// =========================================================================
// Structs & Classes
// =========================================================================

struct Point
{
    public int X;
    public int Y;
}

class ScopeDemo
{
    private int _fieldScopeVal = 100;

    public void ShowField()
    {
        Console.WriteLine($"Private field from first method: {_fieldScopeVal}");
    }

    public void ChangeField()
    {
        _fieldScopeVal = 200;
        Console.WriteLine($"Private field from second method: {_fieldScopeVal}");
    }

    public void RunScopeDemo()
    {
        Console.WriteLine("=== PART D: Scope & Operators ===");

        ShowField();
        ChangeField();

        int methodVar = 50;
        Console.WriteLine($"Method variable: {methodVar}");

        for (int i = 0; i < 1; i++)
        {
            int loopVar = 999;
            Console.WriteLine($"Inside loop block: {loopVar}");
        }

        int total = 100;
        total += 10;
        Console.WriteLine($"After += 10: {total}");
        total -= 5;
        Console.WriteLine($"After -= 5: {total}");
        total *= 2;
        Console.WriteLine($"After *= 2: {total}");
        total /= 4;
        Console.WriteLine($"After /= 4: {total}");
        total %= 3;
        Console.WriteLine($"After %= 3: {total}");

        int a = 12;
        int b = 10;
        Console.WriteLine($"a & b (Bitwise AND): {a & b}");
        Console.WriteLine($"a | b (Bitwise OR): {a | b}");
        Console.WriteLine($"a ^ b (Bitwise XOR): {a ^ b}");

        bool first = true;
        bool second = false;
        Console.WriteLine($"Logical AND (&&): {first && second}");
        Console.WriteLine($"Logical OR (||): {first || second}");
        Console.WriteLine();
    }
}