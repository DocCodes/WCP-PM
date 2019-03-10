//  main.cpp
//  sort
//
//  Created by Evan Elias Young on 2019-01-29.
//  Copyright 2019 Evan Elias Young. All rights reserved.

#include <iostream>
#include <string>
#include <sstream>

void pause();
template <class T> std::string join(T, size_t, std::string);
template <class T> void sorter(T*, size_t);

int main(int argc, char const *argv[]) {
  int arrayInt[3] = { 2000, 7, 27 };
  double arrayDbl[3] = { 5.95, 185.25, 18.60 };
  std::string arrayStr[3] = { "Young", "Elias", "Evan" };

  std::cout << "Pre-Sort" << '\n';
  std::cout << "Int: " << join(arrayInt, 3, ", ") << '\n';
  std::cout << "Dbl: " << join(arrayDbl, 3, ", ") << '\n';
  std::cout << "Str: " << join(arrayStr, 3, ", ") << '\n';
  std::cout << '\n';

  sorter(arrayInt, 3);
  sorter(arrayDbl, 3);
  sorter(arrayStr, 3);

  std::cout << "Post-Sort" << '\n';
  std::cout << "Int: " << join(arrayInt, 3, ", ") << '\n';
  std::cout << "Dbl: " << join(arrayDbl, 3, ", ") << '\n';
  std::cout << "Str: " << join(arrayStr, 3, ", ") << '\n';

  pause();
  return 0;
}

template <class T> std::string join(T a, size_t size, std::string delim) {
  std::stringstream ss;
  size_t i = 0;

  ss << a[i++];
  while (i < size) {
    ss << delim << a[i++];
  }

  return ss.str();
}

template <class T> void sorter(T* a, size_t s) {
  for (size_t i = 0; i < s - 1; i++) {
    T x = a[i];
    T y = a[i + 1];
    if (x > y) {
      a[i] = y;
      a[i + 1] = x;
    }
  }
}

void pause() {
  std::cout << "Press the enter key to continue . . ." << std::endl;
  std::cin.clear();
  std::cin.get();
}
