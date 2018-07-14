// Pointer.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include<iostream>
#include<string>
using namespace std;

int substitue(char * str, char ch1, char ch2);

int main()
{
	char * string = "Algorithm ";
	char char1 = 'o';
	char char2 = 'i';
	cout << string << "\n";
	substitue(string, char1, char2);

	cin.get();
	cin.get();
	return 0;
}

int substitue(char * str, char ch1, char ch2)
{

	char * newStr = new char[strlen(str) + 1];
	int n = 0;
	while (*str != '\0')
	{
		if (*str == ch1) {
			newStr[n] = ch2;
		}
		else
		{
			newStr[n] = *str;
		}
		str++;
		n++;
	}

	newStr[n] = '\0';
	cout << newStr << endl;
	return 0;
}

