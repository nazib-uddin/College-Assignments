# include <iostream>
using namespace std;
int factorial(int x);
int main()
{
	int num1, num2, rem, num3 = 0;
	cout << "Enter a positive  integer: ";
	cin >> num1;
	num2 = num1;
	while (num2 != 0)
	{
		rem = num2 % 10;
		num3 += factorial(rem);
		num2 /= 10;
		
	}
	cout << num3 << endl;
	if (num3 == num1)
		{
			cout << "It is a Factorial." << endl;
		}
		else
		{
			cout << "It is is not a Factorial." << endl;
		}
	system("pause");
	return 0;
}

int factorial(int x)
{
	if (x == 1)
	{
		return 1;
	}
	else
	{
		return x*factorial(x - 1);
	}
}


