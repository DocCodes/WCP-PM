#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

bool isValidDouble(string test) {
	regex re = regex("[+-]?(\\d*)(\\.?)(\\d*)");
	if (regex_match(test, re)) {
		return true;
	}
	return false;
}

int main() {
	string testWeight;
	double weight;
	string sex;
	string activity;
	double calories;
	double rate = 10;

	cout << "Enter your sex (M/F): ";
	cin >> sex;
	cout << "Enter your activity (Active/Inactive): ";
	cin >> activity;
	cout << "Enter your weight: ";
	cin >> testWeight;
	cout << endl;

	if (!(sex == "M" || sex == "F"))
	{
		cout << "Invalid sex entered" << endl;
		return 1;
	}
	if (!(activity == "Active" || activity == "Inactive"))
	{
		cout << "Invalid activity entered" << endl;
		return 1;
	}
	if (!isValidDouble(testWeight))
	{
		cout << "Invalid weight entered" << endl;
		return 1;
	}
	weight = stod(testWeight);

	rate += sex == "M" ? 3 : 0;
	rate += activity == "Active" ? 2 : 0;
	calories = weight * rate;

	cout << "Sex: " << sex << endl;
	cout << "Activity: " << activity << endl;
	cout << "Weight: " << fixed << setprecision(2) << weight << endl;
	cout << "Recommended calories to maintain weight: " << fixed << setprecision(2) << calories << endl;

	return 0;
}