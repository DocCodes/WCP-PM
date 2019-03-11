/**
*  @file      player.cpp
*  @brief     Implementation for the player class.
*
*  @author    Evan Elias Young
*  @date      2019-03-04
*  @date      2019-03-04
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "player.h"
#include "utils.h"

Player::Player(std::string n)
{
  score = 0;
  name = n;
}

bool Player::makePlay() {
  std::unique_ptr<std::vector<std::uint8_t>> dieSplit(new std::vector<std::uint8_t>());
  curDie = getDieUsage();
  curRoll = rollD6(curDie);
  curOpts = getDivisions(curRoll);
  if (curOpts.size() == 0) {
    displayBadSplit();
    return false;
  }
  (*dieSplit) = curOpts[getDieSplit()];

  for (std::size_t i = 0; i < (*dieSplit).size(); i++)
  {
    pips[(*dieSplit)[i] - 1] = false;
  }
  score += calcScore();
  return true;
}

void Player::displayPlayerName() {
  std::unique_ptr<std::uint8_t> ln(new std::uint8_t(name.length()));

  if ((*ln) % 2 == 1)
  {
    std::cout << std::string(40 - ((*ln) - 1) / 2, HORZ_LINE);
    std::cout << name;
    std::cout << std::string(40 - ((*ln) + 1) / 2, HORZ_LINE);
  }
  else
  {
    std::cout << std::string(40 - (*ln) / 2, HORZ_LINE);
    std::cout << name;
    std::cout << std::string(40 - (*ln) / 2, HORZ_LINE);
  }
}

void Player::displayBadSplit() {
  printBoxTop("ROLL SPLITS");
  this->displayDieTotals();
  printBoxBottom();

  std::system("pause");
}

std::uint8_t Player::getDieSplit() {
  std::unique_ptr<std::string> inp(new std::string());
  std::unique_ptr<std::uint8_t> sel(new std::uint8_t(0));

  printBoxTop("ROLL SPLITS");
  this->displayDieTotals();

  while (true)
  {
    std::cout << "  HOW DO YOU WANT TO SPLIT YOUR ROLL" << std::endl << "  ";
    std::getline(std::cin, (*inp));
    if (std::regex_match((*inp), std::regex("^\\d$")))
    {
      (*sel) = std::stoi((*inp)) - 1;
      if ((*sel) >= 0 && (*sel) < curOpts.size())
      {
        break;
      }
    }
  }

  printBoxBottom();

  return (*sel);
}

void Player::displayDieTotals() {
  std::cout << "  YOU ROLLED <" << std::to_string(curRoll) << '>' << std::endl;
  for (std::size_t i = 0; i < curOpts.size(); i++)
  {
    std::cout << "  [" << i + 1 << ']' << " (" << std::to_string(curOpts[i][0]);
    for (std::size_t j = 1; j < curOpts[i].size(); j++)
    {
      std::cout << ' ' << std::to_string(curOpts[i][j]);
    }
    std::cout << ')' << std::endl;
  }
}

std::uint8_t Player::getDieUsage() {
  std::unique_ptr<std::uint8_t> ret(new std::uint8_t());
  std::unique_ptr<std::string> inp(new std::string());
  printBoxTop("DICE");

  while (true)
  {
    std::cout << "  HOW MANY DICE DO YOU WANT TO ROLL" << std::endl << "  [1] [2]" << std::endl;

    if (pips[8] || pips[7] || pips[6])
    {
      (*ret) = 2;
      break;
    }
    std::cout << "  ";
    std::getline(std::cin, (*inp));
    if (std::regex_match((*inp), std::regex("^(1|2)$")))
    {
      (*ret) = std::uint8_t(std::stoi((*inp)));
      break;
    }
  }
  std::cout << "  <" << std::to_string((*ret)) << "> DICE HAVE BEEN CHOSEN" << std::endl;
  printBoxBottom();

  return (*ret);
}