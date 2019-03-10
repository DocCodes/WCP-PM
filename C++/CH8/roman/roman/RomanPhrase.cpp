/**
*  @file      RomanPhrase.cpp
*  @brief     The implementation for the Roman Phrase class.
*
*  @author    Evan Elias Young
*  @date      2019-03-10
*  @date      2019-03-10
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "pch.h"
#include "RomanPhrase.h"
#include "Roman.h"

RomanPhrase::RomanPhrase()
{
  Phrase = "";
  std::vector<Roman> NumeralPhrase = std::vector<Roman>();
}

RomanPhrase::RomanPhrase(const std::string &p)
{
  Phrase = p;
  NumeralPhrase = std::vector<Roman>();

  try
  {
    for (std::size_t i = 0; i < Phrase.length(); i++)
    {
      NumeralPhrase.push_back(Roman(Phrase[i]));
    }
  }
  catch (const std::invalid_argument &)
  {
    throw std::invalid_argument("Invalid argument for phrase.");
  }
}

std::uint32_t RomanPhrase::Evaluate()
{
  std::unique_ptr<Roman> r(new Roman());
  std::unique_ptr<std::uint32_t> val(new std::uint32_t(0));
  std::unique_ptr<std::size_t> max(new std::size_t(NumeralPhrase.size()));

  for (std::size_t i = 0; i < (*max); i++)
  {
    (*r) = NumeralPhrase[i];
    if (i + 1 == (*max) || (*r).Icon == 'V' || (*r).Icon == 'L' || (*r).Icon == 'M')
    {
      (*val) += (*r).Value;
      continue;
    }

    switch ((*r).Icon)
    {
    case 'I':
      switch (NumeralPhrase[i + 1].Icon)
      {
      case 'V':
        (*val) += 4;
        i++;
        break;
      case 'X':
        (*val) += 9;
        i++;
        break;
      default:
        (*val) += (*r).Value;
      }
      break;
    case 'X':
      switch (NumeralPhrase[i + 1].Icon)
      {
      case 'L':
        (*val) += 40;
        i++;
        break;
      case 'C':
        (*val) += 90;
        i++;
        break;
      default:
        (*val) += (*r).Value;
      }
      break;
    case 'C':
      switch (NumeralPhrase[i + 1].Icon)
      {
      case 'D':
        (*val) += 400;
        i++;
        break;
      case 'M':
        (*val) += 900;
        i++;
        break;
      default:
        (*val) += (*r).Value;
      }
      break;
    }
  }

  return (*val);
}

std::string RomanPhrase::toString() const
{
  return Phrase;
}

std::ostream &RomanPhrase::operator<<(std::ostream &outs)
{
  return outs << toString();
}
