# include <iostream>
using namespace std;
int main()
{
	int num1, num2, num3, rem;
	cout << "Enter a number to test: " << endl;
	cin >> num1;
	num3 = num1;
	rem = 0;
	while (num1>0)
	{
		num2 = num1 % 10;
		rem = rem * 10 + num2;
		num1 = num1 / 10;
	}
	if (rem = num3)
		cout << "It is a palindrome." << endl;
	else
		cout << "It is not a palindrome." << endl;
	system("pause");
	return 0;
}
