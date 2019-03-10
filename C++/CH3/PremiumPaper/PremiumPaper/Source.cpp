#include <iostream>
#include <iomanip>
#include <string>
#include <regex>
using namespace std;

int main() {
	int total = 0;
	string inputMode = "Stipend";
	string inp;
	regex re = regex("^([eEqQsS]|\\d*)$");

	cout << "    Accounting WizBang!!!!! Premium Paper" << endl;
	cout << "[Q] Quit   [S] Stipend Mode   [E] Expense Mode" << endl << endl;

	while (true)
	{
		cout << inputMode << "> ";
		getline(cin, inp);
		if (!regex_match(inp, re))
		{
			cout << "Invalid input" << endl;
			continue;
		}

		if (inp == "q" || inp == "Q") { break; }
		if (inp == "s" || inp == "S") { inputMode = "Stipend"; continue; }
		if (inp == "e" || inp == "E") { inputMode = "Expense"; continue; }

		if (inputMode == "Stipend")
		{
			total += stoi(inp);
		}
		else
		{
			total -= stoi(inp);
		}
	}
	cout << endl;

	cout << "Your Net is $" << fixed << setprecision(2) << total << endl;

	system("pause");
	return 0;
}