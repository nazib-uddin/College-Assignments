# include <iostream>
# include <string>
using namespace std;
class FLIGHTDETAILS // Defining Class FLIGHTDETAILS with type int, float, string variables and void function.
{
private: int FLIGHTNO; // Declaring type int private variable to store flight number.
		 float DISTANCE, FUEL; // Declaring type float private variables to store distance and fuel.
		 string DESTINATION; // Declaring type string private variable to store destination name.
		 void CALFUEL(float); // Declaring private void function to calculate fuel for the flight.
public: void FEEDINFO(int, string, float); // Declaring public void function to access private member variables.
		void SHOWINFO(); // Declaring public void function to display private member variables.
};
int main()
{
	int flight; // Declaring type int variable to store flight number.
	float distance; // Declaring type float variable to store distance.
	string destination; // Declaring type string variable to store destination name.
	FLIGHTDETAILS passenger; // Declaring an object of class FLIGHTDETAILS.
	cout << "Enter the Flight number: " << endl; // Asking user for input.
	cin >> flight; // Storing input in local variable.
	cout << "Enter the Destination name: " << endl; // Asking user for input.
	cin >> destination; // Storing input in local variable.
	cout << "Enter the distance: " << endl; // Asking user for input.
	cin >> distance; // Storing input in local variable.
	passenger.FEEDINFO(flight, destination, distance); // Calling a public member function which accesses private member variables and stores input.
	passenger.SHOWINFO(); // Calling a public member function which gets private member variables and displaying them.
	system("pause");
	return 0;
}
void FLIGHTDETAILS::CALFUEL(float) // Defining private void function of class FILGHTDETAILS.
{
	if (DISTANCE <= 1000) // If distance is less than or equal to 1000,
	{
		FUEL = 500; // Fuel needed is 500.
	}
	else if (DISTANCE > 1000 && DISTANCE <= 2000) // If distance is greater than 1000 and less than 2000
	{
		FUEL = 1100; // Fuel needed is 500.
	}
	else if (DISTANCE > 2000) // If distance is greater than 2000
	{
		FUEL = 2200; // Fuel needed is 2200.
	}
}
void FLIGHTDETAILS::FEEDINFO(int flight, string destination, float distance) // Defining public void function of class FILGHTDETAILS.
{
	FLIGHTNO = flight; // Storing input in private member variable.
	DESTINATION = destination; // Storing input in private member variable.
	DISTANCE = distance; // Storing input in private member variable.
	CALFUEL(DISTANCE); // Calling a private member function to calculate fuel.
}
void FLIGHTDETAILS::SHOWINFO() // Defining public void function of class FILGHTDETAILS.
{
	cout << "The flight number is: " << FLIGHTNO << endl; // Displaying the private member flight number.
	cout << "The Destination name is: " << DESTINATION << endl; // Displaying the private member destination.
	cout << "The distance is: " << DISTANCE << endl; // Displaying the private member distance.
	cout << "The fuel needed is: " << FUEL << endl; // Displaying the private member fuel.
}
