# 7/16/2015
# Modified 4.24.18 CJL
# This program demonstrates
# the use of a nested sequence
# to randomly select a first name
# and print its corresponding last name
# The nested sequence is also a constant

import random

# Create a nested sequence of first and last names
# It is all capitalized because it is being
# used as a constant
NAMES = (("Katharine","Johnson"),
         ("Grace","Hopper"),
         ("Albert","Einstein"),
         ("Guido","Van Rossum"),
         ("Timothy", "Berners-Lee"))

# Calculate the maximum index
maxIndex = len(NAMES)

#Print headers
print("First Name - Last Name")

# Print 10 random first and corresponding last name
for i in range(5):
    # Generate a random index between 0 and one less than the number
    # of names stored in the tuples
    random_int = random.randrange(maxIndex)

    #Get a random nested tuple
    random_name = NAMES[random_int]
    print("1.",NAMES[random_int])
    print("2.",random_name)
    
    # Access the values technique 1
    print("3.",random_name[0],"\t\t", random_name[1])
  
    # Access the values technique 2
    print("4.",NAMES[random_int][0],"\t\t\t",NAMES[random_int][1])
    print()

input("\nPress the Enter Key to Exit")

