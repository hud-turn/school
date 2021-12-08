#11/12/2018
#Rock Paper Scissors
import random
            
rps = "Rock", "Paper", "Scissors";
cscore = 0
pscore = 0

def cdef():
    global cscore
    cscore += 1
def pdef():
    global pscore
    pscore += 1



while True:
    uselection = random.choice(rps)
    selection = uselection.lower()
    print("Welcome to Rock, Paper, and Scissors")
    print("The computers score is", cscore, " and the players score is", pscore)
    lpchoice = input("What would you like to throw?(Hint: It can only be Rock, Paper or Scissors.)\n I chose to throw: ")
    pchoice = lpchoice.lower()
    if pchoice == selection:
        print("It is a draw!")
        endu = input("Would you like to do another round?")
        end = endu.lower()
        if "n" in end:
            break
    else:
        if "r" in pchoice:
            if "s" in selection:
                print("You Won.")
                pdef()
            if "p" in selection:
                print("You Lost.")
                cdef()
        if "p" in pchoice:
            if "r" in selection:
                print("You Won.")
                pdef()
            if "s" in selection:
                print("You Lost.")
                cdef()
        if "s" in pchoice:
            if "p" in selection:
                print("You Won.")
                pdef()
            if "r" in selection:
                print("You Lost.")
                cdef()
        xretry = input("Would you like to play again?")
        retry = xretry.lower()
        if "n" in retry:
            break



         
        
    

