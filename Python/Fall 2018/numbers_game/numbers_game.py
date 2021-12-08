#Would you like to play a game?
#September 24 2018

import random

number = random.randrange(100)+1

#Opening Script to put it into a loop vvvv

pguess = 102

#Stuff

while pguess != number:
    ppguess = int(input("Select a number between 1 and 100:"))
    cguess = random.randint(1,100)
    if ppguess == number:
        input("You won!")
        break
    if ppguess > number:
        print("You Guessed High!")
        cguess = random.randint(1,100)
        print("Beep boop:",cguess)
        if cguess == number:
            input("The computer has won! Maybe the machines will take over the earth after all...")
            break
        if cguess > number:
            print("The computer Guessed high")
        if cguess < number:
            print("The computer Guessed low")

    if ppguess < number:
        print("You Guessed Low!")
        cguess = random.randint(1,100)
        print("Beep boop:",cguess)
        if cguess == number:
            input("The computer has won! Maybe the machines will take over the earth after all...")
            break
        if cguess > number:
            print("The computer Guessed high")
        if cguess < number:
            print("The computer Guessed low")
    if cguess == number:
        input("The computer has won! Maybe the machines will take over the earth after all...")
        break



