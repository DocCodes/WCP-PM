#include <iostream>
using namespace std;

float priceWithTax(float price, float tax) {
	return price * (1 + tax);
}

int main() {
	float subtotal;

	cout << "What is the cost before the tip: ";
	cin >> subtotal;
	cout << endl;

	cout << "Rate: 10%" << endl;
	cout << "Tip: " << subtotal * 0.10 << endl;
	cout << "Total: " << priceWithTax(subtotal, 0.10) << endl << endl;
	cout << "Rate: 15%" << endl;
	cout << "Tip: " << subtotal * 0.15 << endl;
	cout << "Total: " << priceWithTax(subtotal, 0.15) << endl << endl;
	cout << "Rate: 20%" << endl;
	cout << "Tip: " << subtotal * 0.20 << endl;
	cout << "Total: " << priceWithTax(subtotal, 0.20) << endl << endl;

	return 0;
}