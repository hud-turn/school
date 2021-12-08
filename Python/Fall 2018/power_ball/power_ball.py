#PowerBall
#October 29th 2018
import random


#first selection   
while True:
    randticket = random.sample(range(1,9), 3)
    pwrticket = random.sample(range(1,3), 1)
    while pwrticket in randticket:
        pwrticket = random.sample(range(1,9), 1)
    print(" Welcome to Powerball! \n Enter a number between 1 and 9 for each entry and you can not reuse numbers. ")
    print("You have selected to chose your own numbers, select your first number")
    while True:
        entry1 = int(input("Entry #1: "))
        if  1 <= entry1 and entry1 <= 9:
            print()
            break
        else:
            print("Your first entry was ",entry1," try using a different number between 1 and 9.") 
#second Selection
        
    while True:
        entry2 = int(input("Entry #2: "))
        if entry1 != entry2 and 1 <= entry2 and entry2 <= 9:
            print()
            break
        else:
            print("Your first entry was ",entry1," try using a different number between 1 and 9.")
#third selection
    while True:
        entry3 = int(input("Entry #3: "))
        if entry1 != entry2 and entry2 != entry3 and 1 <= entry3 and entry3 <= 9:
            print()
            break
        else:
            print("Your first entry was ",entry1," and your second entry was ",entry2," try using a different number between 1 and 9.") 

        
#powerball selection
    while True:
        pwrball = int(input("Powerball:"))
        if entry1 != pwrball and entry2 != pwrball and entry3 !=pwrball and 1 <= pwrball and pwrball <= 9:
            print()
            break
        else: 
            print("Your first entry was ",entry1,"your second entry was ",entry2," and your third entry was",entry3,"try using a different number for the powerball.")

    print("Your ticket",entry1, entry2, entry3, pwrball)
    print("The actual numbers", randticket, pwrticket)
    correct = 0
    pwrcorrect = 0
    if entry1 in randticket:
        correct = 0 +1

    if entry2 in randticket:
        correct = 0 +1

    if entry3 in randticket:
        correct = 0 +1

    if pwrball in pwrticket:
        pwrcorrect = 0 +1

    if correct == 0:
        print("Better luck next time!")

    if correct == 1:
        print("You correctly guessed one of the numbers correctly and won $1.00")

    if correct == 0 and pwrcorrect ==1:
        print("You guessed the powerball correctly but not any other numbers, you win $2.00")

    if correct == 2 and pwrcorrect == 0:
        print("You correctly guessed two of the numbers correctly and won $10.00")

    if correct == 2 and pwrcorrect == 1:
        print("You correctly guessed two of the numbers correctly and the powerball and won $20.00")

    if correct == 3 and pwrcorrect == 0:
        print("You correctly guessed three of the numbers correctly and won $100.00")

    if correct == 3 and pwrcorrect == 2:
        print("You correctly guessed three of the numbers correctly and the powerball and won $1000.00")

    restart = input("Would you like to restart the powerball? Reply with a simple yes or no awnser")

    if "n" in restart.lower():
        break
 
        
                
        
                



