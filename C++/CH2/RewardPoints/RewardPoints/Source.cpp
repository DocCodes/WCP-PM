#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

enum Membership { standard, pluss, premium };

Membership getMembership(string inp) {
	if (regex_match(inp, regex("^(Standard)|(s)$", regex_constants::icase)))
	{
		return standard;
	}
	if (regex_match(inp, regex("^(Plus)|(\\+)$", regex_constants::icase)))
	{
		return pluss;
	}
	return premium;
}

bool isValidDouble(string test) {
	if (regex_match(test, regex("^[\\+\\-]?(\\d*)(\\.?)(\\d*)$")))
	{
		return true;
	}
	return false;
}

int main() {
	string inpMembership;
	string inpTotal;
	Membership member;
	double total;
	double rate;
	double points;
	regex rgx = regex("^(Standard)|(Premium)|(Plus)|(s)|(\\+)|(p)$", regex_constants::icase);
	smatch rgxMatches;


	cout << "Please enter your membership type" << endl << "Valid values are: Standard (S) Plus (+) and Premium (P)" << endl;
	cin >> inpMembership;
	cout << "Please enter your total spent" << endl;
	cin >> inpTotal;
	cout << endl;

	if (!regex_search(inpMembership, rgxMatches, rgx))
	{
		cout << "Invalid membership type entered." << endl;
		return 1;
	}
	if (!isValidDouble(inpTotal))
	{
		cout << "Invalid total spent entered." << endl;
		return 1;
	}

	member = getMembership(inpMembership);
	total = stod(inpTotal);

	switch (member)
	{
	case standard:
		if (total < 75)
		{
			rate = 0.05;
		}
		else if (total < 150)
		{
			rate = 0.75;
		}
		else
		{
			rate = 0.10;
		}
		break;
	case pluss:
		if (total < 150)
		{
			rate = 0.06;
		}
		else
		{
			rate = 0.13;
		}
		break;
	case premium:
		if (total < 200)
		{
			rate = 0.04;
		}
		else
		{
			rate = 0.15;
		}
		break;
	}

	cout << "Membership Type: " << (member == standard ? "Standard" : member == pluss ? "Plus" : "Premium") << endl;
	cout << "Total Spent: $" << fixed << setprecision(2) << total << endl;
	cout << "Reward Rate: %" << fixed << setprecision(0) << rate * 100 << endl;
	cout << "Reward Points: $" << fixed << setprecision(2) << total * rate << endl;

	cout << endl;
	return 0;
}