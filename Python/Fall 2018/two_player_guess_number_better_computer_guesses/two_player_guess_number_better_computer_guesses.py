# Program 5
# Two Player Guess the Number
# 01/19/2018
# This version makes the computer guess reasonable numbers
# by changing the range of the random.randint()
# but the computer may repeat previous guesses

import random  

print("\tWelcome to 'Guess My Number'!")
print("\nI'm thinking of a number between 1 and 100.")
print("Try to guess it in as few attempts as possible.\n")

# set the initial values
the_number = random.randint(1, 100)
# Show the number (for debugging purposes)
#print("The number is: ",the_number)

guess = 0
# guess is neither high nor low to begin
too_high = 100
too_low = 1

while guess != the_number:
    # Get the player's guess
    guess = int(input("Take a guess: "))
    # guess is too high
    if guess > the_number:
        print("Player guess lower...\n")
        too_high = guess
    # guess is too low
    elif guess < the_number:
        print("Player guess higher...\n")
        too_low = guess
    else:
        print("Game over! The number was", the_number, "The Player Wins!")
        break
   
    # The computer guesses
    # The ranges are +1 and -1 to prevent repeat of those numbers
    guess = random.randint(too_low+1, too_high-1)
    print("The computer guesses", guess)
    # guess is too high
    if guess > the_number:
        print("Computer guess lower...\n")
        too_high = guess
    # guess is too low    
    elif guess < the_number:
        print("Computer guess higher...\n")
        too_low = guess
    else:
        print("Game over! The number was", the_number, "The Computer Wins!")
        break
    #Display current high and low guesses
    print("High Guess:", too_high)
    print("Low Guess:", too_low)
   
input("\n\nPress the enter key to exit.")

