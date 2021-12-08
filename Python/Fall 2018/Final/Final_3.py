#12/5/2018
#Final #3

letters = ("R", "S", "T", "L", "N", "E")

while True:
    user = input("Name one of the most common letters in the wheel of fortune puzzles: ")
    uuser = user.upper()
    if uuser in letters:
        print( uuser, "is one of the most common letters!")
        break
    else:
        print("Incorrect!")

input("Press Enter to Continue")
