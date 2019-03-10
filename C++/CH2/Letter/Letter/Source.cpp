#include <iostream>
#include <string>
#include <regex>
using namespace std;

int main() {
	char letter;
	string isWhat;

	cout << "Please enter a letter: ";
	cin >> letter;
	cout << endl;

	if (regex_match(string(1, letter), regex("[abcdefghijklmnopqrstuvwxyz]")))
	{
		isWhat = (regex_match(string(1, letter), regex("[aeiou]"))) ? "vowel" : "consonant";
	}
	else
	{
		isWhat = "non-letter";
	}

	cout << letter << " is a " << isWhat << endl;

	return 0;
}