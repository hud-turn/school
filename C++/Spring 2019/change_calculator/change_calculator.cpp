// 1/17/2019
//Change Calculator
# include <iostream>
# include <iomanip>
using namespace std;

int main()
{
	float pennyval, nickelval, dimeval, quarterval, total;

	int pennies, nickels, dimes, quarters;

	cout << "This is the change counting game.\n \n Enter the amount of coins needed to make one dollar\n";
	cout << "Enter the number of pennies: ";
	cin >> pennies;
	cout << "Enter the number of nickels: ";
	cin >> nickels;
	cout << "Enter the number of dimes: ";
	cin >> dimes;
	cout << "Enter the number of quarters: ";
	cin >> quarters;
	pennyval = 0.01 * pennies;
	nickelval = 0.05 * nickels;
	dimeval = 0.1 * dimes;
	quarterval = 0.25 * quarters;
	total = pennyval + nickelval + dimeval + quarterval;

	if (total = 1.00)
	{
		cout << "You correctly made one dollar!";
	}
	else if (total > 1.00)
	{
		cout << "You did not make one dollar out of change correctly. You added too much change";
	}
	else if (total < 1.00)
	{
		cout << "You did not make one dollar out of change correctly. You did not add enough change";
	}

	return 0;
}
