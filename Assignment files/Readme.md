# File Reading and Writing System in C#

## Project Description
This project is used to create, write, read, clear, and delete a file using C# Windows Forms.

## buttons

1. *Write File:* Creates a file named reading.doc and writes text into it using ##StreamWriter.

2. **Read All Lines:* Reads all lines from the file using `File.ReadAllLines()` and displays them in a ListBox.

3. *Read Block:* Reads the file in small blocks of 5 characters using `StreamReader.ReadBlock()`.

4. *Read All Bytes:* Reads the file as bytes using `File.ReadAllBytes()` and converts them into text.

5. *Clear ListBox:* Removes all displayed items from the ListBox.

6. *Delete Items:* Clears the file content but keeps the file.

7. *Delete File:* Deletes the entire file.

8. *Close Application:*Closes the application.

## Technologies Used
- C#
- Windows Forms
- StreamWriter
- StreamReader
- File Class
- ListBox

## How to Use
1. Run the application.
2. Click the Write button to create the file.
3. Click a Read button to display the file content.
4. Click Clear to clear the ListBox.
5. Click Delete Items to empty the file.
6. Click Delete File to remove the file.
7. Click Close to exit the application.
