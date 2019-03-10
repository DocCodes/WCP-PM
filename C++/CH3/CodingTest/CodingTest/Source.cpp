//  Source.cpp
//  CodingTest
//
//  Created by Evan Elias Young on 2019-01-17.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <string>
#include <regex>
#include <algorithm>
#include <cctype>

bool validateSection(std::string sect, unsigned char size) {
  return std::regex_match(sect, std::regex("^[A-PR-Y\\d]{" + std::to_string(size) + "}$", std::regex_constants::icase));
}

void upper(std::string* s) {
  std::transform((*s).begin(), (*s).end(), (*s).begin(), std::toupper);
}

std::string anton(std::string number) {
  number = std::regex_replace(number, std::regex("[A-C]"), "2");
  number = std::regex_replace(number, std::regex("[D-F]"), "3");
  number = std::regex_replace(number, std::regex("[G-I]"), "4");
  number = std::regex_replace(number, std::regex("[J-L]"), "5");
  number = std::regex_replace(number, std::regex("[M-O]"), "6");
  number = std::regex_replace(number, std::regex("[P-S]"), "7");
  number = std::regex_replace(number, std::regex("[T-V]"), "8");
  number = std::regex_replace(number, std::regex("[W-Y]"), "9");

  return number;
}

void loop() {
  bool valid = false;
  std::string inpArea;
  std::string inpMain;
  std::string inpEnd;
  std::string* inpAreaPtr = &inpArea;
  std::string* inpMainPtr = &inpMain;
  std::string* inpEndPtr = &inpEnd;
  std::string numberPre;
  std::string numberPost;

  do {
    std::cout << "Please enter the area code (3 valid alphanumeric characters): ";
    std::getline(std::cin, inpArea);
    std::cin.clear();

    if (!inpArea.empty() && validateSection(inpArea, 3)) {
      valid = true;
    }
    else {
      std::cout << "Invalid area code entered, please use valid characters only." << std::endl << std::endl;
    }
  } while (!valid);
  std::cout << std::endl << std::endl;

  valid = false;
  do {
    std::cout << "Please enter the next 3 numbers (3 valid alphanumeric characters): ";
    std::getline(std::cin, inpMain);
    std::cin.clear();

    if (!inpMain.empty() && validateSection(inpMain, 3)) {
      valid = true;
    }
    else {
      std::cout << "Invalid number section entered, please use valid characters only." << std::endl << std::endl;
    }
  } while (!valid);
  std::cout << std::endl << std::endl;

  valid = false;
  do {
    std::cout << "Please enter the final 4 numbers (4 valid alphanumeric characters): ";
    std::getline(std::cin, inpEnd);
    std::cin.clear();

    if (!inpEnd.empty() && validateSection(inpEnd, 4)) {
      valid = true;
    }
    else {
      std::cout << "Invalid final number section entered, please use valid characters only." << std::endl << std::endl;
    }
  } while (!valid);
  std::cout << std::endl << std::endl;


  upper(inpAreaPtr);
  upper(inpMainPtr);
  upper(inpEndPtr);
  numberPre = inpArea + "-" + inpMain + "-" + inpEnd;
  numberPost = anton(numberPre);

  std::cout << numberPre << std::endl;
  std::cout << numberPost << std::endl;
}

int main() {
  std::string opt;

  while (!(opt == "e" || opt == "E"))
  {
    loop();

    std::cout << std::endl << std::endl << "Prepare to enter a phone number, otherwise press [E/e] to exit." << std::endl;
    std::cout << "Press enter to continue . . ." << std::endl << std::endl;
    std::getline(std::cin, opt);
    std::cin.clear();
  }

  std::cout << std::endl << "Press enter to continue . . .";
  std::cin.get();

  return 0;
}
