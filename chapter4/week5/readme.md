## Writing to a File (Slide 24)
🟠Slide 24 output img_output_writeline_write.
- WriteLine writes the item and starts a new line
- Write writes the item without a new line
- Left file: One, Two, Three on separate lines
- Right file: OneTwoThree on one line

## Ways to Read a File (Slide 28)
All four examples read the file lstcourse.doc and use a ListBox.

🟠Slide 28 code img_code_readalltext.
- `File.ReadAllText` opens, reads everything, and closes the file
- The whole text is added as one item

🟠Slide 28 code img_code_readtoend.
- `File.OpenText` opens the file with a StreamReader
- `ReadToEnd()` reads from the current position to the end
- `Close()` closes the file

🟠Slide 28 code img_code_readline.
- `ReadLine()` reads one line only
- It runs once here, so only the first line is read
- The green line is a warning from Visual Studio

🟠Slide 28 code img_code_read_char.
- `Read()` reads one character
- `(char)` changes the number that Read returns into a character
- Only the first character is added to the ListBox

## Reading a File with a Loop (Slide 30)
🟠Slide 30 code img_code_read_file_loop.
- Opens the file from a full path. Double backslash is needed in a string
- `EndOfStream` is true at the end of the file
- The loop reads line after line and adds each line to the ListBox
- `catch` shows an error message if something fails (for example, a missing file)

## Dialog Boxes (Slides 31 and 32)
🟠Slide 31 dialog img_dialog_open.
- The standard Windows Open box (OpenFileDialog)
- Has a File name field and the buttons Open and Cancel

🟠Slide 31 dialog img_dialog_save_as.
- The standard Windows Save As box (SaveFileDialog)
- Has File name, Save as type, and the buttons Save and Cancel

🟠Slide 32 designer img_designer_open_file_dialog.
- The Toolbox has OpenFileDialog and SaveFileDialog under Dialogs
- A dialog control does not show on the form
- It shows in the component tray as openFileDialog1
- `ShowDialog()` shows the box

## Using the Dialog Result (Slides 34 and 36)
🟠Slide 34 code img_code_open_dialog_result.
- `ShowDialog()` returns the button the user clicked
- OK: open the file and read a line. Cancel: show a message
- `"Path"` is only a placeholder. Real code uses `openFileDialog1.FileName`

🟠Slide 36 code img_code_open_dialog_filename.
- `FileName` holds the path and name of the selected file
- Opens it, reads line by line with a loop, adds the lines to the ListBox, then closes it
- Warning: it does not check OK or Cancel. Cancel can cause an error

## Save Dialog (Slide 38)
🟠Slide 38 code img_code_save_dialog.
- Shows the Save As box
- OK: creates the file at the chosen place and writes "Mohamed" in it
- Cancel: shows a message
- `CreateText` erases the old content if the file already exists