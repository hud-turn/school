# Review for Final
import random

# Input two numbers into variables named num1 and num2
# from the keyboard. Add those two variables together and
# print the result. The result should be the sum of two numbers
# not the result of two appended strings. The result should
# be stored in a variable called num3

num1 = int(input("Enter number 1:"))
num2 = int(input("Enter number 2:"))
num3 = num1 + num2
print(num3)

# Compare num1 and num2 from above. If num1 is larger than num2 print
# the words "num1 is larger", if num2 is larger than num1 print
# the words "num2 is larger", if they are the same number print
# "num1 and num2 are the same"

if num1 > num2:
    print("num1 is larger")
elif num2 > num1:
    print("num2 is larger")
else:
    print("num1 and num2 are the same")


# Write a for loop that counts by twos from 0 to 100.
# The output should be all on the same line, wrapping to a second line.

for i in range(0,101,2):
    print(str(i)+",",end=" ")


# Use a while loop to ensure that the user enters
# a valid value, in this case a 'y', 'Y', 'n', or 'N'.
# Any other values are disregarded and the program
# keeps prompting until a valid value is received
# Don't forget to prime the loop
response = input("Play again? (Y/N)")
while response.upper() != "Y" and response.upper() != "N":
    response = input("Incorrect Value! Play again? (Y/N)")
    

# Place the word Supercalifragilisticexpialidocious in a string variable.
# Write the code that will build another string, result_str, by
# replacing all the vowel in the first string with dashes. If the letter
# is not a vowel, it will just be appended to the end of the result string.
# Print the result
# You may use additional string variables such as a constant string of
# vowels
start_str = "Supercalifragilisticexpialidocious"
result_str = ""
VOWELS = "AEIOU"
for letter in start_str:
    if letter.upper() in VOWELS:
        result_str += "-"
    else:
        result_str += letter
print(result_str)

# Create two tuples, one filled with first names and the other
# filled with corresponding last names. Generate a random number
# between 0 and the highest index of the tuples
# and print the first and last name at that index from the tuple

first_names = ("Jack", "Jill", "Jim", "John", "Jo")
last_names = ("Black","Pill", "Smith","Jones","Derek")
rand_index = random.randrange(5)
print(first_names[rand_index],last_names[rand_index])

