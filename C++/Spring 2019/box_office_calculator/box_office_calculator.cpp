/*2/10/2019
Box office price calculator*/
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	string moviename;

	double adulttic, adultsumtic, childtic, childsumtic, sumtic, grossbox, netbox, distributor;

	cout << setprecision(2) << fixed << showpoint;

	cout << "What is the name of the movie?: ";
	cin >> moviename;

	cout << "\nHow many adults purchased tickets?: ";
	cin >> adulttic;

	cout << "\nHow many children purchased tickets?: ";
	cin >> childtic;

	adultsumtic = adulttic * 10.00;
	childsumtic = childtic * 6.00;
	grossbox = adultsumtic + childsumtic;

	cout << "\nGross Box office profit was : ";
	cout << grossbox;

	cout << "\nThe Net Box office profit was: ";
	cout << grossbox * 0.20;

	cout << "\nThe distributor of the movie was given: ";
	cout << grossbox * 0.80;
	return 0;
}
