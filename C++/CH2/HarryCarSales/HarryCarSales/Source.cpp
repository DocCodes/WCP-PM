#include <iostream>
#include <regex>
#include <string>
#include <iomanip>
using namespace std;

bool isValidDecimal(string num) {
	regex re = regex("^[+-]?(\\d*)(\\.?)(\\d*)$");
	if (regex_match(num, re))
	{
		return true;
	}
	else
	{
		return false;
	}
}

double getCommission(double sales) {
	if (sales >= 50000)
	{
		return 0.09;
	}
	else if (sales >= 40000) {
		return 0.07;
	}
	else if (sales >= 30000) {
		return 0.06;
	}
	else if (sales >= 20000) {
		return 0.05;
	}
	else if (sales >= 0) {
		return 0.04;
	}
	return 0;
}

int main() {
	string inputSales;
	double sales;
	double commission;

	cout << "Please enter your monthly sales: ";
	cin >> inputSales;

	if (!isValidDecimal(inputSales))
	{
		cout << endl << "Invalid commission entered.";
	}
	else
	{
		sales = stod(inputSales);
		commission = getCommission(sales);
		cout << endl << "Commission Rate: %" << fixed << setprecision(2) << commission * 100 << endl;
		cout << "Commission Pay:  $" << fixed << setprecision(2) << sales * commission;
	}

	cout << endl;
	return 0;
}