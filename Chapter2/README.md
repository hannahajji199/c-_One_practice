## Topics
1. 3.1 Reading Input with TextBox Controls
2. 3.2 A First Look at Variables
3. 3.3 Numeric Data Type and Variables
4. 3.4 Performing Calculations
5. 3.5 Inputting and Outputting Numeric Values
6. 3.6 Formatting Numbers with the ToString Method
7. 3.7 Simple Exception Handling
8. 3.8 Using Named Constants
9. 3.9 Declaring Variables as Fields
10. 3.10 Using the Math Class
11. 3.11 More GUI Details
12. 3.12 Using the Debugger to Locate Logic Errors

##  Reading Input with TextBox Controls

🟠 A `TextBox` control is a rectangular area that can accept keyboard input from the user.

🟠 It is located in the Common Control group of the Toolbox.

🟠 Double-click it to add it to the form (default name is `textBoxn`, where `n` is 1, 2, 3, …).

# The Text Property

🟠 A `TextBox` control’s `Text` property stores the user inputs and accepts only `string` values.

🟢
**textBox1.Text = "Hello";**

🟠 To clear the content of a `TextBox` control, assign an empty string (`""`) or use the `Clear` method:

🟢
**textBox1.Text = string.Empty;
textBox1.Clear();
textBox1.Text = "";**

##A First Look at Variables

🟠 A variable is a storage location in memory, and a variable name represents that memory location.

🟠 In C#, you must declare a variable in a program before using it to store data.

🟢
**DataType VariableName;**

# Data Types

🟠 A variable must be declared with a proper data type, which specifies the type of data a variable can hold.

🟠 **Primitive Data Types** (basic/built-in types already defined by C#):
> **Integral Types:** `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`
> **Floating-Point Types:** `float`, `double`, `decimal`
> **Other Basic Types:** `char`, `bool`, `string`

🟠 **Non-Primitive Data Types:**
> **Collections:** `Array`, `List<T>`, `Dictionary<TKey, TValue>`
> **User-Defined Types:** `Class`, `Struct`, `Enum`, `Interface`
> **Special Types:** `object`, `dynamic`, `var`, `Delegate`

# Variable Names

🟠 Always choose a meaningful name for variables.

🟠 Basic naming conventions are:
> The first character must be a letter (upper or lowercase) or an underscore (`_`).
> The name cannot contain spaces.
> Do not use keywords or reserved words.

# String Variables & Concatenation

🟠 A `string` variable holds a combination of characters surrounded by double quotes (`""`).

🟠 **Concatenation** is the appending of one string to the end of another string using the `+` operator (can also combine a string with `int` or `double`).

🟢
**string productDescription = "Jamhuuriya University";
string message = "Jamhuuriya" + "University";
string value = 2025 + "Jamhuuriya Class";
MessageBox.Show(productDescription);**

# Scope, Lifetime, and Rules

🟠 **Local Variable:** Belongs to the method in which it was declared; only statements inside that method can access it.

🟠 **Scope:** Describes the part of a program in which a variable may be accessed.

🟠 **Lifetime:** The time period during which the variable exists in memory while the program is executing (destroyed when the method ends).

🟠 **Duplicate Variable Names:** You cannot declare two variables with the same name in the same scope, though you can in different methods.

🟠 **Assignment Compatibility:** You can assign a value to a variable only if the value is compatible with the variable’s data type.

🟠 **Initializing Variables:** In C#, a variable must be assigned a value before it can be used, otherwise the compiler throws an error (*Use of unassigned local variable*).

🟠 **Declaring Multiple Variables:** You can declare multiple variables of the same data type in one statement:

🟢
**string lastName = "Khalaf", firstName = "Mohamed", middleName = "Abdullahi";**

## 3.3 Numeric Data Types and Variables

🟠 If you need to store a number and use it in a mathematical operation, the variable must be of a numeric data type:
> `int`: Whole numbers (range: $-2,147,483,648$ to $2,147,483,647$).
> `double`: Real numbers including fractional parts.
> `decimal`: Real numbers stored with greater precision than doubles (typically used in financial applications).

# Numeric Literals & Compatibility

🟠 A numeric literal is a number written directly into code (cannot be surrounded by quotes).

🟠 Integer literals (`40`, `99`) are treated as `int`; literals with decimals (`87.6`, `3.14`) are treated as `double`; append `M` or `m` to create a `decimal` literal (`28.75m`).

🟠 **Assignment Compatibility:**
> `int` variables only accept `int` values.
> `double` variables accept `double` or `int` values (not `decimal`).
> `decimal` variables accept `decimal` or `int` values (not `double`).

# Explicit Conversion with Cast Operators

🟠 Type casting allows you to explicitly convert among types using the target type enclosed in parentheses `()`.

🟢
**int wholeNumber;
decimal moneyNumber = 4500m;
wholeNumber = (int)moneyNumber;**

# Declaring Local Variables with the `var` Keyword

🟠 `var` allows the compiler to automatically figure out the variable's data type from the assigned value (**type inference**).

🟠 You must provide an initialization value when using `var`, and it can only be used for local variables inside a method.

🟢
**var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;**

##  Performing Calculations

🟠 Arithmetic calculations are performed using math operators:
> `+` : Addition (adds two numbers)
> `-` : Subtraction (subtracts one number from another)
> `*` : Multiplication (multiplies one number by another)
> `/` : Division (divides one number by another and gives the quotient)
> `%` : Modulus (divides one number by another and gives the remainder)

# Rules for Performing Calculations

🟠 Follow the order of operations and group expressions with parentheses `()` when necessary.

🟠 **Mixed Data Types:**
> `int` and `double` $\rightarrow$ result is `double`.
> `int` and `decimal` $\rightarrow$ result is `decimal`.
> `double` and `decimal` $\rightarrow$ operation is **not allowed**.

🟠 **Integer Division:** Dividing an integer by an integer in C# always yields an integer (e.g., `7 / 3` equals `2`). To avoid this, cast one operand to `double`:

🟢
**int x = 7, y = 3;
MessageBox.Show(((double)x / y).ToString());**

##  Inputting and Outputting Numeric Values

🟠 Keyboard input from a `TextBox` is always treated as a `string`.

🟠 Use `Parse` methods to convert strings into numeric data types (casting does not work on strings):

🟢
**int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal pay = decimal.Parse(payTextBox.Text);**

🟠 You can also parse or format using specific regional settings via `CultureInfo` (e.g., `"en-US"`, `"de-DE"`, `"so-SO"`).

# Displaying Numeric Values

🟠 To display a number in a `Label` or `TextBox`, convert it back to a string using the `ToString()` method or implicit string conversion with `+`:

🟢
**decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
string output = "Your ID number is " + 1044;**

##  Formatting Numbers with the ToString Method

🟠 The `ToString()` method can accept a format string argument to format numbers in a specific way:
> `"N"` or `"n"` : Number format . 
> `"F"` or `"f"` : Fixed-point format .
> `"E"` or `"e"` : Exponential scientific format .
> `"C"` or `"c"` : Currency format .
> `"P"` or `"p"` : Percentage format .

## Simple Exception Handling

🟠 An **exception**
 is an unexpected runtime error (such as dividing by zero or invalid user input) that causes a program to abruptly halt if unhandled.

🟠 **Throwing** 
is when an error occurs/is raised; **Catching** is handling the error gracefully so the program doesn't crash.

🟠 Use a `try-catch` statement to handle exceptions, and access `ex.Message` to display the system's default error description:

🟢
**try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;
    mpgLabel.Text = mpg.ToString();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}**

