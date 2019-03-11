/**
*  @file      Source.cpp
*  @brief     The main entry point for running STB.
*
*  @author    Evan Elias Young
*  @date      2019-03-04
*  @date      2019-03-11
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "player.h"
#include "utils.h"

std::mt19937 rng = std::mt19937();
std::uint8_t curTurn = 0;
bool pips[9] = { 1, 1, 1, 1, 1, 1, 1, 1, 1 };

int main(int argc, const char *argv[])
{
  Player player0 = Player("Player 1");
  Player player1 = Player("Player 2");
  rng.seed(std::time(0));

  if (isRunning())
  {
    while (true)
    {
      system("cls");
      player0.displayPlayerName();
      displayPips();
      displayScores(player0, player1);
      if (!player0.makePlay()) { break; }

      if (!isRunning())
      {
        std::cout << "PLAYER 1 WINS";
        break;
      }
    }
  }

  if (isRunning())
  {
    while (true)
    {
      system("cls");
      player1.displayPlayerName();
      displayPips();
      displayScores(player0, player1);
      if (!player1.makePlay()) { break; }

      if (!isRunning())
      {
        std::cout << "PLAYER 2 WINS";
        break;
      }
    }
  }

  std::cout << "PLAYER " << (player0.score <= player1.score ? "2" : "1") << " WINS" << std::endl;

  std::system("pause");
  return EXIT_SUCCESS;
}