// 1/17/2019
//Book Return Points
# include <iostream>
# include <iomanip>
using namespace std;

int main()
{
	int boughtbooks;
	double points;

	cout << "How many books were bought?: ";
	cin >> boughtbooks;

	if (boughtbooks <= 0)
	{
		cout << "That is an invalid number of books.\n";
		points = 0;
	}
	else if (boughtbooks >= 0)
	{
		if (boughtbooks == 0)
		{
			points = 0;
		}

		if (boughtbooks == 1)
		{
			points = 5;
		}

		else if (boughtbooks == 2)
		{
			points = 15;
		}

		else if (boughtbooks == 3)
		{
			points = 30;
		}

		else if (boughtbooks >= 4)
		{
			points = 60;
		}

	}
	cout << "You earned ";
	cout << points;
	cout << " points" << endl;


	return 0;
}
