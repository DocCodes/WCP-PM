//  main.cpp
//  area
//
//  Created by Evan Elias Young on 2019-01-29.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <limits>
#include <string>
#include <regex>

void pause();
bool validateDouble(std::string);
std::string getline();
double area(double);
double area(double, double);

int main(int argc, char const *argv[]) {
  std::string temp;
  std::string opt;
  double shapeArea;
  double x;
  double y;

  do {
    std::cout << "Please Select [S]quare or [R]ectangle" << std::endl;
    std::cin.clear();
    std::cin >> opt;
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
  } while (!(opt == "s" || opt == "S" || opt == "r" || opt == "R"));

  while (true) {
    std::cout << "Side 1: ";
    temp = getline();
    if (validateDouble(temp)) {
      x = std::stod(temp);
      break;
    }
  }

  if (opt == "s" || opt == "S") {
    shapeArea = area(x);
    std::cout << "The Area of Your Square is: ";
  }
  else {
    while (true) {
      std::cout << "Side 2: ";
      temp = getline();
      if (validateDouble(temp)) {
        y = std::stod(temp);
        break;
      }
    }
    shapeArea = area(x, y);
    std::cout << "The Area of Your Rectangle is: ";
  }

  std::cout << std::to_string(shapeArea) << std::endl;

  pause();
  return 0;
}

bool validateDouble(std::string s) {
  return std::regex_match(s, std::regex("^[-+]?([0-9]*\\.[0-9]+|[0-9]+)$")) ? true : false;
}

std::string getline() {
  std::string temp;
  std::getline(std::cin, temp);
  return temp;
}

double area(double x) {
  return x * x;
}

double area(double x, double y) {
  return x * y;
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}
