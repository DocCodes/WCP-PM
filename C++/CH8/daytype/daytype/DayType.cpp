/**
*  @file      DayType.cpp
*  @brief     The implementation for the DayType class.
*
*  @author    Evan Elias Young
*  @date      2019-03-11
*  @date      2019-03-11
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "DayType.h"

DayType::DayType()
{
  Number = 0;
}

DayType::DayType(std::int32_t num)
{
  if (num > 6 || num < 0)
  {
    throw std::invalid_argument("Invalid day number.");
  }

  Number = num;
}

DayType::DayType(std::string day)
{
  if (std::regex_match(day, std::regex("^sun(day)?$", std::regex::icase)))
  {
    Number = 0;
  }
  else if (std::regex_match(day, std::regex("^mon(day)?$", std::regex::icase)))
  {
    Number = 1;
  }
  else if (std::regex_match(day, std::regex("^tue(sday)?$", std::regex::icase)))
  {
    Number = 2;
  }
  else if (std::regex_match(day, std::regex("^wed(nesday)?$", std::regex::icase)))
  {
    Number = 3;
  }
  else if (std::regex_match(day, std::regex("^thu(rsday)?$", std::regex::icase)))
  {
    Number = 4;
  }
  else if (std::regex_match(day, std::regex("^fri(day)?$", std::regex::icase)))
  {
    Number = 5;
  }
  else if (std::regex_match(day, std::regex("^sat(day)?$", std::regex::icase)))
  {
    Number = 6;
  }
  else
  {
    throw std::invalid_argument("Invalid day string.");
  }
}

std::string DayType::ShortName()
{
  switch (Number)
  {
  case 0:
    return "Sun";
  case 1:
    return "Mon";
  case 2:
    return "Tue";
  case 3:
    return "Wed";
  case 4:
    return "Thu";
  case 5:
    return "Fri";
  case 6:
    return "Sat";
  }
}

std::string DayType::Name()
{
  switch (Number)
  {
  case 0:
    return "Sunday";
  case 1:
    return "Monday";
  case 2:
    return "Tuesday";
  case 3:
    return "Wednesday";
  case 4:
    return "Thursday";
  case 5:
    return "Friday";
  case 6:
    return "Saturday";
  }
}

DayType DayType::OffsetDay(std::int32_t offset)
{
  std::int32_t newNum = offset;
  newNum += Number;
  return DayType((newNum % 7 + 7) % 7);
}

DayType DayType::NextDay()
{
  return OffsetDay(1);
}

DayType DayType::LastDay()
{
  return OffsetDay(-1);
}

std::string DayType::toString()
{
  return Name();
}
