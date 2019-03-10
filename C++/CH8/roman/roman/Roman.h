/**
*  @file      Roman.h
*  @brief     The interface for the Roman class.
*
*  @author    Evan Elias Young
*  @date      2019-03-10
*  @date      2019-03-10
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#ifndef ROMAN_ROMAN_H_
#define ROMAN_ROMAN_H_

#include "pch.h"

class Roman
{
public:
  Roman();
  Roman(char icon);
  std::string toString() const;
  std::ostream &operator<<(std::ostream &outs);
  char Icon;
  std::uint16_t Value;
};

#endif // !ROMAN_ROMAN_H_
