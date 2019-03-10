#include <iostream>
#include <algorithm>
#include <string>
using namespace std;

int main() {
	string strArray[3];

	cout << "Please enter the first string: ";
	cin >> strArray[0];
	cout << "Please enter the second string: ";
	cin >> strArray[1];
	cout << "Please enter the third string: ";
	cin >> strArray[2];
	cout << endl << endl;

	cout << "The max string is " << *max_element(strArray, strArray + 3) << endl;

	return 0;
}