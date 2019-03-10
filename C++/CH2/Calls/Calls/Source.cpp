#include <iostream>
#include <iomanip>
using namespace std;

int main() {
	int calls;
	double total = 200;

	cout << "Enter the number of calls you have made: ";
	cin >> calls;

	if (calls > 200) {
		total += (calls % 200) * 0.50;
		calls -= calls % 200;
	}
	if (calls > 150)
	{
		total += (calls % 150) * 0.60;
		calls -= calls % 150;
	}
	if (calls > 100)
	{
		total += (calls % 100) * 0.70;
		calls -= calls % 100;
	}

	cout << endl << endl << "Total Bill: $" << fixed << setprecision(2) << total << endl;

	return 0;
}