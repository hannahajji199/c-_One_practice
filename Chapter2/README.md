## objects 
# topics 
1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants 
3.9 Declaring Variables as Fields
3.10 Using the Math Class
3.11 More G U I Details
3.12 Using the Debugger to Locate Logic Errors 

## Reading Input with TextBox Controls

🟠 A TextBox control is a rectangular area that can accept keyboard input from the user.

🟠 It is located in the Common Controls group of the Toolbox; double-click it to add it to the form.

🟠 The default name given to a TextBox is textBoxn, where n is 1, 2, 3, …

## The Text Property

🟠 A TextBox control's Text property stores what the user typed.

🟠 The Text property only accepts string values, e.g. textBox1.Text = "Hello";

🟠 To clear a TextBox's content, assign it an empty string:

🟠 textBox1.Text = "";

🟠 textBox1.Text = string.Empty;

🟠 textBox1.Clear();

##  A First Look at Variables

🟠 A variable is a storage location in memory.

🟠 A variable name represents that memory location.

🟠 A variable must be declared before it is used to store data.

🟠 Syntax: DataType VariableName;

- Data Types

🟠 A variable must be declared with a proper data type.

🟠 The data type specifies the kind of data a variable can hold.

🟠 Many data types are known as primitive data types they store fundamental (basic/simple/built-in) types of data, such as strings and integers.

🟠 In C#, primitive data types are already defined by the language, not created by you.

- Variable Names

🟠 A variable name identifies a variable  try always choose a meaningful name.

🟠 Basic naming rules:

🟠 The first character must be a letter (upper or lowercase) or an underscore (_).

🟠 The name cannot contain spaces.

🟠 Do not use keywords or reserved words.

- String Variables

🟠 A string is a combination of characters.

🟠 A string variable can hold any combination of characters, such as names, phone numbers, and social security numbers.

🟠 A string value is assigned on the right of =, surrounded by double quotes: productDescription = "Jamhuuriya University";

🟠 A string variable can be assigned to a Label: productLabel = productDescription;

🟠 A string variable can also be shown in a message box: MessageBox.Show(productDescription);

- String Concatenation

🟠 Concatenation is appending one string to the end of another string, using the + operator.

🟠 Concatenation can also happen between a string and another data type (int and string, double and string).

🟠 Example: 12 + " apples"; and "Total is " + 25.75;

- Declaring Variables Before Using Them

🟠 You can declare a variable first and use it later in the code.

- Local Variables and Scope

🟠 A local variable belongs to the method in which it was declared — only statements inside that method can access it.

🟠 Scope describes the part of a program in which a variable may be accessed.

🟠 Lifetime is the time period during which the variable exists in memory while the program runs.

🟠 A local variable is created when its method starts executing, and destroyed when the method ends.

-  Duplicate Variable Names

🟠 You cannot declare two variables with the same name in the same scope.

🟠 You can, however, have variables with the same name declared in different methods.

🟠 Assignment Compatibility: a value can only be assigned to a variable if it is compatible with that variable's data type (e.g., only strings are compatible with the string data type).

## Initializing Variables

🟠 In C#, a variable must be assigned a value before it can be used.

🟠 Trying to use an unassigned variable causes a compiler error such as "Use of unassigned local variable".

🟠 The C# compiler will not compile code that tries to use an unassigned variable.

## Declaring Multiple Variables with One Statement

🟠 You can declare multiple variables of the same data type in one statement: string lastName, firstName, middleName;

🟠 A long declaration can also be spread across multiple lines, e.g.:

- Example 
  string lastName = "Khalaf",
         firstName = "Mohamed",
         middleName = "Abdullahi";

##  Numeric Data Types and Variables

🟠 If a number will be used in a mathematical operation, the variable must be of a numeric data type.

🟠 Commonly used numeric data types:

🟠 int: a whole number (up to 2,147,483,647).

🟠 double: real numbers, including numbers with fractional parts.

🟠 decimal: real numbers stored with greater precision than double , typically used in financial applications.

## Numeric Literals

🟠 A numeric literal is a number written directly into a program's code, e.g. int hoursWorked = 40; or double temperature = 87.6;

🟠 A literal value is never surrounded by quotes.

🟠 Whole numbers (like 40, 99) are treated as int; numbers with a decimal point (like 87.6, 3.14) are treated as double.

🟠 To create a decimal literal, append M or m: decimal payRate = 28.75m;

## Assignment Compatibility for int Variables

🟠 You can assign int values to int variables, but not double or decimal values.

🟠 int hoursWorked = 40; :  works

🟠 int unitsSold = 650m; :  ERROR

🟠 int score = −25.5; :  ERROR

## Assignment Compatibility for double Variables

🟠 You can assign double or int values to a double variable, but not decimal values.

🟠 double distance = 28.75; : works

🟠 double speed = 75; :  works

🟠 double sales = 6500.0m; : ERROR

## Assignment Compatibility for decimal Variables

🟠 You can assign decimal or int values to a decimal variable, but not double values.

🟠 decimal balance = 9280.73m; : works

🟠 decimal price = 50; : works

🟠 decimal sales = 6500.0; : ERROR

- Explicit Conversion with Cast Operators

🟠 Type casting lets you explicitly convert among types using the cast operator — the type name in parentheses.

🟠 Example: wholeNumber = (int)moneyNumber; and realNumber = (double)moneyNumber;

+  Declaring Local Variables with the var Keyword

* var is a keyword used instead of writing the full type of a variable.

* The compiler figures out the type automatically from the assigned value this is called type inference.

* You must provide an initialization value when declaring a variable with var.

* var can only be used to declare local variables (inside a method). 

## Performing Calculations

🟠 Arithmetic calculations are performed using math operators:

Operator	Name	Description
+	Addition	Adds two numbers
−	Subtraction	Subtracts one number from another
*	Multiplication	Multiplies one number by another
/	Division	Divides one number by another and gives the quotient
%	Modulus	Divides one number by another and gives the remainder
## Rules for Performing Calculations

- A math expression performs a calculation and gives a value.

- Follow the order of operations, and use parentheses to group when necessary: result = (a + b) / 4;

- In a calculation of mixed data types:

- int + double → the int is treated as double, result is double.

- int + decimal → the int is treated as decimal, result is decimal.

- double + decimal → not allowed.

## Integer Division

🟠 Dividing an integer by an integer always gives an integer result (e.g., 7 / 3 = 2) this is integer division.

🟠 To avoid it, cast one operand to double: ((double)x / y), or declare the variables as double from the start.

##  Inputting and Outputting Numeric Values

🟠 Keyboard input is always treated as a combination of characters (a string), even if it looks like a number.

🟠 A TextBox reads input like 25.65 as a string, not a number.

🟠 To use a numeric value from a TextBox, convert its Text property using a Parse method || a cast operator cannot convert a string to a number || 

- int.Parse

- double.Parse

- decimal.Parse

- Example: int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

## Displaying Numeric Values

🟠 A control's Text property only accepts string literals.

🟠 To display a number in a TextBox or Label, convert it to a string with the ToString method: variableName.ToString()

🟠 Example: grossPayLabel.Text = grossPay.ToString();

🟠 Another option is implicit string conversion with the + operator: string output = "Your ID number is " + idNumber;