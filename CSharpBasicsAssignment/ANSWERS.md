# Answers

## Part A

### .csproj

The `.csproj` file contains the project settings and configuration.

The required properties are:

- OutputType: Exe
- TargetFramework: net10.0
- ImplicitUsings: enable
- Nullable: enable

### #region

`#region` and `#endregion` are used to organize code into collapsible sections in the IDE. They do not change how the program runs.

### XML Documentation vs Normal Comments

`//` is used for normal comments that explain the code.

`///` is used for XML documentation comments. They can describe classes, methods, parameters, and return values and can be used by IDEs and documentation tools.

### Global Variables

C# does not have true global variables.

The closest equivalent is a static field that belongs to a class.