# include <iostream>
using namespace std;
int main()
{
	int x, y, i, result; // Declaring variables
	cout << "Enter the base x:" << endl;
	cin >> x; // Asking user for input.
	cout << "Enter the power y:" << endl;
	cin >> y; // Asking user for input.
	result = x; // Storing the value of x in result.
	for (i = 1; i < y; i++)
	{
		result *= x; // Multiplying x with x.	
	}
	cout << result;
	cout << endl;
	system("pause");
	return 0;
}
