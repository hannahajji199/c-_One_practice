## Parse
🟠Slide 28 code img_code_parse_methods.
🟠Slide 40 code img_code_btn_calculate_average.
🟠Slide 36 code img_code_try_catch_mpg.
Parse(): Changes text from a TextBox into a number. Use int.Parse, double.Parse, or decimal.Parse.
>Example: int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
If Parse fails, the program jumps to the catch block.
>Example: MessageBox.Show("Invalid data was entered.");

## Type Casting
🟠Slide 23 code img_code_cast_operator.
🟠Slide 27 code img_code_integer_division_cast.
(int): Changes a decimal number to a whole number. A cast cannot change a string to a number.
>Example: wholeNumber = (int)moneyNumber;
(double): Stops integer division, so 7 / 3 is not 2.
>Example: MessageBox.Show(((double)x / y).ToString());

## ToString
🟠Slide 30 code img_code_tostring.
🟠Slide 32 table img_table_tostring_formats.
ToString(): Changes a number to text so a Label or TextBox can show it.
>Example: grossPayLabel.Text = grossPay.ToString();
ToString("n3"): Formats the number. Format letters are N, F, E, C, and P.
>Example: ToString("P") gives 23.40%.

## Exception Message
🟠Slide 38 code img_code_exception_message.
Message: Gives the error text of an exception.
>Example: MessageBox.Show(ex.Message);

## Clear
🟠Slide 5 code img_code_clear_textbox.
Clear(): Empties a TextBox. You can also assign "" or string.Empty to the Text property.
>Example: textBox1.Clear();

## Focus
🟠Slide 47 code img_code_focus_method.
>Focus(): Moves the cursor to a control.
>Example: nameTextBox.Focus();

## Math Class
🟠Slide 44 code img_code_math_class.
Math.Sqrt(x): Gives the square root of x.
>Example: Math.Sqrt(25) gives 5.
Math.Pow(x, y): Gives x to the power of y.
>Example: Math.Pow(2, 3) gives 8.
Math.Max(x, y) and Math.Min(x, y): Give the bigger or the smaller value.
Math.Round(x): Rounds x to the nearest whole number.
Math.PI and Math.E: Two ready constants.

