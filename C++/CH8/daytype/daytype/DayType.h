/**
*  @file      DayType.h
*  @brief     The interface for the DayType class.
*
*  @author    Evan Elias Young
*  @date      2019-03-11
*  @date      2019-03-11
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"

class DayType
{
private:
  std::int32_t Number;

public:
  DayType();
  DayType(std::int32_t num);
  DayType(std::string day);
  DayType OffsetDay(std::int32_t offset);
  DayType NextDay();
  DayType LastDay();
  std::string toString();
  std::string ShortName();
  std::string Name();
};
