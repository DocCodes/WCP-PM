/**
*  @file      Roman.cpp
*  @brief     The implementation for the Roman class.
*
*  @author    Evan Elias Young
*  @date      2019-03-10
*  @date      2019-03-10
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "pch.h"
#include "Roman.h"

Roman::Roman()
{
  Icon = 0;
  Value = 0;
}

Roman::Roman(char icon)
{
  // Lowercase to uppercase
  if (icon >= 'a')
  {
    icon -= 32;
  }

  // Evaluate valid vs invalid icon
  switch (icon)
  {
  case 'I':
    Value = 1;
    break;
  case 'V':
    Value = 5;
    break;
  case 'X':
    Value = 10;
    break;
  case 'L':
    Value = 50;
    break;
  case 'C':
    Value = 100;
    break;
  case 'D':
    Value = 500;
    break;
  case 'M':
    Value = 1000;
    break;
  default:
    throw std::invalid_argument("Invalid argument for icon.");
    break;
  }
  Icon = icon;
}

std::string Roman::toString() const
{
  return std::to_string(Icon);
}

std::ostream &Roman::operator<<(std::ostream &outs)
{
  return outs << toString();
}
