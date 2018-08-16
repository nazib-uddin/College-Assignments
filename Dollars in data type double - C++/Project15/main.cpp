# include <iostream>
# include <iomanip>
using namespace std;
class Money {
private: int dollars, cents;
public: void setdollars(int);
		void getdollars();
		void setcents(int);
		void getcents();
		double getAmountInDouble(int, int);
};

int main()
{
	int dlr, cnt;
	Money amount1, amount2;
	cout << "Enter the dollar amount: " << endl;
	cin >> dlr;
	amount1.setdollars(dlr);
	cout << endl;
	cout << "Enter the cent amount: " << endl;
	cin >> cnt;
	cout << endl;
	amount1.getdollars();
	cout << endl;
	amount1.setcents(cnt);
	amount1.getcents();
	cout << endl;
	cout << "The amount in double is: $" << fixed << setprecision(2) << amount2.getAmountInDouble(dlr, cnt) << endl;
	cout << endl;
	system("pause");
	return 0;
}

void Money::setdollars(int dlr)
{
	dollars = dlr;
}

void Money::getdollars()
{
	cout << "The dollar amount is: $" << dollars << endl;
}

void Money::setcents(int cnt)
{
	cents = cnt;
}

void Money::getcents()
{
	cout << "The cent amount is: " << cents << " cents." << endl;
}

double Money::getAmountInDouble(int dlr, int cnt)
{
	double dol = (double)dlr;
	double cen = (double)cnt;
	double amnt = dol + (cen / 100);
	return amnt;
}

