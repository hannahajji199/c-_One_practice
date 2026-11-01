# Chapter 3: Making Decisions (C#)
Code and screenshots from the Chapter 3 slides, explained in easy English.

Note: put this file in the same folder as the `screenshots/` folder, so the images show.

## Contents
- Slide 7: if-else
- Slide 8: Test Score Average form
- Slide 9: try / catch and average
- Slide 10: Payroll with Overtime form
- Slide 11: Loan Qualify form
- Slide 12: Nested if
- Slide 13: if-else-if
- Slide 15: Truth tables
- Slide 16: Range Checker form
- Slide 18: bool flag
- Slide 19: Comparing strings
- Slide 28: ListBox Text and Count
- Slide 32: ListBox RemoveAt



## if-else Statement (Slide 7)
if-else runs one block if the condition is true, and another block if it is false.

### Flowchart
🟠Slide 7 flowchar img_flowchart.

What it does:
- Checks the condition: temp > 40
- True: display "hot"
- False: display "cold"

### Code
🟠Slide 7 code img_b_code_if_else.


double Temp = 90;
if (Temp > 40)
{
    MessageBox.Show("hot");
}
else
{
    MessageBox.Show("hot");   // see note below
}


What it does:
- `double Temp = 90;` creates a variable with the value 90
- `if (Temp > 40)` checks if Temp is bigger than 40
- 90 is bigger than 40, so the first block runs
- `else` runs only when the condition is false

Note: the slide shows "hot" in both blocks. The `else` block should show "cold".


## Test Score Average Form (Slide 8)
🟠Slide 8 form img_form_test_score_average.

What it does:
- Shows the form (user interface) of the program
- 3 TextBoxes: the user types three test scores (80, 90, 75)
- Label: shows the Average (81.7)
- Buttons: Calculate Average, Clear, Exit


## try / catch and Average (Slide 9)
🟠Slide 9 code img_try_catch_average


try
{
   const double HIGH_SCORE = 95.0;
   double test1, test2, test3, average;

   test1 = double.Parse(test1TextBox.Text);
   test2 = double.Parse(test2TextBox.Text);
   test3 = double.Parse(test3TextBox.Text);

   average = (test1 + test2 + test3) / 3.0;

   averageLabel.Text = average.ToString("n1");

   if (average > HIGH_SCORE)
   {
       MessageBox.Show("Congratulations! Great job!");
   }
}
catch (Exception ex)
{
   MessageBox.Show(ex.Message);
}


What it does:
- This is the code of the Calculate Average button
- `try`: the program tries to run this code
- `catch`: runs if there is an error
- `const`: a value that cannot change
- `double.Parse()`: changes text to a number
- Average: (80 + 90 + 75) / 3 = 81.67
- `ToString("n1")`: shows the number with 1 decimal (81.7)
- If the average is bigger than 95, show a message
- If the user types letters, the error message is shown

Note: the slide comment says "2 decimal places", but `"n1"` gives 1 decimal. For 2 decimals use `"n2"`.
## Payroll with Overtime Form (Slide 10)
🟠Slide 10 form img_form_payroll_overtime.

What it does:
- Shows the form and the name of each control
- Names help you write code easily

Control   and how to Name it 

Hours worked (TextBox) = `hoursWorkedTextBox` .
 Hourly pay rate (TextBox) = `hourlyPayRateTextBox` .
 Gross pay (Label)= `grossPayLabel` |
 Calculate Gross Pay (Button) = `calculateButton` .
 Clear (Button) = `clearButton` .
 Exit (Button) = `exitButton` .



## Loan Qualify Form (Slide 11)
🟠Slide 11 form img_form_loan_qualify.

What it does:
- A form to check if a person can get a loan
- The user types the Annual Salary and the Years at current job
- Button Check Qualification shows the result in Loan Decision
- The code for this form is in Slide 12



## Nested Decision Structure (Slide 12)
Nested means one if inside another if.

### Flowchart
🟠Slide 12 flowchart img_flowchart_nested_if.

What it does:
- Step 1: is salary >= 40000? If false: "Minimum salary requirement not met."
- Step 2: if true, is yearsOnJob >= 2?
- If false: "Minimum years at current job not met."
- If true: "You qualify for the loan."

### Code
🟠Slide 12 code img_b_code_nested_if.


double salary = 400;
double yearsOnJob = 2;