##  Using Named Constants

🟠 A named constant represents a value that cannot be changed during the program's execution.

🟠 Declared using the `const` keyword (traditionally written in UPPERCASE letters):

🟢
**const double INTEREST_RATE = 0.129;**

## Declaring Variables as Fields

🟠 A **field**
 is a variable declared at the class level (inside the class, outside of any method).

🟠 A field's scope is the entire class, allowing multiple methods/event handlers to share and modify its data.

🟢
**public partial class Form1 : Form
{
    private string name = "Charles";
    
    private void showNameButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(name);
    }
}**

##  Using the Math Class

🟠 The .NET `Math` class provides built-in methods and constants for complex mathematical operations:
> `Math.Sqrt(x)` : Returns the square root of `x` (as a `double`).
> `Math.Pow(x, y)` : Returns `x` raised to the power of `y`.
> `Math.Max(x, y)` : Returns the greater of `x` and `y`.
> `Math.Min(x, y)` : Returns the lesser of `x` and `y`.
> `Math.Round(x)` : Rounds `x` to the nearest integer.
> `Math.PI` : Constant representing $\pi$ (circumference to diameter ratio).
> `Math.E` : Constant representing $e$ (natural logarithmic base).

##  More GUI Details

# Tab Order & Focus

🟠 **Focus** 
indicates which control currently receives keyboard input.

🟠 **Tab Order**
 is the sequence in which controls receive focus when the `Tab` key is pressed, controlled by the `TabIndex` property (starts at `0`; `Label` controls cannot receive focus).

🟠 You can set focus programmatically using the `Focus()` method:

🟢
**nameTextBox.Focus();**

# Keyboard Access Keys, Colors, and Backgrounds

🟠 **Access Key (Mnemonic):** 
Add an ampersand (`&`) before a letter in a button's `Text` property (e.g., `E&xit` allows `Alt + X` to trigger the button).

🟠 **Colors:** 
Use `BackColor` and `ForeColor` properties in the Properties window or via code (`Color.Black`, `Color.Yellow`).

🟠 **Form Background Images:**
 Set using `BackgroundImage` and adjusted with `BackgroundImageLayout` (`None`, `Tile`, `Center`, `Stretch`, `Zoom`).

# GroupBoxes vs. Panels

🟠 Both are containers that hold other controls, with key differences:
> A `GroupBox` displays a thin border and supports a title (`Text` property), whereas a `Panel` cannot display a title.
> A `Panel` allows customizing its border via the `BorderStyle` property, whereas a `GroupBox` does not.

##  Using the Debugger to Locate Logic Errors

🟠 A **logic error** 
is a mistake that does not stop the program from running, but causes it to produce incorrect results (e.g., wrong math formula).

🟠 **Breakpoints:** 
Lines selected in source code where execution pauses and enters **Break Mode**.

🟠 **Break Mode Inspection:**
 Hover over variables to view values, or open the **Locals** window (shows all current procedure variables) and **Watch** window (tracks specific variables).

🟠 **Single-Stepping:** 
Execute code one statement at a time using **Step Into** (`F11`), **Step Over**, or **Step Out** to pinpoint exact errors.