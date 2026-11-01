## Topics
1. 4.1 Decision Structures and the if Statement
2. 4.2 The if-else Statement
3. 4.3 Nested Decision Structures
4. 4.4 Logical Operators
5. 4.5 bool Variables and Flags
6. 4.6 Comparing Strings
7. 4.7 Preventing Data Conversion Exceptions with the TryParse Method
8. 4.8 Input Validation
9. 4.9 Radio Buttons and Check Boxes
10. 4.10 The switch Statement
11. 4.11 Introduction to List Boxes

## Decision Structures and the if Statement   ControlStructures

🟠 A control structure is a logical design that controls the order in which statements execute.

🟠 A sequence structure is a set of statements that execute in the order they appear.

🟠 A decision structure executes statements only under certain circumstances.

🟠 A specific action is performed only if a certain condition exists.

🟠 A decision structure is also known as a selection structure.

 # A Simple Decision Structure

🟠 A single-alternative decision structure provides only one alternative path of execution.

🟠 The if statement is used to create a simple decision structure.

🟠 The statements inside the if block execute only when the condition is true. 
🟠 The expression is a Boolean expression that evaluates to either true or false.

# Relational Operators
🟠 A relational operator determines whether a specific relationship exists between two values.
 >  " > " : greater than 
 > "< " : less than .
 > " >=" : greater than or equal to .
 > "<="  : less than or equeal to .
>  "==" : equal to   .
>   "!=" : not equal to .

##  The if-else Statement
🟠 An if-else statement executes one block of statements if its Boolean expression is true.

🟠 It executes another block if the Boolean expression is false.

🟠 It has two parts: an if clause and an else clause.

## Nested Decision Structures
🟠 A nested decision structure is a decision structure placed inside another decision structure.

🟠 Nested means "one inside another."

🟠 You can create nested decision structures to test more than one condition.
 ** if (expression)
{
    if (expression)
    {
        statements;
    }
    else
    {
        statements;
    }
}
else
{
    statements;
}** 

🟠 The outer if statement is evaluated first.

🟠 If the outer condition is true, the inner decision structure is evaluated.

🟠 If the outer condition is false, the outer else block executes.

## The if-else-if Statement

🟠 The if-else-if statement evaluates multiple conditions to make a final decision.

🟠 It is useful when a program has several possible conditions.
🟢**if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else
{
    statements;
}**
🟠 Conditions are checked from top to bottom.

🟠 The first condition that evaluates to true executes its block.

🟠 The else block executes if all previous conditions are false 

##  Logical Operators
🟠 Logical operators allow you to connect multiple Boolean expressions to create a compound expression.

🟠 C# provides three main logical operators: AND, OR, and NOT.
-- the AND is : && .
-- the OR is : || .
the NOT is  : ! 

##  bool Variables and Flags

🟠 true indicates that a condition exists.

🟠 false indicates that a condition does not exist.

##  Comparing Strings
🟠 You can use certain relational operators and methods to compare strings.

🟠 The == operator can compare two string variables.
🟠 String.Compare() returns 0 when the two strings are equal.

##  Preventing Data Conversion Exceptions with the TryParse Method
🟠 An exception is an error that occurs while a program is running.

🟠 Exceptions caused by users entering invalid data should be prevented when possible.

🟠 The TryParse methods can prevent exceptions caused by invalid numeric input.

Types of TryParse Methods

🟠 int.TryParse() converts a string into an integer if the conversion succeeds.

🟠 double.TryParse() converts a string into a double value if the conversion succeeds.

🟠 decimal.TryParse() converts a string into a decimal value if the conversion succeeds.

🟢 dataType.TryParse(string input, out targetVariable);

🟠 The input is the string value that needs to be converted.

🟠 The out keyword is required.

🟠 The target variable receives the converted value when the conversion succeeds.

##  Input Validation
🟠 Input validation is the process of inspecting data entered into a program to make sure it is valid before it is used.

🟠 It helps ensure that users enter reasonable and acceptable data.

TryParse and Input Validation

🟠 TryParse() checks whether the entered data can be converted into the required data type.

🟠 However, TryParse() does not check the integrity or reasonableness of the data.

🟠 A value can be a valid number but still be an unreasonable value.

##  Radio Buttons and Check Boxes
# Radio Buttons

🟠 Radio buttons allow users to select one choice from several possible choices.

🟠 When a user selects one radio button, the program automatically deselects the others in the same group.

🟠 This is known as mutually exclusive selection.

🟠 Only one choice can be selected at a time within the group.

# RadioButton Control

🟠 .NET provides the RadioButton control for creating groups of radio buttons.

# Common Properties

🟠 Text: Holds the text displayed next to the radio button.

🟠 Checked: A Boolean property that determines whether the control is selected or deselected.

🟠 You do not need to use == true when checking the Checked property.

# Check Boxes

🟠 Check boxes allow users to select multiple options.

🟠 They provide options such as true/false or yes/no.

🟠 Unlike radio buttons, multiple check boxes can be selected at the same time.

# Common Properties

🟠 Text: Holds the text displayed next to the check box.

🟠 Checked: Determines whether the check box is selected or deselected.

# The CheckedChanged Event

🟠 A CheckedChanged event occurs whenever a radio button or check box changes its Checked property.

🟠 You can create an event handler to respond when the selection changes.

🟠 Double-click the control in the Designer to create an empty CheckedChanged event handler.

## The switch Statement
🟠 The switch statement allows the value of a variable or expression to determine which path of execution the program will take.

🟠 It is a multiple-alternative decision structure.

🟠 It can be used as an alternative to an if-else-if statement when testing the same variable or expression against several different values.
 🟢 
 **switch (testExpression)
{
    case value_1:
        statement;
        break;

    case value_2:
        statement;
        break;

    default:
        statement;
        break;
}**

# Main Parts of a switch Statement

🟠 switch: Starts the decision structure.

🟠 testExpression: A variable or expression whose value determines the selected case.

🟠 case: Defines an individual possible value.

🟠 break: Ends the current case.

🟠 default: An optional section that executes when no case matches the test expression.
# Important Details

🟠 Each case contains one or more statements.

🟠 Each case is normally followed by a break statement.

🟠 The default section is optional.

🟠 According to the presentation, the test expression can have an int, string, or bool value.

## Introduction to List Boxes
🟠 A ListBox control displays a list of items and allows the user to select an item from the list.

🟠 It is useful when a program needs to present several choices to the user.

# Common ListBox Properties

🟠 Text: Contains the text of the currently selected item.

🟠 Items: Contains the items stored in the ListBox.

🟠 Items.Count: Contains the total number of items in the ListBox.

🟠 SelectedItem: Gets or sets the currently selected item.

🟠 SelectedIndex: Gets or sets the zero-based index of the currently selected item.

# SelectedItem and SelectedIndex

🟠 ListBox items have indexes starting from 0.

🟠 The first item has index 0.

🟠 The nth item has index n - 1.

🟠 If no item is selected, SelectedIndex returns -1.

🟠 An exception can occur if you try to get SelectedItem when no item is selected.

# Removing Items from a ListBox

1. Items.Remove()

🟠 The Items.Remove() method removes a specific item from a ListBox.
ListBox.Items.Remove(Item);

2. Items.RemoveAt()
🟠 The Items.RemoveAt() method removes an item at a specific index.

ListBox.Items.RemoveAt(Index);
3. Items.Clear()

🟠 The Items.Clear() method removes all items from a ListBox.
daysListBox.Items.Clear();



