#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

bool isInteger(string test) {
	if (regex_match(test, regex("^\\d*$"))) {
		return true;
	}
	return false;
}

int main() {
	string inpNum1;
	int num1;
	string inpNum2;
	int num2;
	double result;
	string action;

	cout << "Enter the first number: ";
	cin >> inpNum1;
	cout << "Enter the second number: ";
	cin >> inpNum2;
	cout << "Enter the operation (a, s, m, d): ";
	cin >> action;

	if (!isInteger(inpNum1))
	{
		cout << "The first number is invalid." << endl;
		return 1;
	}
	if (!isInteger(inpNum2))
	{
		cout << "The second number is invalid." << endl;
		return 1;
	}
	if (!(action == "a" || action == "s" || action == "m" | action == "d"))
	{
		cout << "The oepration is invalid." << endl;
		return 1;
	}

	num1 = stoi(inpNum1);
	num2 = stoi(inpNum2);
	result = num1;

	if (action == "a")
	{
		result += num2;
	}
	else if (action == "s")
	{
		result -= num2;
	}
	else if (action == "m")
	{
		result *= num2;
	}
	else if (action == "d")
	{
		if (num2 == 0)
		{
			result = INFINITY;
		}
		else
		{
			result /= num2;
		}
	}

	cout << num1 << " " << (action == "a" ? "+" : action == "s" ? "-" : action == "m" ? "*" : "/") << " " << num2 << " = " << fixed << setprecision(2) << result << endl;

	return 0;
}
