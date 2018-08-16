# include <iostream>
# include <string> 
using namespace std;
struct grading // Defining structure grading with type string, integer and double variables.
{
	string name; // Declaring type string variable to store name.
	int courseNum; // Declaring type integer variable to store course number.
	double points, quiz, assignments, midterm, project, finals, grade; // Declaring type double variables to store decimal points if needed.	
};
int main()
{
	grading student[5]; // Declaring 5 students.
	for (int i = 0; i < 5; i++) // For loop to process 5 students.
	{
		double temp1 = 0.0, temp2 = 0.0; // Declaring type string variable to store name.
		cout << "Enter the student's name: " << endl; //Asking user for input.
		cin >> student[i].name; // Storing input in member variable name.
		cout << endl;
		cout << "Enter the student's course number: " << endl; //Asking user for input.
		cin >> student[i].courseNum; // Storing input in member variable coursenum.
		cout << endl;
		for (int j = 0; j < 2; j++) // For loop to process 2 quizzes.
		{
			cout << "Enter points earned in Quiz: " << endl; //Asking user for input.
			cin >> student[i].points; // Storing input in member variable points.
			while (student[i].points < 0 || student[i].points>10) // If condition to make sure quiz points are on a basis of 10 points.
			{
				cout << "You have entered invalid points." << endl;
				cout << "Points have to be within 0 to 10. " << endl; // Reminding user the limit of points 
				cout << "Enter points earned in Quiz: " << endl;
				cin >> student[i].points;
			}
			temp1 += student[i].points;
			student[i].quiz = temp1 / 100 * 10; // Averaging quiz scores to 10%.
		}
		cout << "The average score for quziz is: " << student[i].quiz << endl; // Displaying the average quiz score.
		cout << endl;
		for (int j = 0; j < 4; j++) // For loop to process 4 assignments.
		{
			cout << "Enter points earned in Assignment: " << endl; //Asking user for input.
			cin >> student[i].points; // Storing input in member variable points.
			while (student[i].points < 0 || student[i].points>50) // If condition to make sure assignment points are on a basis of 50 points.
			{
				cout << "You have entered invalid points." << endl;
				cout << "Points have to be within 0 to 50. " << endl; // Reminding user the limit of points 
				cout << "Enter points earned in Assignment: " << endl;
				cin >> student[i].points;
			}
			temp2 += student[i].points;
			student[i].assignments = temp2 / 100 * 20; // Averaging assignment scores to 20%.
		}
		cout << "The average score for assignments is: " << student[i].assignments << endl; // Displaying the average assignment score.
		cout << endl;
		cout << "Enter points earned in Midterm: " << endl; //Asking user for input.
		cin >> student[i].points; // Storing input in member variable points.
		while (student[i].points < 0 || student[i].points>100) // If condition to make sure midterm points are on a basis of 100 points.
		{
			cout << "You have entered invalid points." << endl;
			cout << "Points have to be within 0 to 100. " << endl; // Reminding user the limit of points 
			cout << "Enter points earned in Midterm: " << endl;
			cin >> student[i].points;
		}
		student[i].midterm = student[i].points / 100 * 25; // Averaging midterm score to 25%.
		cout << "The average score for midterm is: " << student[i].midterm << endl; // Displaying the average midterm score.
		cout << endl;
		cout << "Enter points earned in Project: " << endl; //Asking user for input.
		cin >> student[i].points; // Storing input in member variable points.
		while (student[i].points < 0 || student[i].points>100) // If condition to make sure project points are on a basis of 100 points.
		{
			cout << "You have entered invalid points." << endl;
			cout << "Points have to be within 0 to 100. " << endl; // Reminding user the limit of points 
			cout << "Enter points earned in Project: " << endl;
			cin >> student[i].points;
		}
		student[i].project = student[i].points / 100 * 15; // Averaging project score to 15%.
		cout << "The average score for project is: " << student[i].project << endl; // Displaying the average project score.
		cout << endl;
		cout << "Enter points earned in Final: " << endl; //Asking user for input.
		cin >> student[i].points; // Storing input in member variable points.
		while (student[i].points < 0 || student[i].points>100) // If condition to make sure final points are on a basis of 100 points.
		{
			cout << "You have entered invalid points." << endl;
			cout << "Points have to be within 0 to 100. " << endl; // Reminding user the limit of points 
			cout << "Enter points earned in Final: " << endl;
			cin >> student[i].points;
		}
		student[i].finals = student[i].points / 100 * 30; // Averaging finals score to 30%.
		cout << "The average score for final is: " << student[i].finals << endl; // Displaying the average final score.
		cout << endl;
		student[i].grade = student[i].quiz + student[i].assignments + student[i].midterm + student[i].project + student[i].finals;
		// Grade totals to sum of all the average scores.
		cout << "The average numeric score is: " << student[i].grade << endl; // Displaying grade in numeric value. 
		cout << endl;
		if (student[i].grade >= 90) // Grade greater than or equal 90 is A.
		{
			cout << "The final grade is A." << endl; // Diplaying grade in letter.
		}
		else if (student[i].grade > 80 && student[i].grade < 90) // Grade greater than 80 and less than 90 is B.
		{
			cout << "The final grade is B." << endl; // Diplaying grade in letter.
		}
		else if (student[i].grade > 70 && student[i].grade < 80) // Grade greater than 70 and less than 80 is C.
		{
			cout << "The final grade is C." << endl; // Diplaying grade in letter.
		}
		else if (student[i].grade > 60 && student[i].grade < 70) // Grade greater than 60 and less than 70 is D.
		{
			cout << "The final grade is D." << endl; // Diplaying grade in letter.
		}
		else if (student[i].grade < 60) // Grade less than 60 is F.
		{
			cout << "The final grade is F." << endl; // Diplaying grade in letter.
		}
		cout << endl;
	}
	system("Pause");
	return 0;
}
