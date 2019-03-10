//  main.cpp
//  template
//
//  Created by Evan Elias Young on 2019-00-00.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <string>
#include <regex>

void pause();
std::string input(std::string);
bool validate(std::string);
void output(int&);
void doubler(int&);

int main(int argc, char const *argv[]) {
  std::string inp;
  int intDouble;

  while (true) {
    inp = input("Please enter a number to double (0 is the exit code): ");
    intDouble = std::stoi(inp);
    if (intDouble == 0) { break; }
    doubler(intDouble);
    output(intDouble);
  }

  pause();
  return 0;
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

void output(int& intDouble) {
  std::cout << "Your New Number: " << std::to_string(intDouble) << std::endl;
}

void doubler(int& intDouble) {
  intDouble *= 2;
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}
