#11/5/2018
#Seat Reservation Program

restbl = {"A1":"Peter","A2":"Jonathan"}

while True:
    print("\nThis is an airline booking program. You can select Seats A-D and Rows 1-25.\nYou can.\n")
    print("1 - Reserve a seat.\n")
    print("2 - Cancel a reservation.\n")
    print("3 - Show what seats are taken and are available.\n")
    print("4 - Check if an individual seat is open.\n")
    print("5 - Exit the program.\n")
    choice = int(input("What would you like to do?: "))
    
    if choice == 1:
        addrescol = input("\nWhich row would you like to reserve?(A-D and will decide if you are by a window or not.)")
        addresrow = input("\nWhich column would you like to reserve? (A number between 1 and 25):")
        addres = addrescol + addresrow
        addresnme = input("\nWhat is the name of the passenger?")
        addres = addres.upper()
        addresnme = addresnme.capitalize()
        while addres in restbl:
            addresrow = input("\nThat seat is already reserved! Chose a different seat.\nWhich column would you like to reserve? (A number between 1 and 25):")
            addrescol = input("\nWhich row would you like to reserve?(A-D and will decide if you are by a window or not.)")
            addres = addrescol + addresrow
        restbl[addres] = addresnme     
      
    if choice == 2:
        delres = input("\nWhich reservation would you like to delete?")
        if delres not in restbl:
            print("\nThis seat was not reserved. You can book it if you want to.")

        else:
            rusure = input("\nAre you sure that you want to delete the reservation?")
            rusure = rusure.lower()
            if "y" in rusure:
                del restbl[delres]
                print("\nYou sucessfully deleted the reservation")
            if "n" in rusure:
                print("\nYou did not delete the reservation.")

    if choice == 3:
        print(restbl)

    if choice == 4:
        snglqry.upper() == input("\nWhat seat are you looking for?")
        if snglqry in restbl:
            print("\nYes it appears that seat", snglqry," is reserved to", restbl[snglqry])
        else:
            print("\nNo, it appears that", singlequery," is not reserved")
        
    if choice == 5:
        break
    
    

