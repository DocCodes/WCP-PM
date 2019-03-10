/**
*  @file      Source.cpp
*  @brief     Valley Sorter.
*
*  @author    Evan Elias Young
*  @date      2019-02-05
*  @date      2019-02-05
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include <iostream>
#include <sstream>
#include <string>
#include <regex>
#include <vector>

std::string getInput(std::string);
std::vector<std::string> getLine(std::string);
bool isValidLine(std::vector<std::string>);
bool isValidInt(std::string);
template <class T> void outputVector(std::vector<T>, std::string);
template <class T> std::vector<T> bubbleSort(std::vector<T>);
template <class T> std::vector<T> valleySort(std::vector<T>);

int main(int argc, char* argv[]) {
  std::string rawNums = getInput("Please enter your numbers, max 10.\n");
  std::vector<std::string> strNums = getLine(rawNums);
  std::vector<int> intNums;

  if (!isValidLine(strNums))
  {
    std::cout << "One or more of the numbers were invalid." << std::endl;
  }
  else if (strNums.size() > 10) {
    std::cout << "Too many numbers were entered." << std::endl;
  }
  else {
    intNums.resize(strNums.size());
    for (size_t i = 0; i < strNums.size(); i++)
    {
      intNums[i] = std::stoi(strNums[i]);
    }
    intNums.shrink_to_fit();
    outputVector(intNums, ", ");
    intNums = bubbleSort(intNums);
    intNums = valleySort(intNums);
    outputVector(intNums, ", ");
  }

  std::system("pause");
  return 0;
}

template <class T> void outputVector(std::vector<T> vct, std::string delim) {
  for (size_t i = 0; i < vct.size() - 1; i++)
  {
    std::cout << vct[i] << delim;
  }
  std::cout << vct[vct.size() - 1] << std::endl;
}

template <class T> std::vector<T> bubbleSort(std::vector<T> vct) {
  T swp;
  for (size_t i = 0; i < vct.size() - 1; i++)
  {
    for (size_t j = 0; j < vct.size() - 1; j++)
    {
      if (vct[j] > vct[j + 1])
      {
        swp = vct[j];
        vct[j] = vct[j + 1];
        vct[j + 1] = swp;
      }
    }
  }
  return vct;
}

template <class T> std::vector<T> valleySort(std::vector<T> vct) {
  std::vector<T> ret;
  ret.resize(vct.size());
  size_t maxInd = vct.size() - 1;
  size_t midInd = vct.size() / 2;

  for (size_t i = 0; i < midInd; i++)
  {
    ret[i] = vct[maxInd - (i * 2)];
    ret[maxInd - i] = vct[maxInd - (i * 2) - 1];
  }
  ret[midInd] = vct[0];

  std::cout << std::endl;
  return ret;
}

std::string getInput(std::string msg) {
  std::string temp;
  std::cout << msg;
  std::getline(std::cin, temp);
  return temp;
}

std::vector<std::string> getLine(std::string s) {
  std::istringstream ss(s);
  std::vector<std::string> vct(std::istream_iterator<std::string>{ss}, std::istream_iterator<std::string>{});
  return vct;
}

bool isValidLine(std::vector<std::string> vct) {
  for (size_t i = 0; i < vct.size(); i++)
  {
    if (!isValidInt(vct[i])) { return false; }
  }

  return true;
}

bool isValidInt(std::string s) {
  return std::regex_match(s, std::regex("\\d+"));
}