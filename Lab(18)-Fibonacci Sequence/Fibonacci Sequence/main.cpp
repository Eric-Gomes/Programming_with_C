#include <iostream>

using namespace std;

int main()
{
	int num1 = 0, num2 = 1, num_next = 1, n;

	cout << "enter a number: \n";
	cin >> n;
	//for when a negative value is given
	while (n < 0)
	{
		cout << "ERROR\n";
		cin >> n;
	}
	//when any positive number (above 1 is given)
	if (n > 0)
	{
		//to give the value of 0 without ruining the loop
		cout << num1 << " ";
		for (int i = 0; i < n; i++)
		{
			//the Fibonacci loop
			cout << num_next << " ";
			num_next = num1 + num2;
			num1 = num2;
			num2 = num_next;
		}
	}
	//for when 0 is the given value
	else if (n == 0)
		cout << n << " ";
	return 0;


}