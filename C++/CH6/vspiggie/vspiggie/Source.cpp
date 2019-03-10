//  main.cpp
//  piggie
//
//  Created by Evan Elias Young on 2019-01-29.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iomanip>
#include <iostream>

void pause();
void altPiggie(double*, double);
void altPiggie(double*, double, double);

int main(int argc, char const *argv[]) {
  double piggieVal = 50.00;
  double* piggiePtr = &piggieVal;
  double depositAmt;
  double withdrawAmt;

  std::cout << "Piggie Banker" << std::endl;
  std::cout << "Balance : $" << std::fixed << std::setprecision(2) << (*piggiePtr) << std::endl;
  std::cout << std::endl;

  std::cout << "Deposit : $";
  std::cin >> depositAmt;
  std::cout << "Withdraw: $";
  std::cin >> withdrawAmt;

  if (withdrawAmt == 0) {
    altPiggie(piggiePtr, depositAmt);
  }
  else {
    altPiggie(piggiePtr, depositAmt, withdrawAmt);
  }

  std::cout << std::endl;
  std::cout << "Balance : $" << std::fixed << std::setprecision(2) << (*piggiePtr) << std::endl;

  std:system("pause");
  return 0;
}

void altPiggie(double* piggiePtr, double dep) {
  (*piggiePtr) += dep;
}
void altPiggie(double* piggiePtr, double dep, double wth) {
  (*piggiePtr) += dep;
  (*piggiePtr) -= wth;
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}
