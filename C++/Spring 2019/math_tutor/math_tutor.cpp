/*2/10/2019
Math Tutor*/
#include <iostream> 
#include <iomanip> 
#include <cstdlib> 
#include <cmath> 
#include <ctime> 
using namespace std;

int main()
{
	double A, B, C;
	unsigned seed = time(0);
	srand(seed);
	cout << "Math Tutor" << endl;
	A = 1 + rand() % 999;
	B = 1 + rand() % 999;
	C = A + B;
	cout << " ";
	cout << A << "\n+" << B << "\n-------" << endl;
	cout << "Press enter to see the awnser..... \n";
	cin.ignore();
	cout << A << "\n+" << B << "\n-------\n" << C << endl;
	return 0;
}
