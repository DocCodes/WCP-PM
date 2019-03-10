/**
*  @file      Source.cpp
*  @brief     Testing substring searches.
*
*  @author    Evan Elias Young
*  @date      2019-02-06
*  @date      2019-02-06
*  @copyright Copyright 2019 Evan Elias Young. All rights reserved.
*/

#include <iostream>
#include <string>
#include <regex>

bool charsMatch(char, char);
bool isSubstringMatch(std::string, std::vector<char>);
std::vector<char> parseSubstring(std::string);

int main(int argc, char* argv[]) {
  if (argc != 3)
  {
    std::cout << "Invalid usage:" << std::endl;
    std::cout << "invalid number of command line arguments entered." << std::endl;
    std::cout << "Proper usage:" << std::endl;
    std::cout << "SubstringSearch.exe [container] [substr]" << std::endl;
    std::cout << "  [container] the string to search in." << std::endl;
    std::cout << "  [substr]    the string to search for." << std::endl;
    std::system("pause");
    return 1;
  }
  std::string container = argv[1];
  std::string rawSubstr = argv[2];
  std::vector<char> prsSubstr = parseSubstring(rawSubstr);

  std::cout << "Container: " << container << std::endl;
  std::cout << "Matching : ";
  for (size_t i = 0; i < prsSubstr.size(); i++)
  {
    if (prsSubstr[i] != char(7))
    {
      std::cout << prsSubstr[i];
    }
    else {
      std::cout << ' ';
    }
  }
  std::cout << std::endl;
  if (isSubstringMatch(container, prsSubstr))
  {
    std::cout << "Matches" << std::endl;
  }
  else
  {
    std::cout << "Does NOT Match" << std::endl;
  }

  std::system("pause");
  return 0;
}

bool charsMatch(char a, char b) {
  if (a == char(7) || b == char(7)) { return true; }
  return a == b;
}

bool isSubstringMatch(std::string container, std::vector<char> substr) {
  if (container.length() < substr.size()) { return false; }
  if (container.length() == substr.size())
  {
    for (size_t i = 0; i < substr.size(); i++)
    {
      if (!charsMatch(substr[i], container[i])) { return false; }
    }
    return true;
  }
  if (container.length() > substr.size())
  {
    bool didPass;
    while (container.length() > substr.size())
    {
      didPass = true;
      for (size_t i = 0; i < substr.size(); i++)
      {
        if (!charsMatch(substr[i], container[i]))
        {
          didPass = false;
          break;
        }
      }
      if (didPass)
      {
        return true;
      }
      container.erase(0);
    }
  }
}

std::vector<char> parseSubstring(std::string sub) {
  std::vector<char>ret;
  ret.resize(sub.length());
  size_t size = 0;

  for (size_t i = 0; i < sub.length(); i++)
  {
    if (sub[i] != '*' && sub[i] != '\\')
    {
      ret[size] = sub[i];
    }
    else if (sub[i] == '*')
    {
      ret[size] = char(7);
    }
    else if (sub[i] == '\\')
    {
      switch (sub[i + 1])
      {
      case '*':
        ret[size] = '*';
        break;
      case '\\':
        ret[size] = '\\';
        break;
      default:
        break;
      }
      ++i;
    }
    ++size;
  }
  ret.resize(size);
  return ret;
}