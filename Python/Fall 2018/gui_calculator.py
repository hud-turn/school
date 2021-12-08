from tkinter import *
#these sources helped me see how it works.
#https://www.geeksforgeeks.org/python-simple-gui-calculator-using-tkinter/
#https://www.techinfected.net/2016/02/make-gui-calculator-in-python-windows-linux.html
#https://codereview.stackexchange.com/questions/161569/gui-calculator-using-tkinter
#https://python-textbok.readthedocs.io/en/1.0/Introduction_to_GUI_Programming.html

#disclaimer I followed this V guide fairly closely trying to figure out how it works
#I went through and worked on it and figured out how it was built.
#I tried going through the Aims version but I had a difficult time with it
#and spent several hours on it.
#https://medium.com/@adeyinkaadegbenro/project-build-a-python-gui-calculator-fc92bddb744d

class Calculator:
    def __init__(self, master):
        self.master = master
        master.title("Calculator")
#This sets the title of the ^ window
        
#this makes the window and sets the size of the window.
        self.LCD = Text(master, state='disabled', width=30, height=3,background="white", foreground="black")

#this makes the LCD/text entry area aka LCD display
        self.LCD.grid(row=0,column=0,columnspan=4,padx=5,pady=5)
        self.LCD.configure(state='normal')
        self.equation = ''
        #^this makes the lcd area by default

#make 17 buttons, the way they are listed and composed onto the gui frame
#lists them sequentially like reading a page because of the use of the for
#argument down below.
        b1 = self.makeButton(7)
        b2 = self.makeButton(8)
        b3 = self.makeButton(9)
        b4 = self.makeButton("CLR",None)
        b5 = self.makeButton(4)
        b6 = self.makeButton(5)
        b7 = self.makeButton(6)
        b8 = self.makeButton("/")
        b9 = self.makeButton(1)
        b10 = self.makeButton(2)
        b11 = self.makeButton(3)
        b12 = self.makeButton("x")
        b13 = self.makeButton(".")
        b14 = self.makeButton(0)
        b15 = self.makeButton('+')
        b16 = self.makeButton('-')
        b17 = self.makeButton('=',None,34)

        buttons = [b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17]

        count = 0
# arranging the buttons into a grid formation
        for row in range(1,5):
            for column in range(4):
                buttons[count].grid(row=row,column=column)
                count += 1
        buttons[16].grid(row=5,column=0,columnspan=4)

    def makeButton(self,val,write=True,width=7):
        # ^ This creates a button and assigns a value to it

        return Button(self.master, text=val,command = lambda: self.click(val,write), width=width)

    # This V sees if stuff is going to be added to LCD or if the whole line
    #is going to be thrown out and replaced with awnser
    def click(self,text,write):
        if write == None:
            if text == '=' and self.equation:
                self.equation= re.sub("x", '*', self.equation)
                #changes the value from a x to a * so it is usable by the program
                print(self.equation)
                # V Puts the equation through the program
                answer = str(eval(self.equation))
                # V clears the LCD to make way for the awnser
                self.clear_LCD()
                # V prints new awnser
                self.insert_LCD(answer,newline=True)
            elif text == "CLR":
                self.clear_LCD()
            
            
        else:
            # add text to LCD
            self.insert_LCD(text)
        
            
#this string clears the LCD and allows it to be reset to make way for new numbers
    def clear_LCD(self):
        self.equation = ''
        self.LCD.configure(state='normal')
        self.LCD.delete('1.0', END)
        
    #This V puts numbers on the LCD display
    def insert_LCD(self, value,newline=False):
        self.LCD.configure(state='normal')
        self.LCD.insert(END,value)
        self.equation += str(value)
        self.LCD.configure(state ='disabled')

root = Tk()
my_gui = Calculator(root)
root.mainloop()
