#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {
	int x;
	int y;
	int prod = 0;

	while (true)
	{
		cout << "Please enter the first number: ";
		cin >> x;
		if (cin.fail() || x < 0)
		{
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << "Invalid number entered" << endl << endl;
			continue;
		}
		else
		{
			break;
		}
	}
	cout << endl;
	while (true)
	{
		cout << "Please enter the second number: ";
		cin >> y;
		if (cin.fail() || y < 0)
		{
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << "Invalid number entered" << endl << endl;
			continue;
		}
		else
		{
			break;
		}
	}
	cout << endl;

	while (y--) { prod += x; }

	cout << endl << endl;

	system("pause");
	return 0;
}