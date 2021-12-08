#Word Guessing
#October 8th 2018

#DISCLAIMER I looked online for assistance on this project
# This is the code that I used to help me understand this.
#https://stackoverflow.com/questions/19926167/random-word-guessing-game
import random

#List of words
lword = "python", "tuple", "string", "loop", "compiling"

#Word Selector
rword = random.choice(lword)

#Word blank inserter
spaces = '*' * len(rword)
text = "The Secret Word is this long "
ctext = text.center(80)
cspaces = spaces.center(80)
print(ctext, "\n",cspaces)
print(rword)


#The previous string allows for unlimited ways to say yes as long as there is the
#required y. I incorporated .lower into wguess so it would not be case sensitive
while True:
    response = input ("Would you like to guess the word? Input a Yes or No awnser: ")
    lresponse = response.lower()
    if "y" in lresponse:
        wguess = input("What is your guess? ")
        lwguess = wguess.lower()
        if wguess == rword:
            print("You guessed the word correctly! The word was",rword)
            input("Hit any key to exit")
            break
        else:
            print("You guessed the word incorrectly!")
  
    if "n" in lresponse:
        lguess = input("What is the first letter that you guess?")
        llguess = lguess.lower()
        
           
