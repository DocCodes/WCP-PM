#include <iostream>
using namespace std;

int main() {
	int year;
	bool isLeap;

	cout << "Please enter a year: ";
	cin >> year;

	isLeap = ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0)) ? true : false;
	cout << endl << year << (isLeap ? " is" : " isn't") << " a leap year." << endl;

	return 0;
}