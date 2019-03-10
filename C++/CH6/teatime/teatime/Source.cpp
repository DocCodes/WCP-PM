/**
*  @file      Source.cpp
*  @brief     Tea price calculator.
*
*  @author    Evan Elias Young
*  @date      2019-02-04
*  @date      2019-02-05
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include <algorithm>
#include <iomanip>
#include <iostream>
#include <string>
#include <regex>

std::string getInput(std::string msg) {
  std::string ret;
  std::cout << msg;
  std::getline(std::cin, ret);
  return ret;
}

bool isValidInt(std::string t) {
  return std::regex_match(t, std::regex("^[+-]?\\d+$"));
}

bool isValidDouble(std::string t) {
  return std::regex_match(t, std::regex("^[+-]?\\d+(\\.\\d+)?$"));
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}

int main(int argc, char const *argv[]) {
  std::string temp;
  int teaPounds;
  double teaPrice;
  bool shipCharge;

  while (true) {
    temp = getInput("Please enter the pounds of tea purchased: ");
    if (isValidInt(temp)) {
      teaPounds = std::stoi(temp);
      break;
    }
  }

  while (true) {
    temp = getInput("Please enter the price of tea per pound: ");
    if (isValidDouble(temp)) {
      teaPrice = std::stod(temp);
      break;
    }
  }

  while (true) {
    temp = getInput("Please enter whether or not to charge shipping: ");
    std::transform(temp.begin(), temp.end(), temp.begin(), ::toupper);
    if (temp == "Y" || temp == "N") {
      shipCharge = temp == "Y" ? true : false;
      break;
    }
  }

  std::cout << "Tea Pounds:  " << std::fixed << std::setprecision(0) << teaPounds << std::endl;
  std::cout << "Tea Price : $" << std::fixed << std::setprecision(2) << teaPrice << std::endl;
  std::cout << "Tea Total : $" << std::fixed << std::setprecision(2) << teaPrice * teaPounds << std::endl;
  std::cout << "Shipping  : $" << std::fixed << std::setprecision(2) << (shipCharge ? 15.00 : 0) << std::endl;

  pause();
  return 0;
}
