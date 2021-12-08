#12/5/2018
#Final #2
print("Counting backwards from 500 to 0 by 5s:")
for i in range(500,-1,-5):
    if i > 0:
        print(str(i)+",",end=" ")
    else:
        print("0")
        input("Press Enter to Continue")
