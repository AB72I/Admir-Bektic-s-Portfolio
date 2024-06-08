#include <iostream>
#include <fstream>
#include <string>
#include "Node.h"
#include "LinkedList.h"
#include "Account.h"
using namespace std;

void login(LinkedList<Account>);
Account newAccount(LinkedList<Account>);
bool checkLength(string);
bool checkUpperCase(string);
bool checkDigit(string);
bool checkSymbol(string);
bool checkWhiteSpace(string);

int main()
{
	int choice;
	Account newLogin;
	string accountInfo;
	LinkedList<Account> accountList;
	ifstream fin("accounts.txt");

	if (fin.fail()) {
		cout << "fail" << endl;
	}
	else {
		while (fin >> newLogin) {
			fin.ignore();
			accountList.insert(newLogin);
		}
		fin.close();
	}

	cout << "What do you want to do?" << endl;
	cout << "1. login" << endl;
	cout << "2. register" << endl;
	cin >> choice;

	switch (choice)
	{
	case 1:
		login(accountList);
		break;

	case 2:
		newLogin = newAccount(accountList);
		accountList.insert(newLogin);
		ofstream fout("accounts.txt", ios::out | ios::app);
		if (fout.is_open()) {
			fout << newLogin.getUsername() << '\n';
			fout << newLogin.getPassword() << '\n';
			fout.close();
		}
		else {
			cerr << "Unable to open file for writing." << endl;
		}
		break;
	}

	return 0;
}

void login(LinkedList<Account> list)
{
	string username,
		password;
	Account user;
	bool enter = false;

	do
	{
		cout << "Enter your Username" << endl;
		cin.ignore();
		cin >> username;

		cout << "Enter your Password" << endl;
		cin >> password;

		user.setUsername(username);
		user.setPassword(password);
		enter = list.find(user);

		if (enter)
		{
			cout << "login successful" << endl;
		}
		else
		{
			cout << "account not found" << endl;
		}

	} while (!enter);

}

Account newAccount(LinkedList<Account> list)
{
	Account newLogin;
	string username,
		password;
	bool all;

	cout << "create a username" << endl;
	cin.ignore();
	getline(cin, username);
	newLogin.setUsername(username);

	cout << "create a password" << endl;
	cout << "1. Must be at least 8 characters long\n";
	cout << "2. Must have a uppercase letter\n";
	cout << "3. Must have a number\n";
	cout << "4. Must have a symbol such as !,@, or #\n";
	cout << "5. Must not have a space\n";


	do
	{
		all = true;
		getline(cin, password);
		checkLength(password);
		if (checkUpperCase(password) == false)
		{
			cout << "!!!Error!!! input doesn't contain an uppercase letter" << endl;
			all = false;
		}
		if (checkDigit(password) == false)
		{
			cout << "!!!Error!!! input doesn't contain a digit" << endl;
			all = false;
		}
		if (checkSymbol(password) == false)
		{
			cout << "!!!Error!!! input doesn't contain at least one symbol" << endl;
			all = false;
		}
		if (checkWhiteSpace(password) == true)
		{
			cout << "!!!Error!!! input cannot contain at space" << endl;
			all = false;
		}
	} while (all == false);

	newLogin.setPassword(password);

	return newLogin;
}

bool checkLength(string password)
{
	bool length;
	int len = password.length();
	if (len < 8)
	{
		length = false;
		cout << "!!!Error!!! input is too short" << endl;
	}
	else
	{
		length = true;
	}

	return length;
}

bool checkUpperCase(string password)
{
	int len = password.length();
	bool upper = false;
	for (int i = 0; !upper && i < len; i++)
	{
		if (isupper(password[i]))
		{
			upper = true;
		}
	}
	return upper;
}

bool checkDigit(string password)
{
	int len = password.length();
	bool digit = false;
	for (int i = 0; !digit && i < len; i++)
	{
		if (isdigit(password[i]))
		{
			digit = true;
		}
	}
	return digit;
}

bool checkSymbol(string password)
{
	int len = password.length();
	bool symbol = false;
	for (int i = 0; !symbol && i < len; i++)
	{
		if (ispunct(password[i]))
		{
			symbol = true;
		}
	}
	return symbol;
}

bool checkWhiteSpace(string password)
{
	int len = password.length();
	bool space = false;
	for (int i = 0; !space && i < len; i++)
	{
		if (isspace(password[i]))
		{
			space = true;
		}
	}
	return space;
}