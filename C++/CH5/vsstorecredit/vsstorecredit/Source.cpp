//  main.cpp
//  storecredit
//
//  Created by Evan Elias Young on 2019-01-24.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <string>
#include <regex>
#include <vector>

void pause();
std::vector<size_t> getClosestMatch(int, std::vector<int>);
std::string input(std::string);
bool validate(std::string);

int main(int argc, char const *argv[]) {
  int i = 0;
  int credit;
  int items;
  int pr;
  std::vector<int> prices;
  std::vector<size_t> bestMatch;

  do {
    credit = std::stoi(input("Please enter the amount of credit you have: "));
  } while (credit < 5 || credit > 1000);
  do {
    items = std::stoi(input("Please enter the number of items in the store: "));
  } while (items < 3 || items > 100);
  do {
    pr = std::stoi(input("Enter the price of item #" + std::to_string(i + 1) + "/" + std::to_string(items) + ": "));
    if (pr >= 1 && pr <= 1000) {
      prices.push_back(pr);
      ++i;
    }
  } while (i < items);

  bestMatch = getClosestMatch(credit, prices);
  std::cout << std::endl;
  std::cout << "The Best Items To Buy" << std::endl;
  std::cout << bestMatch[0] + 1 << ", " << bestMatch[1] + 1 << std::endl;

  pause();
  return 0;
}

std::vector<size_t> getClosestMatch(int desired, std::vector<int> v) {
  std::vector<size_t> ret = { 0, 1 };
  int rTot = 0;
  int xVal;
  int yVal;
  int cTot;
  for (size_t x = 0; x < v.size(); x++) {
    for (size_t y = 0; y < v.size(); y++) {
      if (y == x) { continue; }
      xVal = v[x];
      yVal = v[y];
      cTot = xVal + yVal;

      if (cTot > desired) { continue; }
      if (cTot == desired) {
        ret = { x, y };
        return ret;
      }

      if (cTot < desired && cTot > rTot) {
        rTot = cTot;
        ret = { x, y };
      }
    }
  }

  return ret;
}

std::string input(std::string msg) {
  std::string inp;

  do {
    std::cout << msg;

    std::getline(std::cin, inp, '\n');
  } while (!validate(inp));

  return inp;
}

bool validate(std::string inp) {
  std::regex intRegex("^[+-]?\\d+$");

  return std::regex_match(inp, intRegex);
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}
