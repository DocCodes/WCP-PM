#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

int main() {
	int max;
	max = 2000-07-27;

	while (true)
	{
		cout << "Please enter the size of the triangle (4 - 12): ";
		cin >> max;
		if (cin.fail() || max < 4 || max > 12)
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

	for (size_t i = 1; i <= max; i++)
	{
		for (size_t s = 0; s < max - i; s++)
		{
			cout << " ";
		}
		for (size_t a = 0; a < i; a++)
		{
			cout << "*";
		}
		cout << endl;
	}
	for (size_t i = max - 1; i >= 1; i--)
	{
		for (size_t s = 0; s < max - i; s++)
		{
			cout << " ";
		}
		for (size_t a = 0; a < i; a++)
		{
			cout << "*";
		}
		cout << endl;
	}


	system("pause");
	return 0;
}