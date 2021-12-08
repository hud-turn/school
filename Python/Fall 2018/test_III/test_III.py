import random
wordlist = ['giraffe','dolphin',\
            'pineapple','durian',\
            'blue','purple', \
            'heart','rectangle']

#Obtain random word
randWord = random.choice(wordlist)

#Determine length of random word and display number of blanks
blanks = '_ ' * len(randWord)
print ()
print ("Word: ",blanks)


#Set number of failed attempts
count = 6

#Obtain guess
while True:
    print ()
    guess = input ("Please make a guess: ")   
    if len(guess) != 1:
        print ("Please guess one letter at a time!")
    elif guess not in 'abcdefghijklmnopqrstuvwxyz':
       print ("Please only guess letters!")

#Check if guess is found in random word
    for letters in randWord:
        if guess == letters:
            letterIndex = randWord.index(guess)
            
            print ("Guess is correct!")
        else:
            print()
    print() 
    print("Word: ",newBlanks) 

