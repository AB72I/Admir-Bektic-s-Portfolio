//****************************************************************************************************
//
//			File:			hammingcode.cpp
//
//			Assignment:		Project 4
//
//			Due Date:		May 6, 2022
//
//			Author:			Admir Bektic
//
//			Course Name:	Computer Architecture
//
//			Course Number:	COSC 3510
//
//			discription:	this program will detect errors using hamming code
//****************************************************************************************************

#include<iostream>
using namespace std;

int flip(int &);
int redundant(int, int, int, int);
void dataBits(int[], int, int, int, int);

int main()
{
	char choice,
		next = 't';
	const int SIZE = 7;
	int bits[SIZE],
		parity,
		count = 0,
		G1,
		G2,
		G3,
		paritybits;

	while (next != 'n')
	{
		cout << "Pick the option you would like this program to perform?" << endl;
		cout << "A: Find the codeword" << endl;
		cout << "B: Find the data bits" << endl;

		cin >> choice;
		switch (choice)
		{
		case 'A':
			cout << "Please Enter 4-digit bit series separated by spaces" << endl;
			cin >> bits[0];
			cin >> bits[1];
			cin >> bits[2];
			cin >> bits[4];

			cout << "What is the type of parity?" << endl;
			cout << "0 = even" << endl;
			cout << "1 = odd" << endl;

			cin >> parity;

			if (parity == 0)
			{
				bits[6] = redundant(bits[0], bits[2], bits[4], 1);
				bits[5] = redundant(bits[0], bits[1], bits[4], 1);
				bits[3] = redundant(bits[0], bits[1], bits[2], 1);
			}
			else
			{
				bits[6] = redundant(bits[0], bits[2], bits[4], 0);
				bits[5] = redundant(bits[0], bits[1], bits[4], 0);
				bits[3] = redundant(bits[0], bits[1], bits[2], 0);
			}

			cout << "The codeword is" << endl;
			cout << "-------------------------------------------- " << endl;
			cout << "D7 D6 D5 R4 D3 R2 R1 " << endl;
			for (int i = 0; i < SIZE; i++)
			{
				cout << bits[i] << "  ";
			}
			break;

		case 'B':
			cout << "Please Enter 7-digit bit series separated by spaces " << endl;

			for (int i = 0; i < SIZE; i++)
			{
				cin >> bits[i];
			}

			G1 = bits[6] ^ bits[4] ^ bits[2] ^ bits[0];
			G2 = bits[5] ^ bits[4] ^ bits[1] ^ bits[0];
			G3 = bits[3] ^ bits[2] ^ bits[1] ^ bits[0];
			paritybits = G3 * 4 + G2 * 2 + G1;

			cout << "What is the type of parity ?" << endl;
			cout << "0 = even" << endl;
			cout << "1 = odd" << endl;
			cin >> parity;

			dataBits(bits, G1, G2, G3, parity);
			break;
		}

		cout << endl << "Do you want to run again(y / n) ?";
		cin >> next;
	}
	
}

int flip(int& bit)
{
	bit = (bit + 1) % 2;

	return bit;
}

int redundant(int bit1, int bit2, int bit3, int parity)
{
	int count = 0,
		redundant;

	if (bit1 == 1)
	{
		count++;
	}
	if (bit2 == 1)
	{
		count++;
	}
	if (bit3 == 1)
	{
		count++;
	}

	if (count % 2 == parity)
	{
		redundant = 1;
	}
	else
	{
		redundant = 0;
	}

	return redundant;
}

void dataBits(int bits[], int group1, int group2, int group3, int parity)
{
	int flipIndex = 1 * (group1 != parity) + 2 * (group2 != parity) + 4 * (group3 != parity);

	flip(bits[flipIndex]);

	cout << endl << "The original message is: " << bits[0] << bits[1] << bits[2] << bits[4];
}

/*Pick the option you would like this program to perform?
A: Find the codeword
B: Find the data bits
A
Please Enter 4-digit bit series separated by spaces
0 1 1 1
What is the type of parity?
0 = even
1 = odd
1
The codeword is
--------------------------------------------
D7 D6 D5 R4 D3 R2 R1
0  1  1  1  1  1  1
Do you want to run again(y / n) ?y
Pick the option you would like this program to perform?
A: Find the codeword
B: Find the data bits
B
Please Enter 7-digit bit series separated by spaces
0 1 1 0 1 0 1
What is the type of parity ?
0 = even
1 = odd
1

The original message is: 0111
Do you want to run again(y / n) ?y
Pick the option you would like this program to perform?
A: Find the codeword
B: Find the data bits
B
Please Enter 7-digit bit series separated by spaces
0 1 1 0 1 0 1
What is the type of parity ?
0 = even
1 = odd
0

The original message is: 0011
Do you want to run again(y / n) ?n

C:\Users\ninja\source\repos\paritybit\Debug\paritybit.exe (process 10612) exited with code 0.
Press any key to close this window . . .
*/