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
//						3. studentlist.cpp
//
//*******************************************************************************************************

#ifndef STUDENT_H
#define STUDENT_H
#include "LinkedList.h"
#include <iostream>
#include <cstring>
using namespace std;

class Student
{

private:
	int id;
	char name[50];
	char citystate[50];
	char phone[12];
	char gender;
	int year;
	int credits;
	float gpa;
	char major[6];
public:
    Student();
	Student(const Student &);
	friend istream& operator>>(istream&, Student&);
	friend ostream& operator<<(ostream&, Student&);
	Student& operator=(const Student&);
	bool operator<(const Student&) const;
	bool operator==(const Student&) const;
	bool operator!=(const Student&) const;
	bool operator<=(const Student&) const;
	bool operator>(const Student&) const;
	bool operator>=(const Student&) const;
	bool setId(const int);
	int getId(int) const;
};

//*******************************************************************************************************

Student::Student()
{
	
}

//*******************************************************************************************************

Student::Student(const Student & data)
{
	this->id = data.id;
	strcpy_s(this->name, 50, data.name);
	strcpy_s(this->citystate, 50, data.citystate);
	strcpy_s(this->phone, 12, data.phone);
	this->gender = data.gender;
	this->year = data.year;
	this->credits = data.credits;
	this->gpa = data.gpa;
	strcpy_s(this->major, 6, data.major);
}

//*******************************************************************************************************

istream& operator>>(istream& in, Student& data)
{

	in >> data.id;
	in.ignore();
	in.getline(data.name, 50, '\n');
	in.getline(data.citystate, 50, '\n');
	in >> data.phone;
	in >> data.gender;
	in >> data.year;
	in >> data.credits;
	in >> data.gpa;
	in >> data.major;

	return in;
}

//*******************************************************************************************************

ostream& operator<<(ostream& out, Student& data)
{
	out << data.id << ":" << data.name << " " << data.major << " " << data.gpa << endl;
	return out;
}

//*******************************************************************************************************

Student& Student::operator=(const Student& right)
{
	if (this!=&right)
	{
		this->id = right.id;
		strcpy_s(this->name, 50, right.name);
		strcpy_s(this->citystate, 50, right.citystate);
		strcpy_s(this->phone, 12, right.phone);
		this->gender = right.gender;
		this->year = right.year;
		this->credits = right.credits;
		this->gpa = right.gpa;
		strcpy_s(this->major, 6, right.major);
	}
	
	return *this;
}

//*******************************************************************************************************

bool Student::operator<(const Student& right) const
{
	bool status = false;

	if (this->id<right.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::operator==(const Student& data) const
{
	bool status = false;

	if (this->id == data.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::operator!=(const Student& data) const
{
	bool status = false;

	if (this->id != data.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::operator<=(const Student& data) const
{
	bool status = false;

	if (this->id <= data.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::operator>(const Student& data) const
{
	bool status = false;

	if (this->id > data.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::operator>=(const Student& data) const
{
	bool status = false;

	if (this->id >= data.id)
	{
		status = true;
	}

	return status;
}

//*******************************************************************************************************

bool Student::setId(const int id)
{
	bool success = false;
	
	if (this->id!=id)
	{
		this->id = id;
		success = true;
	}

	return success;
}

//*******************************************************************************************************

int Student::getId(int id) const
{
	return id;
}
#endif