// 1/17/2019
//Software Sales calculator
# include <iostream>
# include <iomanip>
using namespace std;

int main()
{
	int liscencesneeded;
	double total, discount, liscencesprice = 99.00;

	cout << "How many licences were sold?:";
	cin >> liscencesneeded;

	if (liscencesneeded <= 0)
	{
		cout << "Please input a value greater than Zero\n";
	}

	if (liscencesneeded >= 10)
	{
		discount = .20;
	}

	else if (liscencesneeded >= 20)
	{
		discount = .30;
	}

	else if (liscencesneeded >= 50)
	{
		discount = .40;
	}

	else if (liscencesneeded >= 100)
	{
		discount = .50;
	}

	total = liscencesprice * liscencesneeded * discount;

	cout << "The total cost of this purchase is: ";
	cout << total << endl;

	return 0;
}
