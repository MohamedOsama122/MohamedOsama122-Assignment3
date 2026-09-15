namespace CSharpBasicsAssignment;

public class Order
{
    // 10 Concrete Fields
    public int OrderId;
    public string CustomerName = string.Empty;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity = string.Empty;
    public char Priority;
    public long ItemCode;

    // Method : Calculate Total Price after discount
    public void CalculateTotal()
    {
        decimal discountAmount = UnitPrice * (decimal)(DiscountPercent / 100.0);
        TotalPrice = Quantity * (UnitPrice - discountAmount);
    }

    // Method : Print summary of the order
    public void PrintSummary()
    {
        Console.WriteLine($"[Order #{OrderId}] Customer: {CustomerName} | Total: ${TotalPrice:F2} | Paid: {IsPaid}");
    }
}