/**
*  @file      utils.h
*  @brief     Implementation for the various utilities.
*
*  @author    Evan Elias Young
*  @date      2019-03-04
*  @date      2019-03-04
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "utils.h"
#include "player.h"

bool isRunning() {
  for (std::size_t i = 0; i < 9; i++)
  {
    if (pips[i]) { return true; }
  }
  return false;
}

std::uint8_t rollD6() {
  std::unique_ptr<double> rand(new double(rng()));
  return std::round(5 * (*rand) / rng.max()) + 1;
}

std::uint32_t rollD6(std::uint8_t die) {
  std::unique_ptr<std::uint32_t> acc(new std::uint32_t());

  for (std::size_t i = 0; i < die; i++)
  {
    (*acc) += rollD6();
  }

  return (*acc);
}

void getSubDivision(std::uint8_t goal, std::uint8_t max, std::vector<std::vector<std::uint8_t>> *divs) {
  std::unique_ptr<std::vector<std::uint8_t>> buf(new std::vector<std::uint8_t>());
  std::unique_ptr<std::uint8_t> acc(new std::uint8_t(0));

  for (std::size_t i = max; i >= 0; i--)
  {
    if (i > max) { return; }
    if (i > 0 && !pips[i - 1]) { continue; }
    if ((*acc) == goal)
    {
      (*divs).push_back((*buf));
      return;
    }
    if ((*acc) + i > goal) { continue; }

    (*buf).push_back(i);
    (*acc) += i;
  }
}

std::vector<std::vector<std::uint8_t>> getDivisions(std::uint8_t goal) {
  std::unique_ptr<std::vector<std::vector<std::uint8_t>>> divs(new std::vector<std::vector<std::uint8_t>>());

  for (std::size_t i = std::min(goal, std::uint8_t(9)); i > 0; i--)
  {
    getSubDivision(goal, i, divs.get());
  }

  return (*divs);
}

std::uint8_t calcScore() {
  std::unique_ptr<std::uint8_t> acc(new std::uint8_t(0));
  std::unique_ptr<std::uint8_t> i(new std::uint8_t(0));
  while ((*i) < 9)
  {
    if (pips[(*i)++])
    {
      (*acc) += (*i);
    }
  }
  return (*acc);
}

void printBoxTop() {
  std::cout << T_L_CORNER << std::string(78, HORZ_LINE) << T_R_CORNER;
}

void printBoxTop(const std::string &s) {
  std::unique_ptr<std::uint8_t> ln(new std::uint8_t(s.length()));
  std::cout << T_L_CORNER;

  if ((*ln) % 2 == 1)
  {
    std::cout << std::string(39 - ((*ln) - 1) / 2, HORZ_LINE);
    std::cout << s;
    std::cout << std::string(39 - ((*ln) + 1) / 2, HORZ_LINE);
  }
  else
  {
    std::cout << std::string(39 - (*ln) / 2, HORZ_LINE);
    std::cout << s;
    std::cout << std::string(39 - (*ln) / 2, HORZ_LINE);
  }

  std::cout << T_R_CORNER;
}

void printBoxBottom() {
  std::cout << B_L_CORNER << std::string(78, HORZ_LINE) << B_R_CORNER;
  std::cout << std::endl;
}

void displayPips() {
  printBoxTop("PIPS");
  std::cout << std::endl << std::string(18, ' ');

  for (std::size_t i = 0; i < 9; i++)
  {
    if (pips[i])
    {
      std::cout << "  " << i + 1 << "  ";
    }
    else
    {
      std::cout << "     ";
    }
  }

  std::cout << std::endl << std::endl;
  printBoxBottom();
}

void displayScores(Player pl0, Player pl1) {
  printBoxTop("SCORES");

  std::cout << std::string(39, ' ') << std::to_string(pl0.score) << std::endl;
  std::cout << std::string(39, ' ') << std::to_string(pl1.score) << std::endl;

  printBoxBottom();
}