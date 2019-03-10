#include <iostream>
#include <algorithm>
using namespace std;

int main() {
	int numArray[3];

	cout << "Please enter the first number: ";
	cin >> numArray[0];
	cout << "Please enter the second number: ";
	cin >> numArray[1];
	cout << "Please enter the third number: ";
	cin >> numArray[2];
	cout << endl << endl;

	cout << "The max number is " << *max_element(numArray, numArray + 3) << endl;

	return 0;
}