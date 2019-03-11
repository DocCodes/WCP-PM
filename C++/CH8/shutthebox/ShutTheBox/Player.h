/**
*  @file      player.cpp
*  @brief     Interface for the player class.
*
*  @author    Evan Elias Young
*  @date      2019-03-04
*  @date      2019-03-04
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#ifndef STB_PLAYER_H_ // include guard
#define STB_PLAYER_H_

#include "stdafx.h"

class Player
{
public:
  Player(std::string n);
  std::string name;
  std::uint8_t score;
  bool makePlay();
  void displayPlayerName();
  void displayDieTotals();
  void displayBadSplit();
  std::uint8_t getDieSplit();
  std::uint8_t getDieUsage();

private:
  std::uint8_t curDie;
  std::uint8_t curRoll;
  std::vector<std::vector<std::uint8_t>> curOpts;
};

#endif // STB_PLAYER_H_