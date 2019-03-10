#include <iostream>
using namespace std;

int main() {
	int paychecks = 24;
	float bonus = 100;
	float perPaycheck;
	float percent;
	float tot;

	cout << "Amount Per Paycheck: ";
	cin >> perPaycheck;
	cout << "Percent Saved Per Paycheck: ";
	cin >> percent;
	cout << endl;

	percent /= 100;
	tot = paychecks * perPaycheck * percent;
	tot += bonus;

	cout << "Amount Deposited Last Year" << endl;
	cout << "$" << tot << endl << endl;

	return 0;
}