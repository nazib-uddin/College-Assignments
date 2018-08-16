


# include <iostream>
using namespace std;
class Complex // Declaring Class
{
private: double real, imag; // Declaring private member variables
public: void getreal(); // Declaring accessor function
		void getimag();// Declaring accessor function
		void setreal();// Declaring mutator function
		void setimag();// Declaring mutator function
		Complex operator+ (Complex B) // Declaring and Defining operator overloading function
		{
			Complex C; // declaring a temporary object to store values
			C.real = real + B.real;
			C.imag = imag + B.imag;
			return C; // returning the values of the temporary object
		}
		Complex operator- (Complex B)
		{
			Complex C; // declaring a temporary object to store values
			C.real = real - B.real;
			C.imag = imag - B.imag;
			return C; // returning the values of the temporary object
		}

};
int main()
{
	Complex A, B, add, sub; // declaring objects of type class
	A.setreal(); // calling the mutator function
	A.setimag();// calling the mutator function
	cout << "The value of the first object is: ";
	A.getreal();// calling the accessor function
	cout << " + ";
	A.getimag();// calling the accessor function
	cout << endl << endl;
	B.setreal();// calling the mutator function
	B.setimag();// calling the mutator function
	cout << "The value of the second object is: ";
	B.getreal();// calling the accessor function
	cout << " + ";
	B.getimag();// calling the accessor function
	cout << endl << endl;
	add = A + B; // calling the operator overlaoding funtion
	cout << "Addition is: ";
	add.getreal();// calling the accessor function
	cout << " + ";// calling the accessor function
	add.getimag();
	cout << endl << endl;
	sub = A – B; // calling the operator overloading finction
	cout << "Subtraction is: ";
	sub.getreal();// calling the accessor function
	cout << " + ";
	sub.getimag();// calling the accessor function
	cout << endl << endl;

	system("pause");
	return 0;
}

void Complex::setreal() // defining the mutator function
{
	cout << "Enter the value of real: " << endl;
	cin >> real; // storing input in private member variable
}

void Complex::setimag()// defining the mutator function
{

		cout << "Enter the value of imaginary: " << endl;
		cin >> imag; // storing input in private member variable
	}
	void Complex::getreal()// defining the accessor function
	{

			cout << real; // displaying private member variable
		}

		void Complex::getimag()// defining the accessor function
		{

				cout << imag << "i"; // displaying private member variable

			}
