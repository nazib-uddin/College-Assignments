# include <iostream>
using namespace std;
class BOOK // Declaring class BOOK with type int, char, float variables and void function.
{
private: int BOOKNO; // Declaring type int private variable to store book number.
		 char TITLE[20]; // Declaring type char private variable to store book title.
		 float PRICE; // Declaring type float private variable to store book price.
		 float TOTAL_COST(int); // Declaring private type float function to calculate the cost of copying book.
public: void INPUT(int, char TITLE[20], float); // Declaring public void function to access private member variables and display them.
		void PURCHASE();// Declaring public void function to access private member function TOTAL_COST() and display the result.
};
int main()
{
	int number; // Declaring type int local variable to store book number.
	char title[20]; // Declaring type char local variable to store book title.
	float price; // Declaring type float local variable to store book price.
	BOOK NO1; // Declaring an object of class BOOK.
	cout << "Enter the Book number: " << endl; // Asking user for input.
	cin >> number; // Storing book number in local variable.
	cout << "Enter the Book title: " << endl; // Asking user for input.
	cin >> title; // Storing book title in local variable.
	cout << "Enter the Price of the book: " << endl; // Asking user for input.
	cin >> price; // Storing book price in local variable.
	NO1.INPUT(number, title, price); // Calling public function to access private member variables to store input and display them.
	NO1.PURCHASE();// Calling public function to access a private member function and display the results.
	system("pause");
	return 0;
}
float BOOK::TOTAL_COST(int N) // Defining a private type float function of class BOOK. 
{
	return N * PRICE; // Returns the total cost of copying which is the product of number of copies and book price.
}
void BOOK::INPUT(int number, char title[20], float price) // Defining a public void function of class BOOK.
{
	BOOKNO = number; // Storing book number in private member variable BOOKNO.
	for (int i = 0; i < 20; i++) // For characters 0 to 20 keep on repeating. 
	{
		TITLE[i] = title[i]; // Storing each character of the book title in private member variable TITLE.
	}
	PRICE = price; // Storing book price in private member variable PRICE.
	cout << "The book number is " << BOOKNO << endl; // Displaying the private member variable BOOKNO.
	cout << "The book title is " << TITLE << endl; // Displaying the private member variable TITLE.
	cout << "The book price is $" << PRICE << endl; // Displaying the private member variable PRICE.
}
void BOOK::PURCHASE() // Defining a public void function of class BOOK.
{
	int N; // Declaring type int variable to store the number of copies.
	cout << "Enter the number of pages to be copied: " << endl; // Asking user for input.
	cin >> N; // Storing the number of copies in variable N.
	cout << "The total cost for copying is $" << TOTAL_COST(N) << endl; // Calling the private member function and displaying the total cost of copying.
}
