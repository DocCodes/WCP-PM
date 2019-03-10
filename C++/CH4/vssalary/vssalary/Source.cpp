//  main.cpp
//  salary
//
//  Created by Evan Elias Young on 2019-01-18.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iomanip>
#include <iostream>
#include <limits>
#include <string>

using namespace std;

int main(int argc, char const *argv[]) {
  string temp;
  double salaryCodes[6] = { 25000.68, 35000.15, 55000.00, 70000.44, 80200.32, 90500.55 };
  int salaryCode;

  while (true) {
    cout << "Please enter a salary code for the salary (1-6): ";
    cin >> salaryCode;
    cin.clear();
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    if (salaryCode >= 1 && salaryCode <= 6) {
      break;
    }
    else {
      cout << "Invalid salary code, please try again." << endl;
    }
    cout << endl;
  }

  cout << "Salary Code: " << salaryCode << endl;
  cout << "Salary Pay : $" << fixed << setprecision(2) << salaryCodes[salaryCode - 1] << endl;

  cout << endl;
  cout << "Press enter to continue . . .";
  getline(cin, temp);

  return 0;
}
