 Chapter 4: Loops, Files, and Random Numbers (C#)
## while Loop (Slide 3)
🟠Slide 3 flowchart img_flowchart_while_loop.
- Test the Boolean expression first
- True: run the statement(s), then test again. False: leave the loop
- It tests first, so it is a pretest loop

## Ending Balance (Slides 8 and 9)
🟠Slide 8 code img_code_interest_rate_constant.
- `const` makes a value that cannot change
- INTEREST_RATE is 0.005 (0.5 percent each month)
- The letter `m` means the number is a decimal

🟠Slide 8 form img_form_ending_balance.
- startingBalTextBox: the starting balance
- monthsTextBox: the number of months
- endingBalanceLabel: shows the ending balance
- Buttons: calculateButton, clearButton, exitButton

🟠Slide 8 code img_code_add_interest.
- Finds the interest (INTEREST_RATE * balance) and adds it to the balance
- This line runs once for each month, inside a loop
- Example: 1000 becomes 1005

🟠Slide 9 form img_form_ending_balance_modified.
- The same form with a new ListBox named detailListBox
- Each month's result is added to this ListBox

🟠Slide 9 code img_code_detail_listbox.
- `Items.Add` adds one new line to the ListBox
- `count` is the month number
- `ToString("c")` shows money, like $1,005.00
- The `+` joins pieces of text into one line

🟠Slide 9 output img_output_ending_balance.
- Starting Balance 1000, Number of Months 8
- The ListBox shows month 1 ($1,005.00) to month 8 ($1,040.71)
- The Ending Balance label shows the last value

## Postfix and Prefix (Slides 11 and 12)
🟠Slide 11 code img_code_postfix.
- Postfix: the operator is after the variable
- Use the old value first, then change it

🟠Slide 11 code img_code_prefix.
- Prefix: the operator is before the variable
- Change the value first, then use it

🟠Slide 12 code img_code_postfix_example.
- count is 5 and x is 0. Then x = count++
- x gets 5 (the old value), then count becomes 6
- The second text in MessageBox.Show is the title of the box

🟠Slide 12 code img_code_prefix_example.
- count is 5 and x is 0. Then x = ++count
- count becomes 6 first, then x gets 6

## Questions: ++ and while (Slide 13)
🟠Slide 13 questions img_questions_increment_loop.
- 5.9: number is 5. After ++ it shows 6. After -- it shows 5
- 5.10: the loop runs 4 times and shows 0, 1, 2, 3
- When count is 4, the condition is false and the loop stops

## Squares Form (Slide 17)
🟠Slide 17 form img_form_squares.
- Left: the empty form with outputListBox and goButton
- Right: after clicking Go, the ListBox shows the squares of 1 to 10
- Example: "The square of 10 is 100"
- The slide does not show the code. A for loop from 1 to 10 can do it

## do-while Loop (Slides 18 and 20)
🟠Slide 18 flowchart img_flowchart_do_while.
- Run the statement(s) first, then test the Boolean expression
- True: run again. False: leave the loop
- It always runs at least one time (posttest loop)

🟠Slide 20 questions img_questions_do_while.
- 5.15: a posttest loop tests its condition after each iteration
- 5.16: while tests first. do-while tests after
- 5.17: the loop runs 1 time. It shows 0, then the test is false

