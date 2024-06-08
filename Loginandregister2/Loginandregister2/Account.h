#ifndef ACCOUNT_H
#define ACCOUNT_H
#include <string>
#include <iostream>

class Account
{
	private:
		std::string username;
		std::string password;

	public:
		Account(const std::string& = "", const std::string& = "");
		Account(const Account&);
		friend std::ifstream& operator>>(std::ifstream&, Account&);
		friend ostream& operator<<(ostream&, const Account&);
		bool operator>(const Account& s) const;
		bool operator<(const Account& s) const;
		Account& operator=(const Account& s);
		void setUsername(std::string);
		void setPassword(std::string);
		std::string getUsername();
		std::string getPassword();
		bool operator!=(const Account& s) const;
		bool operator==(const Account&) const;
};

Account::Account(const std::string & userName, const std::string& password)
{
	this->password = password;
	this->username = userName;
}

Account::Account(const Account& a)
{
	this->password = a.password;
	this->username = a.username;
}

void Account::setUsername(std::string u)
{
	this->username = u;
}

void Account::setPassword(std::string p)
{
	this->password = p;
}

std::ifstream& operator>>(std::ifstream& in, Account& rhs)
{
	std::string username;
	std::string password;

	// Read username and password
	if (std::getline(in, username) && std::getline(in, password))
	{
		rhs.setUsername(username);
		rhs.setPassword(password);
	}
	else {
		// Handle error case, reset Account object
		rhs.setUsername("");
		rhs.setPassword("");
	}

	return in;
}

std::string Account::getUsername()
{
	return username;
}

std::string Account::getPassword()
{
	return password;
}

bool Account::operator>(const Account& s) const
{
	bool status = false;

	if (this->password.begin() > s.password.begin())
	{
		status = true;
	}

	return status;
}

std::ostream& operator<<(ostream& os, const Account& account)
{
	os << account.username << ' ' << account.password;
	return os;
}


Account& Account::operator=(const Account& s) {
	if (this != &s) {
		this->username = s.username;
		this->password = s.password;
	}
	return *this;
}

bool Account::operator!=(const Account& s) const
{
	bool status = false;

	if (this->username != this->username)
	{
		status = true;
	}

	return status;
}

bool Account::operator==(const Account& other) const {
	return (username == other.username && password == other.password);
}

bool Account::operator<(const Account& s) const
{
	bool status = false;

	if (this->password.begin() < s.password.begin())
	{
		status = true;
	}

	return status;
}
#endif