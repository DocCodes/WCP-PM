#include <iostream>
using namespace std;

int main() {
	int number1;
	int number2;

	cout << "Enter the first number: ";
	cin >> number1;
	cout << "Enter the second number: ";
	cin >> number2;
	cout << endl;
	cout << endl;

	if (number1 != number2)
	{
		number1 ^= number2;
		number2 ^= number1;
		number1 ^= number2;
	}

	cout << "First Number: " << number1 << endl;
	cout << "Second Number: " << number2 << endl;

	return 0;
}