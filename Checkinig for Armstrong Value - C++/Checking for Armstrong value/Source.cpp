# include <iostream>
using namespace std;
int main()
{
	int num1, num2, a, b, c, d; // Declaring integer variables
	cout << "Enter a number to check: " << endl;
	cin >> num1; // Asking user for input.
	while (num1 != 0) // Condition - As long as the number is not zero.
	{
		a = num1 % 10; // Getting the last digit integer.
		b = num1 / 10;
		c = b % 10; // Getting the second digit integer.
		d = b / 10; // Getting the first digit integer
		cout << a;
		cout << c;
		cout << d;
		cout << endl;
		num2 = (a*a*a) + (c*c*c) + (d*d*d); // Multiplying according the number of characters.
		if (num2 == num1)
		{
			cout << "It is an Armstrong value." << endl;
			break;
		}
		else
		{
			cout << "It is is not an Armstrong value." << endl;
			break;
		}
	}
	system("pause");
	return 0;
}
