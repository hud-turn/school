/*2/3/2019
*/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{


	float amountofcookies, sumbutter, sumsugar,	sumflour;


	cout << "How many cookies do you want to create? ";
	cin >> amountofcookies;
	sumsugar = 0.03125 * amountofcookies;
	sumbutter = 0.02083 * amountofcookies;
	sumflour = 0.05729 * amountofcookies;
	cout << "To make " << amountofcookies;
	cout << " cookies you are going to need: \n";
	cout << sumsugar;
	cout << "cups of sugar\n";
	cout << sumbutter;
	cout << "cups of butter\n";
	cout << sumflour;
	cout << "cups of flour\n";

	return 0;

}
