/**
*  @file      RomanPhrase.h
*  @brief     The interface for the Roman Phrase class.
*
*  @author    Evan Elias Young
*  @date      2019-03-10
*  @date      2019-03-10
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#ifndef ROMAN_ROMAN_PHRASE_H_
#define ROMAN_ROMAN_PHRASE_H_

#include "pch.h"
#include "Roman.h"

class RomanPhrase
{
public:
  RomanPhrase();
  RomanPhrase(const std::string &p);
  std::uint32_t Evaluate();
  std::string toString() const;
  std::ostream &operator<<(std::ostream &outs);
  std::string Phrase;

private:
  std::vector<Roman> NumeralPhrase;
};

#endif // ROMAN_ROMAN_PHRASE_H_
