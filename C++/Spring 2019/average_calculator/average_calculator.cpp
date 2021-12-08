/*2/3/2019*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int MonthTotal = 3;

	string monthone, monthtwo, monthree;

	float rmonthone, rmonthtwo, rmonthree, sum, average;


	cout << "Enter the name for the first month: ";
	cin >> monthone;
	cout << "How many inches of rain fell for " << monthone;
	cout << ": ";
	cin >> rmonthone;

	cout << "Enter the name for the second month: ";
	cin >> monthtwo;
	cout << "How many inches of rain fell for " << monthtwo;
	cout << ": ";
	cin >> rmonthtwo;

	cout << "Enter the name for the third month: ";
	cin >> monthree;
	cout << "How many inches of rain fell for " << monthree;
	cout << ": ";
	cin >> rmonthree;

	sum = rmonthone + rmonthtwo + rmonthree;
	average = sum / MonthTotal;

	cout << setprecision(2) << fixed;
	cout << "\nThe average rainfall for ";
	cout << monthone << ", ";
	cout << monthtwo << ", and ";
	cout << monthree << " is ";
	cout << average << " inches.\n" << endl;

	return 0;
}
