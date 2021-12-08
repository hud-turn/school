#Mad Libs
#11/19/2018
   


import os
print("Welcome to Mad Libs! The game where you make up your own sentences.")
print("You can do Jack and Jill and Three Blind Mice")
uchoice = input("Which Mad Libs would you like to do?")
choice = uchoice.lower()

if "j" in choice:
    file = "JaJ.txt"
    if os.path.exists(file):
        with open(file,'r') as file:
            try:
                print("You chose Jack and Jill!")
                print("You will need to select words that will replace out sections of the original rhyme.")
                person1 = input("\nWhat name will you be replacing Jacks name with? ")
                person2 = input("\nWhat name will you be replacing Jills name with? ")
                place = input("\nWhat will they be going up instead of a hill? ")
                noun = input("\nThey went up to the top of " + place +" in order to fetch something...\n What was it?")
                bodypart = input("\nWhat will the person break when they fall off of the " + noun + "?")
                #having issues getting it to stick into the file.....
                file.read()
            except:
                sys.exit()
                print()
    
if "t" in choice:
    file = "TBM.txt"
    if os.path.exists(file):
        with open(file,'r') as file:
            try:
                print()
                print("You chose Three Blind Mice!")
                print("You will need to select words that will replace out sections of the original rhyme.")
                noun = input("\nWhat will you be replacing the mice with? ")
                verb = input("\nWhat will the " + noun + "s be doing? ")
                noun2 = input("\nWhat will you be replacing the farmers wife with? ")
                verb2 = input("\nWhat will " + noun2 + " be doing to their tails? ")
                noun3 = input("\nWhat will the " + noun2 + " be using? ")
                #having issues getting it to stick into the file.....
                file.read()
                
            except :
                sys.exit()
                print()
   

    
    
    

          
