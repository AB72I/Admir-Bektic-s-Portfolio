//*******************************************************************************************************
//
//				File:			LinkedList.h
//
//				Student:		Admir Bektic
//
//				Assignment:		Program  #4
//
//				Course Name:	Data Structures I
//
//				Course Number:	COSC 3050 - 01
//
//				Due:			September 29, 2021
//
//
//				This program will show student data.
//
//				Other files required:
//						1. Node.h
//						2. LinkedList.h
//						3. Student.h
//
//*******************************************************************************************************

#include <iostream>
#include <fstream>
#include <string>
using namespace std;

#include "Student.h"
#include "LinkedList.h"

//*******************************************************************************************************

char getChoice();
void process(LinkedList<Student> &);
void buildList(LinkedList < Student >  &);
void displayStudents(LinkedList < Student >  &);
void countStudents(LinkedList < Student >  & );
void deleteStudent(LinkedList < Student >  & );
void findStudent(LinkedList < Student >  & );

//*******************************************************************************************************

int main()
{
	LinkedList < Student > studentList;

	buildList(studentList);
	process(studentList);

	return 0;
}

//*******************************************************************************************************

char getChoice()
{
	char choice;

	cin >> choice;
	choice=toupper(choice);

	return choice;
}

//*******************************************************************************************************

void process(LinkedList<Student> & list)
{
	char choice;
	Student data;

	do
	{
		cout << string(50, '*') << endl;
		cout << "A. search for a student in the list" << endl;
		cout << "B. delete a student from the list" << endl;
		cout << "C. count the number of students in the list" << endl;
		cout << "D. display the list" << endl;
		cout << "E. quit" << endl;
		cout << "Please enter a choice: ";
		choice = getChoice();

		switch (choice)
		{
			case 'A':
				findStudent(list);
				break;

			case 'B':
				deleteStudent(list);
				break;

			case 'C':
				countStudents(list);
				break;

			case 'D':
				displayStudents(list);
				break;

			case 'E':
				cout << "quiting" << endl;
		}
	} while (choice!='E');
}

//*******************************************************************************************************

void  buildList(LinkedList < Student >  & list)
{
	ifstream fin("studentFile.txt");
	Student data;
	
	if (fin.fail())
	{
		cout << "error" << endl << endl;
	}
	else
	{
		while (fin>>data)
		{
			list.insert(data);
		}
		
		fin.close();
	}
	
}

//*******************************************************************************************************

void displayStudents(LinkedList < Student >  & list)
{
	cout << "Display all students' info" << endl;
	list.display();
}

//*******************************************************************************************************

void findStudent(LinkedList < Student >  & list)
{
	Student temp;
	int id;
	cout << "Search for a student in the list: " << endl;
	cout << "Please enter: ID number: ";
	cin >> id;
	temp.setId(id);
	temp.getId(id);
	list.find(temp);
	cout << endl << temp;
}

//*******************************************************************************************************

void countStudents(LinkedList < Student >  & list)
{
	int num=0;

	cout << "counting number of students:" << endl;
	list.getSize(num);
	cout << num << endl;
	
}

//*******************************************************************************************************

void deleteStudent(LinkedList < Student >  & list)
{
	Student temp;
	int id;
	cout << "delete a student in the list: " << endl;
	cout << "Please enter: ID number: ";
	cin >> id;
	temp.setId(id);
	temp.getId(id);
	list.del(temp);
	cout << endl << temp << "has been deleted" << endl;
}

/*
**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: c
counting number of students:
61
**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: d
Display all students' info
3930:Leibniz, Gottfried W MATH 1.95

4454:Atanasoff, Eniac C CPSC 1.88

4559:Shyster, Samuel D SOCI 1.95

4777:Gauss, Carl F MATH 4

5316:GotoDijkstra, Edgar G CPSC 4

5430:Nightingale, Florence K NURS 3.15

5710:Busch, Arch E ENGR 2.75

5873:Psycho, II,  Prunella E PSYC 2.99

7107:Shoemaker, Imelda M POLS 3.15

7448:Roosevelt, Rose Y POLS 2.95

7844:Aardvark, Anthony A ENGR 2.79

7885:Fibonacci, Leonard O MATH 3.25

9463:Hochschule, Hortense C EDUC 2.7

9743:Johnson, James L ENGR 3.15

10236:Andrews, Peter J CPSC 2.78

10304:Deutsch, Sprechen Z GERM 3.05

11688:Kronecker, Leo P MATH 2.75

11749:Issacson, Jacob A RELI 2.99

11951:Mouse, Michael E EDUC 1.99

13511:Pitt, Stew GNED 0.21

14674:Rockne, Newton K PE 1.98

14815:Tchaikovsky, Wolfgang A MUSC 2.75

15052:Einstein, Alfred M ENGR 2.78

15671:Rembrandt, Roberta E ART 2.2

15755:VandenVander, Vanessa V HIST 3.74

15802:Pascal, Blaze R CPSC 1.98

15889:Gazelle, Gwendolyn D PE 2.78

16183:Kuts, Cole FOOD 3.98

16540:Weerd, Dewey L PHIL 2.99

16622:Issacson, Esau B RELI 2.98

17376:Scrooge, Ebenezer T SOCI 3.25

17424:Nakamura, Toky O SOCI 1.95

18213:Marx, Karl Z ECON 2.75

18264:Lucky, Lucy L HIST 2.29

19077:Medes, Archie L ENGR 3.1

19918:Virus, Vera W CPSC 3.25

20454:Chicita, Juanita A BIOL 2.66

20991:Augusta, Ada B CPSC 3.83

21144:Pasteur, Louise A BIOL 3.1

22277:Principal, Pamela P EDUC 1.75

22447:Zylstra, Zelda A ENGL 1.95

23314:Macdonald, Ronald B CPSC 2.99

23497:Fault, Paige D CPSC 2.95

23544:Gestalt, Gloria G PSYC 2.48

23750:Vespucci, Vera D GEOG 2.29

24237:Euler, Lennie L MATH 3.83

25377:Porgy, Bess N MUSI 2.78

25831:Santamaria, Nina P HIST 1.77

26316:Custer, General G HIST 1.95

27503:Fahrenheit, Felicia O CHEM 3.85

28658:Cicero, Marsha LATI 2.87

29583:Yewliss, Cal C MATH 2.99

30268:Newmann, Alfred E EDUC 0.99

30280:Dewey, Johanna A EDUC 3.83

30381:Elba, Able M SPEE 3.4

30655:Angelo, Mike L ART 3.74

30749:Mendelssohn, Mozart W MUSC 2.87

30878:Lewis, Clark N GEOG 3.37

31631:Aristotle, Alice A PHIL 3.1

32598:Xerxes, Art I GREE 3.25

32631:Freud, JR, Fred E PSYC 1.85

**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: a
Search for a student in the list:
Please enter: ID number: 29583

29583:Yewliss, Cal C MATH 2.99
**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: b
delete a student in the list:
Please enter: ID number: 30749

30749:Mendelssohn, Mozart W MUSC 2.87
has been deleted
**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: c
counting number of students:
60
**************************************************
A. search for a student in the list
B. delete a student from the list
C. count the number of students in the list
D. display the list
E. quit
Please enter a choice: e
quiting

C:\Users\ninja\source\repos\studentlist\Debug\studentlist.exe (process 43136) exited with code 0.
Press any key to close this window . . .
*/