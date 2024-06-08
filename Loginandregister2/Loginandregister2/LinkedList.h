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
//						2. Student.h
//						3. studentlist.cpp
//
//*******************************************************************************************************

#ifndef LINKEDLIST_H
#define LINKEDLIST_H
#include "Node.h"
#include <iostream>
#include <new>
using namespace std;

//*******************************************************************************************************

template <typename T>
class LinkedList
{
	private: 
		Node<T>* front;
	public:

		LinkedList();
		~LinkedList();
		bool insert(const T&);
		bool display() const;
		bool del(T&);
		bool deleteFront(T&);
		bool deleteBack(T&);
		bool find(T&) const;
		bool viewFront(T&) const;
		bool viewBack(T&) const;
		bool isEmpty() const;
		bool isFull() const;
		bool getSize(int&) const;
		bool counting(const T&, int&) const;
		bool deleteAllBut(T&);
		bool clearlist();

};

//*******************************************************************************************************

template <typename T>
LinkedList<T>::LinkedList()
{
	front = nullptr;
}

//*******************************************************************************************************

template <typename T>
LinkedList<T>::~LinkedList()
{
	Node<T>*pTemp = nullptr;

	while (front!=nullptr)
	{
		pTemp = front;
		front = front->next;
		delete pTemp;
	}
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::insert(const T& dataIn)
{
	bool success = false;

	Node<T>* pPreve = nullptr,
		   * pAfter = front;

	while (pAfter!=nullptr&&pAfter->data<dataIn)
	{
		pPreve = pAfter;
		pAfter = pAfter->next;
	}

	Node<T>* pNew = new Node<T>(dataIn, pAfter);
	
	if (pNew!=nullptr)
	{
		if (pPreve!=nullptr)
		{
			pPreve->next = pNew;
		}
		else
		{
			front = pNew;
		}

		success = true;
	}

	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::display() const
{
	bool success = false;
	Node<T>* pTemp = front;
	while (pTemp != nullptr)
	{
		cout << pTemp->data << endl;
		pTemp = pTemp->next;
		success = true;
	}
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::del(T& data)
{
	bool success = false;
	Node<T> * pPrev = nullptr,
			* pTemp = front;

	while (pTemp!=nullptr&&pTemp->data<data)
	{
		pPrev = pTemp;
		pTemp = pTemp->next;
	}
	if (pTemp!=nullptr&&pTemp->data==data)
	{
		if (pPrev!=nullptr)
		{
			pPrev->next = pTemp->next;
		}
		else
		{
			front = pTemp->next;
		}
		data = pTemp->data;
		delete pTemp;
		success = true;
	}
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::deleteFront(T& data)
{
	bool success = false;
	Node<T> * pTemp = front;
	
	if (front!=nullptr)
	{
		data = pTemp->data;
		front = front->next;
		delete pTemp;
		success = true;
	}
	return success;

}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::deleteBack(T& data)
{
	bool success = false;
	Node<T> * pPrev = nullptr,
			* pTemp = front;

	while (pTemp != nullptr&&pTemp->next != nullptr)
	{
		pPrev = pTemp;
		pTemp = pTemp->next;
	}

	if (pTemp!=nullptr)
	{
		data = pTemp->data;
		delete pTemp;
		pPrev->next = nullptr;
		success = true;
	}

	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::find(T& dataOut) const
{
	bool success = false;
	Node<T>* pTemp = front;
	while (pTemp != nullptr)
	{
		if (pTemp->data == dataOut)
		{
			success = true;
		}
		pTemp = pTemp->next;
	}
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::viewFront(T& dataOut) const
{
	bool success = false;


	if (front!=nullptr)
	{
		dataOut = front->data;
		success = true;
	}
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::viewBack(T& dataOut) const
{
	bool success = false;

	Node<T> *pTemp = front;

	while (pTemp!=nullptr&&pTemp->next != nullptr)
	{
		pTemp = pTemp->next;
		
	}
	if (pTemp != nullptr&&pTemp->next != nullptr)
	{
		dataOut = pTemp->data;
		success = true;
	}
	
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::isEmpty() const
{
	bool success = false;

	if (front!=nullptr)
	{
		success = true;
	}

	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::isFull() const
{
	bool full = true;
	Node<T> * pNew = new(nothrow)Node<T>;

	if (pNew!=nullptr)
	{
		full = false;
		delete pNew;
	}
	return full;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::getSize(int& size) const
{
	bool success = false;
	size = 0;
	Node<T> * pTemp = front;

	while (pTemp!=nullptr)
	{
		size++;
		pTemp = pTemp->next;
		success = true;
	}
	
	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::counting(const T& data, int& count) const
{
	bool success = true;
	count = 0;
	Node<T> * pTemp = front;

	if (pTemp==nullptr)
	{
		success = false;
	}
	while (pTemp!=nullptr&&pTemp->data<=data)
	{	
		if (pTemp!=nullptr&&pTemp->data==data)
		{
			count++;
		}
		pTemp = pTemp->next;
	}

	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::deleteAllBut(T& data)
{
	bool success = false;
	Node<T> * pPrev = nullptr,
			* pTemp = front;

	while (pTemp!=nullptr&&pTemp->data<data)
	{
		pPrev = pTemp;
		pTemp = pTemp->next;
		front = pTemp;
		delete pPrev;
	}

	while (pTemp->data == data)
	{
		pPrev = pTemp;
		pTemp = pTemp->next;
		success = true;
	}

	while (pTemp!=nullptr)
	{
		pPrev->next = pTemp->next;
		delete pTemp;
		pTemp = pPrev->next;
	}

	return success;
}

//*******************************************************************************************************

template <typename T>
bool LinkedList<T>::clearlist()
{
	bool success = false;
	Node<T>*pTemp = nullptr;

	while (front != nullptr)
	{
		pTemp = front;
		front = front->next;
		delete pTemp;
	}

	if (front == nullptr)
	{
		success = true;
	}

	return success;
}
#endif