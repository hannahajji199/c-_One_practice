##  Topics
1. 5.1 The while Loop
2. 5.2 The ++ and -- Operators
3. 5.3 The for Loop
4. 5.4 The do-while Loop
5. 5.5 Using Files for Data Storage
6. 5.6 The OpenFileDialog and SaveFileDialog Controls
7. 5.7 Random Numbers
8. 5.8 The Load Event
##  The while Loop
🟠 A while loop causes a statement or set of statements to repeat as long as a Boolean expression is true.
🟠 The simple logic is: While a Boolean expression is true, perform a task.
🟠 A while loop has two main parts:
- A Boolean expression that is tested as true or false.
- A statement or set of statements that are repeated.

###  Structure of a while Loop

🟠 The first line is called the while clause.

🟠 Statements inside curly braces `{ }` are called the body of the loop.

🟠 When a while loop executes, the Boolean expression is tested first.

🟠 If the condition is true, the statements inside the loop execute.

🟠 Each time the loop executes, it is called an iteration.

🟠 A counter variable is a variable used to track how many times a loop runs.

**Syntax:**
while (BooleanExpression)
{
    statements;
}
###  The while Loop is a Pretest Loop

🟠 A while loop is a pretest loop because it tests its condition before performing an iteration.

🟠 If the condition is true, the loop executes.

🟠 If the condition is false at the beginning, the loop will not execute.

**Example:**
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}


🟢 This loop executes 5 times because count starts at 0 and increases by 1 until it reaches 5.

## Infinite Loops

🟠 An infinite loop is a loop that repeats continuously until the program is interrupted.

🟠 It happens when the loop condition never becomes false.

🟠 A common reason is forgetting to update the counter variable.

**Example:**


int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
}


🔴 The count variable never increases, so the condition remains true.



##  The ++ and -- Operators

🟠 To increment a variable means to increase its value.

🟠 To decrement a variable means to decrease its value.

🟠 C# provides two operators:
- `++` Increment operator.
- `--` Decrement operator.

###  Increment Operator (++)

🟠 The increment operator increases a variable's value by 1.

**Examples:**
count++;

count += 1;

count = count + 1;


###  Decrement Operator (--)

🟠 The decrement operator decreases a variable's value by 1.

**Examples:**
count--;

count -= 1;

count = count - 1;

### 🔍 Postfix Mode versus Prefix Mode

🟠 Postfix mode means placing the operator after its operand.

🟠 Prefix mode means placing the operator before its operand.

🟠 Postfix uses the old value first, then changes the value.

🟠 Prefix changes the value first, then uses the new value.

**Postfix Example:**


int x = 5;
int result = x++;

🟢 Result = 5, then x becomes 6.

**Prefix Example:**


int x = 5;
int result = ++x;


🟢 x becomes 6 first, then result = 6.
##   The for Loop

🟠 A for loop is specially designed for situations requiring a counter variable to control the number of iterations.

🟠 A for loop contains three main actions:

1. Initialization: Defines the initial value of the counter.
2. Test: A Boolean expression that determines whether the loop continues.
3. Update: Increases or decreases the counter variable.

##  General Syntax 


for (InitializationExpression; TestExpression; UpdateExpression)
{
    statements;
}


🟠 The for loop is a pretest loop because it tests the condition before executing the loop body.

### 🟢 Example of a for Loop


for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}


🟠 Initialization: `int count = 0`

🟠 Test: `count < 5`

🟠 Update: `count++`

🟠 The loop executes 5 times. 

## Other Forms of Update Expression 

🟠 A counter does not always have to increase by 1.

🟠 You can increase it by 10 or decrease it to count backward.

**Increment by 10:**


for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}


**Counting Backward:**

