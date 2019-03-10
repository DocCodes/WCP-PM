#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
using namespace std;

int main() {
	float diameter;
	float price;
	float rail;

	cout << "Enter the diameter: ";
	cin >> diameter;
	cout << "Enter the price of metal per foot: ";
	cin >> price;
	rail = diameter * M_PI;
	cout << endl;

	cout << "Railing Length: " << rail << "ft" << endl;
	cout << "Railing Cost: " << rail * price << endl << endl;

	return 0;
}