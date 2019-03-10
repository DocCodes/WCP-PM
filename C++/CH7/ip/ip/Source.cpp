/**
*  @file      Source.cpp
*  @brief     IP Address tool.
*
*  @author    Evan Elias Young
*  @date      2019-02-19
*  @date      2019-02-19
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include <math.h>

#include <fstream>
#include <iostream>
#include <iomanip>
#include <string>
#include <vector>

int btoi(const std::string& bin) {
  int ret = 0;
  for (std::size_t i = 0; i < bin.length(); i++)
  {
    ret += std::pow(2, i) * std::stoi(bin.substr(bin.length() - i - 1, 1));
  }
  return ret;
}

std::vector<unsigned short> getIP(const std::string& line) {
  std::vector<unsigned short> ret;
  for (std::size_t i = 0; i < 4; i++)
  {
    ret.push_back(btoi(line.substr(i * 8, 8)));
  }
  return ret;
}

void doLoop(const std::string& line) {
  std::vector<unsigned short> ip = getIP(line);
  std::cout << ip[0] << '.' << ip[1] << '.' << ip[2] << '.' << ip[3] << "\t\t";

  if (ip[0] <= 127)
  {
    std::cout << "Class A" << std::endl;
  }
  else if (ip[0] <= 191)
  {
    std::cout << "Class B" << std::endl;
  }
  else if (ip[0] <= 223)
  {
    std::cout << "Class C" << std::endl;
  }
  else if (ip[0] <= 239)
  {
    std::cout << "Class D" << std::endl;
  }
  else
  {
    std::cout << "Class E" << std::endl;
  }
}

int main(int argc, char* argv[]) {
  std::ifstream file;
  std::string line;

  file.open("data.txt");
  while (file)
  {
    std::getline(file, line);
    doLoop(line);
  }
  file.close();

  std::system("pause");
  return 0;
}