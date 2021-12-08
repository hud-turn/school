#include <iostream>
using namespace std;

int main()
{
	int rows = 10;

	for (int i = 1; i <= rows; ++i)
	{
		for (int j = 1; j <= i; ++j)
		{
			cout << "+ ";
		}
		cout << "\n";
	}
	cout << "\n";
	for (int i = rows; i >= 1; --i)
	{
		for (int j = 1; j <= i; ++j)
		{
			cout << "+ ";
		}
		cout << endl;
	}
	return 0;
}



#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main() {
	srand(time(NULL));
	int number = rand() % 99 + 2; // System number is stored in here.
	int guess; // User guess is stored in here.
	int tries = 0; // Number of tries is stored here.
	char answer;
	while (true) { // Get user number loop.
		// Get number.

		cout << "Enter a number between 1 and 100: ";
		cin >> guess;
		cin.ignore();

		// Check number.
		if (guess > number) {
			cout << "Too high! Try again.\n";
		}
		else if (guess < number) {
			cout << "Too low! Try again.\n";
		}
		else {
			break;

		}
		tries++;
	}

	// Safely exit.
	cout << "You Won! It took you " << tries << " tries";
	cout << "\n\nEnter anything to exit. . . ";
	cin.ignore();
	return 0;
}


