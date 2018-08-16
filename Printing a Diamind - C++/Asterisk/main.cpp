# include <iostream>
using namespace std; 
void diamond(int x, char y);
int main()
{
	int a;
	char b, option;
	const int c = 5;
	cout << "Do you want to use the default values? (Y/N): " << endl;
	cin >> option;
	if (option == 'Y'||option=='y')
	{
		b = '*';
		diamond(c, b);
	}
	else
	{
		cout << "Enter an integer for the side of the diamond: " << endl;
		cin >> a;
		cout << "Enter a char value for the character printed: " << endl;
		cin >> b;
		diamond(a, b);
	}

	system("pause");
	return 0;
}
void diamond(int x, char y)
{
	if (x == 5)
	{
		cout << endl;
		cout << "     ";
		for (int i = 0; i < 1; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "    ";
		for (int i = 0; i <x-2; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "   ";
		for (int i = 0; i <x; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "  ";
		for (int i = 0; i < x + 2; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << " ";
		for (int i = 0; i < x + 4; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "  ";
		for (int i = 0; i < x + 2; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "   ";
		for (int i = 0; i <x; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "    ";
		for (int i = 0; i <x - 2; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "     ";
		for (int i = 0; i <1; i++)
		{
			cout << y;
		}
		cout << endl;
	}
	else
	{
		cout << endl;
		cout << "  ";
		for (int i = 0; i < 1; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << " ";
		for (int i = 0; i < x; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "";
		for (int i = 0; i < x + 2; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << " ";
		for (int i = 0; i < x; i++)
		{
			cout << y;
		}
		cout << endl;
		cout << "  ";
		for (int i = 0; i < 1; i++)
		{
			cout << y;
		}
		cout << endl;
	}
}
