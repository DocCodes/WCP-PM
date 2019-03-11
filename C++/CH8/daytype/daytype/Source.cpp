/**
*  @file      Source.cpp
*  @brief     The main point of entry for the DayType calculator.
*
*  @author    Evan Elias Young
*  @date      2019-03-11
*  @date      2019-03-11
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "DayType.h"

int main(int argc, char *argv[])
{
  std::unique_ptr<std::string> inp(new std::string());
  std::unique_ptr<std::int32_t> off(new std::int32_t());
  std::unique_ptr<DayType> day(new DayType);

  std::cout << "Enter your day: ";
  std::getline(std::cin, (*inp));

  try
  {
    (*day) = DayType((*inp));
  }
  catch (const std::exception &)
  {
    std::cout << "Invalid date string entered.";

    std::system("pause");
    return EXIT_FAILURE;
  }

  std::cout << "Enter your days to add: ";
  std::getline(std::cin, (*inp));

  try
  {
    (*off) = std::stoi((*inp));
  }
  catch (const std::exception&)
  {
    std::system("pause");
    return EXIT_FAILURE;
  }

  std::cout << std::endl;
  std::cout << "The selected day is " << (*day).toString() << std::endl;
  std::cout << "The previous day is " << (*day).LastDay().toString() << std::endl;
  std::cout << "The next day is " << (*day).NextDay().toString() << std::endl;
  std::cout << "The " << (*off) << " day is " << (*day).OffsetDay((*off)).toString() << std::endl;

  std::system("pause");
  return EXIT_SUCCESS;
}
