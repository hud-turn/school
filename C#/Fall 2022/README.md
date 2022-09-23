Week 1/Assignment Name: List Print
	Create a list of type string and add 10 arbitrary names (e.g, Mike, Rosa, etc...) to it. 
	Then sort the list in descending (e.g., Z to A) order and display to screen.
_______________________________________________________________________________________________________________________________________________________________________
Week 1/Assignment Name: Console Menu
	Write a C# console application that has a menu with the following options:

	1. About this developer: display anything interesting about you.
	2. Quit: this option will quit the application. 
_______________________________________________________________________________________________________________________________________________________________________
Week 1/Assignment Name: Remove from list
	Modify your "List Print" assignment where after you print the names, you ask the user to enter a name to remove from the list.  
	Then display the new list.
_______________________________________________________________________________________________________________________________________________________________________
Week 1/Assignment Name: Analytics
	Create a list of type decimal and add 10  decimal numbers to it.

	-Calculate the average and display to screen.

	-Find minimum number and display to screen.

	-Find maximum number and display to screen.
_______________________________________________________________________________________________________________________________________________________________________
Week 1/Assignment Name: Student Grades Manager 1 (without OOP Concepts)
	Write a C# console application that allows me to type in any word and get the value of the word. 
	You will calculate the value of the word by assigning a value to each letter starting with A going through Z. 
	You will use the Fibonacci sequence (Links to an external site.) to assign values.  
	Start your sequence with zero so then the values will start as follows:

	A	=	0
	B	=	1
	C	=	1
	D	=	2
	E	=	3
	F	=	5
	G	=	8
	...	..	..
	Z	=	75025
	Using this series, the value of the word "CAB" would be equal to 2. 
	This is because C = 1, A = 0, and B = 1; 1 + 0 + 1 = 2.

	I should be able to type in any word and get a single number value back that represents the "value" of the word. 

	Below are some test words that you can use to validate that your code is working properly. 
	I will also test your code with other words. 

	UNC	6999
	objects	7181
	object	4597
	Zoology	122621
	Polymorphism	52934
_______________________________________________________________________________________________________________________________________________________________________
Week 1/Assignment Name: Student Grades Manager 2 (without OOP Concepts)
	
Write a C# console application that has a menu allowing an instructor to:

	Enter Students (id, first name, last name)
	Enter Student grade (e.g, 0-100; ex: 92.5)
	Show instructor a list of students
	Then instructor selects student by ID to enter grade
	Remove Students 
	Show instructor a list of ID + student first name last name
	Then instructor may input student id to remove 
	Grade Analytics 
	Display student grade average
	Display Minimum grade + Student Name
	Display Maximum grade + Student Name
	Display % of A's (90-100)
	Display % of B's (80-89)
	Display % of C's (70-79)
	Display % of D's (60-69)
	Display % of F's (0-59)
	Quit
	
Requirements:
- Must only use Lists. A list cannot contain any type of array/dictionary/list object.
- Grades are of type decimal
- Cannot allow creation of a duplicate student based on ID
_______________________________________________________________________________________________________________________________________________________________________
Week 2/Example 1:
Add a new property to the class Student called ‘Grade’, set it as 
Decimal.
Write code that is able to do the following:
• Create a list of type Student
• Add 3 students with arbitrary grades to the list
• Display a list of all students with their grade: Ex: “Moe Manshad, 0”
• Calculate and display grade average
_______________________________________________________________________________________________________________________________________________________________________
Week 2/Example 2:
Create a class called Course
• A course has a name, course id, a list of Students (use Student class from Exercise 1)
• A course has the following methods:
• GetAverageGrade
• GetMinGrade
• GetMaxGrade
• GetPercentGrades
• I can choose As, Bs, Cs, Ds or Fs
_______________________________________________________________________________________________________________________________________________________________________
Week 2/Example 3:
Create three classes:

PassFailCourse:
• Property: Course Name (String)
• Property: Grade (Boolean; TRUE = pass, FALSE = fail)
• Method: Passed: Return the grade

GradedCourse:
• Property: Course name (String)
• Property: Grade (Decimal; 0-100)
• Method: Passed: Return TRUE if the grade is >=70, otherwise return FALSE

Degree:
• Property: PassFailCourse PFCourseA
• Property: PassFailCourse PFCourseB
• Property: GradedCourse GCourseA
• Property: GradedCourse GCourseB
• Method: Passed: a degree is fulfilled (passed) if at least three out of the four courses are passed.
_______________________________________________________________________________________________________________________________________________________________________