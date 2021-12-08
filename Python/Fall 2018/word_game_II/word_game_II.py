# 3/5/18
# Guess the Word Game
# Part Two
import random

# Create a tuple of words and get a random one
words = ("dog", "cat", "alligator", "ostrich", "kangaroo", "lion")
word = random.choice(words)

print("\n"*150) # clear screen
# center some asterisks the same length as the word
asterisks = "*"*len(word)
print(asterisks.center(80," "))
displayWord = asterisks

ready = input("Do you want to guess the word? y/n ")
#Loop while the player wants to guess letters
while ready.lower() == "n":
    guess = input("Guess a letter ")
    
    if guess.lower() in word:
        print("Yes, "+guess+" is in the word")
        newWord = ""
        #replace the asterisk at that point
        for i in range(len(word)):
            if word[i] == guess.lower():
                newWord += word[i]
            else:
                newWord += displayWord[i]
        # displayWord becomes the new version, with more letters
        displayWord = newWord
    else:
        # If the letter is not in the word, displayWord doesn't change
        print("No, "+guess+" is not in the word")
        
    print(displayWord.center(80," "))
    # Get another guess
    ready = input("Do you want to guess the word? y/n ")

# Let them guess the word. They have one chance
wordGuess = input("What is the word? ")
wordGuess = wordGuess.lower()

if wordGuess == word:
    print("Yes! You Win! The word was " + word)
else:
    print("No, the word was " + word)

input("Press Enter to exit ")


