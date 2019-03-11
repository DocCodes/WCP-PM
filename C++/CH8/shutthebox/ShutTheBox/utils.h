/**
*  @file      utils.h
*  @brief     Interface for the various utilities.
*
*  @author    Evan Elias Young
*  @date      2019-03-04
*  @date      2019-03-04
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include "stdafx.h"
#include "player.h"

extern std::mt19937 rng;
extern std::uint8_t curTurn;
extern bool pips[9];

const unsigned char T_L_CORNER = 218;
const unsigned char T_R_CORNER = 191;
const unsigned char B_L_CORNER = 192;
const unsigned char B_R_CORNER = 217;
const unsigned char HORZ_LINE = 196;
const unsigned char VERT_LINE = 179;

bool isRunning();

std::uint8_t rollD6();
std::uint32_t rollD6(std::uint8_t die);
std::vector<std::vector<std::uint8_t>> getDivisions(std::uint8_t goal);
std::uint8_t calcScore();

void printBoxTop();
void printBoxTop(const std::string &s);
void printBoxBottom();
void displayPips();
void displayScores(Player pl0, Player pl1);