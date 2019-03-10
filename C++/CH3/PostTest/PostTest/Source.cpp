#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

double ctof(int c) {
	return (c * 9 / 5) + 32;
}

int main() {
	int c;
	int max;

	while (true)
	{
		cout << "Please enter the starting point for the temperature: ";
		cin >> c;
		if (cin.fail())
		{
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			continue;
		}
		else
		{
			break;
		}
	}
	max = c + 10;

	do
	{
		cout << c << " Celsius - " << ctof(c) << " Fahrenheit" << endl;
	} while (++c < max);

	return 0;
}