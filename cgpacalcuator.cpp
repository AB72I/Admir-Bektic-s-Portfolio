#include <iostream>
#include <iomanip>
using namespace std;

float calculateGPA();
float calculateCGPA(float[], int);

int main()
{
	int choice = 0,
		gradeCount = 0;
	float* gpa = nullptr;
	float cGPA = 0;

	while (choice != 3)
	{
		cout << "1. calcutate GPA" << endl;
		cout << "2. calcutate Cumulative GPA" << endl;
		cout << "3. Exit application" << endl;
		cout << "************************************************************" << endl;
		cout << endl << "enter your choice" << endl;
		cin >> choice;

		switch (choice)
		{
		case 1: 
			if (gpa == nullptr)
			{
				gpa = new float[1];
			}
			else
			{
				float* temp = new float[gradeCount + 1];
				for (int i = 0; i < gradeCount; ++i)
				{
					temp[i] = gpa[i];
				}
				delete[] gpa;
				gpa = temp;
			}
			gpa[gradeCount] = calculateGPA();
			gradeCount++;
			break;

		case 2: cGPA = calculateCGPA(gpa, gradeCount);
			cout << "The cGPA is " << cGPA;
		}
	}

	return 0;
}

float calculateGPA()
{
	int classNum = 0;
	float sum = 0,
		total,
		totalCred = 0;


	cout << "how many classes you want to calculate" << endl;
	cin >> classNum;

	float* credit = new float[classNum];
	float* grade = new float[classNum];

	cout << endl;
	for (int i = 0; i < classNum; i++)
	{
		cout << "enter the credits earned in class" << i + 1 << endl;
		cin >> credit[i];
		cout << endl << "enter the grade in class" << i + 1 << endl;
		cin >> grade[i];
		total = credit[i] * grade[i];
		sum = sum + total;
		totalCred = totalCred + credit[i];
	}

	float gPA = sum / totalCred;
	cout << "the GPA is " << fixed << setprecision(1) << gPA << endl;

	return gPA;
	delete[] credit;
	delete[] grade;
}

float calculateCGPA(float semesters[], int num)
{
	float totalScore = 0,
		  cGPA = 0;

	for (int i = 0; i < num; i++)
	{
		totalScore = totalScore + semesters[i];
	}

	cGPA = totalScore / num;

	return cGPA;
}