/**
*  @file      Source.cpp
*  @brief     The main point-of-entry for the Roman Numeral app.
*
*  @author    Evan Elias Young
*  @date      2019-03-10
*  @date      2019-03-10
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "pch.h"
#include "Roman.h"
#include "RomanPhrase.h"

int main(int argc, char *argv[])
{
  std::unique_ptr<std::string> inp(new std::string());
  std::unique_ptr<RomanPhrase> phr(new RomanPhrase);

  std::cout << "Enter your roman number: ";
  std::getline(std::cin, (*inp));

  try
  {
    (*phr) = RomanPhrase((*inp));
  }
  catch (const std::invalid_argument)
  {
    std::cout << "Invalid roman numeral phrase entered." << std::endl;
    std::system("pause");
    return EXIT_FAILURE;
  }

  std::cout << (*phr).toString() << " = " << std::to_string((*phr).Evaluate()) << std::endl;

  std::system("pause");
  return EXIT_SUCCESS;
}
