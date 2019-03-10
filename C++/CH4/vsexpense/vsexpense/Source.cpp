//  main.cpp
//  expense
//
//  Created by Evan Young on 2019-01-18.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <iomanip>
#include <limits>
#include <string>

using namespace std;

int main(int argc, char const *argv[]) {
  double temp;
  double expenses[12][15];
  double expenseTotals[15] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
  string monthNames[12] = {
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
  };
  string expenseNames[15] = {
    "Rent         ",
    "Food         ",
    "Gas          ",
    "Internet     ",
    "Water        ",
    "Power        ",
    "Phone        ",
    "Insurance    ",
    "Gas          ",
    "Travel       ",
    "Tax          ",
    "Medical      ",
    "Entertainment",
    "Music        ",
    "Other        "
  };

  cout << "Please input decimal numbers for each of the expenses." << endl << endl;

  for (size_t m = 0; m < 12; m++) {
    cout << endl << monthNames[m] << endl;

    for (size_t e = 0; e < 15; e++) {
      cout << expenseNames[e] << " : ";

      cin >> temp;
      cin.ignore(numeric_limits<int>::max(), '\n');
      cin.clear();

      expenseTotals[e] += temp;
    }

    cout << endl;
  }

  system("pause");
  return 0;
}