```csharp
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}


##   The do-while Loop

🟠 A do-while loop is a posttest loop.

🟠 It performs an iteration before testing its Boolean expression.

🟠 The statements inside the loop execute at least once, even if the condition is false.

##  General Syntax 

do
{
    statements;
}
while (BooleanExpression);


## 🟢 Example
int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);

🟠 The message box appears once because the do-while loop executes before checking the condition.

## Difference Between while and do-while

| Feature | while Loop | do-while Loop | . 
| Type | Pretest | Posttest | .
| Condition | Tested first | Tested after execution | . 
| Minimum execution | Zero times | One time | .
| Syntax | while | do-while | .
##   Using Files for Data Storage
🟠 When a program needs to save data for later use, it writes the data into a file.

## Three Steps of File Processing
1. Open the file: Creates a connection between the file and the program.
2. Process the file: Reads or writes data.
3. Close the file: Disconnects the file from the program.
### types of Files 

🟠 Text File: Contains data encoded as text using a scheme such as Unicode.

🟠 Binary File: Contains data that has not been converted into text.

🟠 Binary file contents cannot normally be viewed using a text editor.

🟠 This chapter focuses on text files.

###   File Objects

🟠 A file object is an object associated with a specific file.

🟠 It provides a way for a program to work with that file.

🟠 .NET provides two important classes:

- `StreamWriter`: Used for writing data to a text file.
- `StreamReader`: Used for reading data from a text file.

##  Writing Data to a File

🟠 First, create a StreamWriter object.

🟠 Use a File method to open the file.

🟠 Use `Write()` or `WriteLine()` to write data.

🟠 Close the connection when finished.

**Common File Methods:**

- `File.CreateText()`
- `File.AppendText()`

### 🟢 WriteLine Method

🟠 The WriteLine method writes data to a file and then adds a newline character.

**Example:**


StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();


##  Write() versus WriteLine()

🟠 `Write()`: Writes data without adding a newline character.

🟠 `WriteLine()`: Writes data and adds a newline character.

##  CreateText versus AppendText

🟠 `File.CreateText()` creates a new text file.

🟠 If the file already exists, its previous contents are erased.

🟠 `File.AppendText()` adds new data to an existing file without erasing its previous contents.


**CreateText Example:**


StreamWriter outputFile;

outputFile = File.CreateText("Names.txt");

outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");

outputFile.Close();


**AppendText Example:**
StreamWriter outputFile;

outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Alex");

outputFile.Close();
###  Specifying the Location of an Output File

🟠 You can specify a file path along with the filename.

🟠 The `@` character can be used before a string to represent a file path without escaping backslashes.

**Example:**
StreamWriter outputFile = 
File.AppendText(@"C:\Data\Names.txt");

###  Reading Data from a File

🟠 First, create a StreamReader object.

🟠 Use `File.OpenText()` to open the file.

🟠 Use reading methods to get data from the file.

🟠 Close the connection when finished.

**Common Reading Methods:**

- `ReadLine()`: Reads one line and returns it as a string.
- `Read()`: Reads the next character or set of characters.
- `ReadToEnd()`: Reads the remaining contents of a stream.
- `File.ReadAllText()`: Reads all text from a file.

**Example:**
StreamReader inputFile;

inputFile = File.OpenText("students.txt");

inputFile.Close();


##  Reading a File with a Loop 

🟠 StreamReader provides a Boolean property called `EndOfStream`.

🟠 It indicates whether the end of the file has been reached.

🟠 A loop can be used to read data until the end of the file.

**Example 1:** 
while (inputFile.EndOfStream == false)
{
    // Read file data
}


**Example 2:**


while (!inputFile.EndOfStream)
{
    // Read file data
}
##   The OpenFileDialog and SaveFileDialog Controls

🟠 OpenFileDialog and SaveFileDialog controls allow applications to display standard Windows dialog boxes.

🟠 They help users select files to open or save.

🟠 Unlike Label, Button, and TextBox, they are invisible controls.

##  OpenFileDialog

🟠 Displays a standard Windows Open dialog box.

🟠 Allows users to select an existing file.

##  SaveFileDialog

🟠 Displays a standard Windows Save As dialog box.

🟠 Allows users to choose where to save a file.

## Displaying an Open Dialog Box

🟠 When you add an OpenFileDialog control, it appears in the component tray at the bottom of the Designer.

🟠 You can display the Open dialog box by calling the `ShowDialog()` method.

**Example:**

private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}

##  Detecting the User's Selection

🟠 The ShowDialog method returns a DialogResult value.

🟠 `DialogResult.OK`: The user clicked the Open button.

🟠 `DialogResult.Cancel`: The user clicked the Cancel button.

**Example:**


DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
    // User clicked Open
}
else if (result == DialogResult.Cancel)
{
    // User clicked Cancel
}

###  Filename and InitialDirectory Properties

🟠 `Filename`: Stores the selected file's path and filename.

🟠 `InitialDirectory`: Specifies the directory that appears first when the dialog box opens.

**Example:**
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);
}


**InitialDirectory Example:**
openFileDialog.InitialDirectory = @"C:\Data";


###  Displaying a Save As Dialog Box

🟠 Use the SaveFileDialog control's `ShowDialog()` method .

🟠 Check whether the user clicked OK.

🟠 If the result is OK, open or create the selected file.

**Example:**


if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog.FileName);
}

##   Random Numbers

🟠 .NET provides the Random class to generate random numbers.

🟠 First, create a Random object.

## Creating a Random Object
Random rand = new Random();

###  Common Random Methods

🟠 `Next()`: Generates a random integer.

🟠 `NextDouble()`: Generates a random floating-point number from 0.0 to less than 1.0.

**Example:**
Random rand = new Random();

int number1 = rand.Next();

double number2 = rand.NextDouble();
###  Random.Next Method

🟠 Random.Next() generates a random integer from 0 to 2,147,483,647.

🟠 You can also specify a maximum value.

🟠 `Next(max)` generates a number from 0 up to, but not including, max.

**Syntax:**
RandomObject.Next(max);
**Example:**
int number = rand.Next(100);

🟢 This generates a random integer from 0 to 99.
##  The Load Event
🟠 When an application starts, its form is loaded into memory.

🟠 An event called Load takes place when the form is loaded.

🟠 The Load event allows you to execute code when the form starts.

##  Creating a Load Event Handler

🟠 To create a Load event handler, double-click the form in the Designer.

🟠 Visual Studio creates an empty Load event handler.

**Example:**
### 🟢 Writing Code Inside the Load Event

🟠 Any code written inside the Load event executes when the form is launched.

**Example:**
🟢 When the application starts and the form loads, the message box appears.
