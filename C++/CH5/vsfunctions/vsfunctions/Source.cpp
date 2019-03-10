//  main.cpp
//  functions
//
//  Created by Evan Elias Young on 2019-01-23.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>

int max(int, int);
void max2(int&, int);

int main(int argc, char const *argv[]) {
  int num1, num2, maxNum;

  std::cout << "Enter Number 1: ";
  std::cin >> num1;
  std::cout << "Enter Number 2: ";
  std::cin >> num2;

  maxNum = max(num1, num2);
  std::cout << "Max Number: " << maxNum << std::endl;
  max2(num1, num2);
  std::cout << "Num1 Value: " << num1 << std::endl;

  std::system("pause");
  return 0;
}

int max(int num1, int num2) {
  if (num1 > num2) {
    return num1;
  }
  return num2;
}

void max2(int& num1, int num2) {
  if (num2 > num1) {
    num1 = num2;
  }
}
