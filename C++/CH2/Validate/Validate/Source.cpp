#include <iostream>
#include <regex>
#include <string>
using namespace std;

int main() {
	string intTest;
	string decTest;

	cout << "Please enter an integer: ";
	cin >> intTest;
	
	if (regex_match(intTest, regex("^\\d*$"))) {
		cout << "That is a valid integer.";
	}
	else {
		cout << "That is an invalid integer.";
	}
	cout << endl;

	cout << "Please enter a decimal number: ";
	cin >> decTest;

	if (regex_match(decTest, regex("^[+-]?(\\d*)(\\.)?(\\d*)$"))) {
		cout << "That is a valid decimal number.";
	}
	else {
		cout << "That is an invalid decimal number.";
	}
	cout << endl;

	return 0;
}