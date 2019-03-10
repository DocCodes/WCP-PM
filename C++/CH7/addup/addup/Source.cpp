/**
*  @file      Source.cpp
*  @brief     Add them all up.
*
*  @author    Evan Elias Young
*  @date      2019-02-19
*  @date      2019-02-19
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include <iostream>
#include <fstream>
#include <string>

int main(int argc, char* argv[]) {
  std::ifstream file;
  std::string line;
  int tot = 0;

  file.open("data.txt");
  while (file)
  {
    std::getline(file, line);
    tot += std::stoi(line);
  }
  std::cout << "The total is " << tot << std::endl;
  file.close();

  std::system("pause");
  return 0;
}