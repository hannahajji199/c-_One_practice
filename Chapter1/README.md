<<<<<<< HEAD
# objectives 
  # topics 
  .1 Objects
1.2 The Program Development Process
1.8 Getting Started with Visual Studio
2.1 Getting Started with Forms and Controls
2.2 Creating the G U I for Your First Visual C# Application
2.3 Introduction to C# code
2.4 Writing Code for the Hello World Application
2.5 Label Controls
2.6 Making Sense of IntelliSense
2.7 PictureBox Controls
2.8 Comments, Blank Lines, and Indentation
2.9 Writing the Code to Close an Application’s Form
2.10 Dealing with Syntax Errors

## Objects

🟠 An Object is a program component that contains data and performs operations.

🟠 Programs that use object-oriented programming use objects to perform specific tasks.

- Every object has:

🟠 Properties (fields):  the data stored in the object.

🟠 Methods : the operations the object can perform.

- Example: a Wage Calculator is a form object made up of label, textbox, and button objects.

## Controls

🟠 Objects that are visible in the GUI (interface) are known as controls (e.g., Label, Button, TextBox).

🟠 There are objects that cannot be seen, such as Timer and OpenFileDialog.

🟠 A Class is code that describes a particular type of object.

## .NET Framework

🟠 .NET : is a collection of classes and other code used to create programs for Windows.

🟠 C# :  is a language supported by .NET.

🟠 Controls are defined by specialized classes that .NET provides; you can also write your own class to perform a special task.

##  Getting Started with Visual Studio

🟠 Visual Studio is a professional Integrated Development Environment (IDE).

- It includes:

🟠 Designer Window : where the form is designed.

🟠 Solution Explorer Window : the list of project files (Form1.cs, Program.cs, etc.).

🟠 Properties Window : the list of properties for the selected object.

🟠 Auto Hide: a window can display as just a tab on the edge to save space.

## Menu Bar & Standard Toolbar

🟠 Menu Bar: File, Edit, View, Project, Build, Debug, etc.

🟠 Standard Toolbar: the most commonly used buttons (New Project, Open, Save, Undo/Redo, Start Debugging, Find).

## The Toolbox

🟠 A window for selecting the controls to add to the app.

🟠 Typically located on the left side, and often in Auto Hide mode.

🟠 Divided into sections such as All Windows Forms and Common Controls.

## Tooltips

🟠 A small box that pops up when the mouse hovers over an icon on the toolbar/toolbox to show what it does.

## Docked and Floating Windows

🟠 Docked: a window attached to an edge of Visual Studio.

🟠 Floating: a window you can click and drag around the screen.

🟠 A window cannot float if it is in Auto Hide mode.

🟠 You can switch between Dock / Float by right-clicking the window's title bar.

## Projects and Solutions

🟠 Project: the application you are building, made up of files || Form1.cs, Program.cs||

🟠 Solution: a container that can hold one or more projects.

🟠 Each project, however, is saved in its own solution.

## Specifying the Project Name & Displaying the Designer

🟠 The project name is entered the first time it is saved.

🟠 If the Designer doesn't display automatically, right-click Form1.cs in Solution Explorer and choose View Designer.

## Getting Started with Forms and Controls

🟠 When a new Windows Forms App is started, an empty form named Form1 is automatically created (300 x 300 pixels).

🟠 Bounding Box: the thin dotted lines surrounding the form in the Designer, with sizing handles used to resize it.

## The Properties Window

🟠 Properties are the settings that control how an object looks and behaves.

🟠 The Properties Window shows 2 columns: name (left) and value (right).

🟠 To change a value: select the object → find the property name → change its value 
- example: change the Text property of Form1 from "Form1" to "My First Program"

## Adding & Deleting Controls

🟠 Toolbox: double-click or drag the control onto the form.

🟠 You can resize and reposition the control, and change its properties.

🟠 Delete: select the control and press the Delete key.

## Rules for Naming Controls (Identifiers)

🟠 The first character must be a letter or an underscore (_).

🟠 The other characters can be letters/numbers/underscores.

🟠 The name cannot contain spaces.

🟠 Valid examples: showDayButton, DisplayTotal, _ScoreLabel.

🟠 The common convention used is camelCase.

##  Creating the GUI for Your First C# Application

🟠 The app has a Form and a Button control.

🟠 When the button is clicked, it displays "Hello World".

##  Introduction to C# Code

🟠 Code is organized into three levels:

- Namespace : a container that holds classes.

- Class :  a container that holds methods.

- Method :  a group of statements that perform a specific task.

-  The file containing program code is called a source code file.

## Source Code Files

-- Every new project automatically creates:

- Program.cs – the app's start-up code.

- Form1.cs – code associated with the Form1 form.

- You can open them through Solution Explorer right-click → View Code.

##  Writing Code for the Hello World Application

🟠 When handling events, code is added to the event handler for the desired action.

## Event-Driven Programming

🟠 GUI applications are event-driven, meaning they respond to events such as button clicks, key presses, and mouse moves.

🟠 When a control (like a Button) is double-clicked in the Designer, a default Event Handler is automatically attached.

🟠 Event handler: a method that runs when a specific event occurs.

## Message Boxes

🟠 MessageBox.Show() : is a method provided by .NET to display a message dialog box.

- Example:
  private void myButton_Click(object sender, EventArgs e)
  {
      MessageBox.Show("Thanks for clicking the button!")
  }
##  Label Controls

🟠 A Label displays text on a form or shows program output.

🟠 Commonly used properties:

🟠 Text :  the text.

🟠 Name : the control's name.

🟠 Font : set the font, style, and size.

🟠 BorderStyle : a border around the text.

🟠 AutoSize : how the control resizes.

🟠 TextAlign : where the text sits ||Top Middle, Bottom,  each og them has left , center and right to choose therefore it's 9 position at all  || 

## Using Code to Display Output

🟠 The = sign : is the assignment operator.

🟠 The item receiving the value must be on the leftside  of Assigment operator .

🟠 The Text property only accepts a string.

🟠 To clear a Label's text: answerLabel.Text = "";



##  PictureBox Controls

🟠 A PictureBox displays an image on the form.

🟠 Commonly used properties:

🟠 Image : the image displayed.

🟠 SizeMode : how the image is displayed.
-- it has 4 properties : it's Normal by default 

- StretchImage 
- autosize 
- centerImage
- zoom 


🟠 Visible : whether the control is visible or not.

🟠 You can create a Click event handler for a PictureBox (Creating Clickable Images).

  ## Sequential Execution of Statements

🟠 The statements in a method execute in the order they appear.

🟠 An incorrect order of statements can cause logic errors (example: both pictures ending up hidden at the same time).

## Comments, Blank Lines, and Indentation

🟠 Comment: a brief note added to source code to explain parts of the program.

🟠 Line comment: // text

🟠 Block comment: /* ... */

🟠 Blank lines and indentation make the code much easier to read (human-readable).

## Writing the Code to Close an Application's Form

🟠 this.Close(); → closes only the current form.

🟠 Application.Exit(); → closes the entire application.

🟠 A common practice is to create an Exit button with this code attached.

##  Dealing with Syntax Errors

🟠 The Visual Studio Code Editor checks each statement as you type to find syntax errors.

🟠 If an error exists, it is underlined with a jagged line in red.

🟠 If you try to compile/run a program with an error, a dialog appears reporting that build errors occurred.