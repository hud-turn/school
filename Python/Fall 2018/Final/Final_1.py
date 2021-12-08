#12/5/2018
#Final Project #1

number1 = int(input("Enter number 1:"))
number2 = int(input("Enter number 2:"))
number3 = number1 + number2

if number1 > number2:
    print("The sum of", number1, " and ", number2," is ", number3," and ", number1, " > ", number2, ".")
elif number2 > number1:
    print("The sum of", number1, " and ", number2," is ", number3," and ", number1, " <", number2, ".")
else:
    print("The sum of", number1, " and ", number2," is ", number3," and ", number1, "==", number2, ".")