if (salary >= 40000)
{
    if (yearsOnJob >= 2)
    {
        decisionLabel.Text = "You qualify for the load";
    }
    else
    {
        decisionLabel.Text = "Minimum years at current job not met.";
    }
}
else
{
    decisionLabel.Text = "Minimum salary requirement not met.";
}


What it does:
- The outer `if` checks the salary
- The inner `if` checks the years on the job
- salary = 400 is less than 40000, so the `else` runs
- Result: "Minimum salary requirement not met."
- To qualify, both conditions must be true

Note: the slide has a typo: "load" should be "loan".



## if-else-if Statement (Slide 13)
Use if-else-if to test many conditions. The first true condition runs, and the rest are skipped.

🟠Slide 13 code img_if_else_if.png


int score = int.Parse(testScoreTextBox.Text);
string grade = "A";
if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else if (score >= 70)
{
    grade = "C";
}
else if (score >= 60)
{
    grade = "D";
}
else
{
    grade = "F";
}


What it does:
- Reads the score from the TextBox
- Gives a grade from A to F
- Example: score = 85 gives grade "B"
- Score below 60 gives grade "F"
- `int.Parse` gives an error if the text is not a number


## Logical Operators: Truth Tables (Slide 15)

### AND (&&)
🟠AND truth table img_a_truth_table_and

- Result is true only if both sides are true

 Expression and   Value 

 `true && false` = false. 
 `false && true` = false .
 `false && false` = false.
 `true && true` = true .

### OR (||)
🟠 OR truth table img__b_truth_table_or.

- Result is true if one side or both sides are true

 Expression and Value 

 `true | false` =true .
 `false | true` = true .
 `false | false` = false .
 `true | true` = true .

### NOT (!)
🟠NOT truth table img_c_truth_table_not.

- Changes true to false, and false to true

 Expression and Value 

 `! true` = false .
 `! false` = true.


## Range Checker Form (Slide 16)
🟠Slide 16 form img_form_range_checker.

What it does:
- The user types an integer
- The program checks if it is from 1 to 10
- The answer shows in Range Decision
- This is a practice lab. Use `&&`, for example: `if (number >= 1 && number <= 10)`





## bool Variable and Flag (Slide 18)
A flag is a bool variable that tells if a condition exists. It is true or false.

🟠Slide 18 code img_code_bool_flag.


double points;
bool isGrandMaster;

points = double.Parse(txtPoints.Text);

if (points > 5000)
{
    isGrandMaster = true;
}
else
{
    isGrandMaster = false;
}

lblResult.Text = isGrandMaster.ToString();


What it does:
- Reads the points from the TextBox
- More than 5000 points: flag is true
- Otherwise: flag is false
- `ToString()` changes the bool to text
- The result shows in `lblResult`



## Comparing Strings (Slide 19)
🟠Slide 19 code img_code_compareto.


if (Name1.CompareTo(Name2)==0)
{

}


What it does:
- `CompareTo()` compares two strings
- It returns 0 if they are equal
- If equal, the code inside `{ }` runs
- Another way: `String.Compare(name1, name2) == 0`



## ListBox: Text and Count (Slide 28)

### Text
Text: gets the selected item as text.

Slide 28 code 1 img_a_code_listbox_text.

csharp
string selectedtext = listBox1.Text;
MessageBox.Show("your selected " + " " + selectedtext);


What it does:
- Gets the selected item from the ListBox
- Saves it in `selectedtext`
- Shows it in a message box
- If nothing is selected, Text is empty ("")

### Items.Count
Items.Count: gets the number of items in the ListBox.

🟠Slide 28 code 2 img_b_code_listbox_count.

csharp
int count_listbox;
count_listbox = listBox1.Items.Count;
MessageBox.Show("Total items is :" + " " + count_listbox);


What it does:
- Counts the items in the ListBox
- Shows the number in a message box



## ListBox: RemoveAt (Slide 32)
RemoveAt(): removes the item at a given index.
Example: `daysListBox.Items.RemoveAt(2);`

🟠Slide 32 code img_code_listbox_removeat.

csharp
if (listBox1.SelectedIndex != -1) // Check if an item is selected
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex); // Remove selected item
}
else
{
    MessageBox.Show("Please select an item to remove.");
}


What it does:
- `SelectedIndex` is the position of the selected item. It starts from 0
- If no item is selected, `SelectedIndex` is -1
- Item selected: remove it from the list
- No item selected: show a message
- The check stops an error from happening