#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>
#include <regex>
#include <array>
using namespace std;

char getGradeChar(int grade) {
	char gradeChars[4] = { 'D', 'C', 'B', 'A' };
	if (grade < 240)
	{
		return 'F';
	}
	return gradeChars[(int)floor((grade - 240) / 40)];
}

string joinArray(int ar[], int size, string sep) {
	stringstream ss;
	ss << ar[0];
	for (size_t i = 1; i < size; i++)
	{
		ss << sep;
		ss << ar[i];
	}

	return ss.str();
}

int sumArray(int ar[], int size) {
	int tot = 0;
	for (size_t i = 0; i < size; i++)
	{
		tot += ar[i];
	}
	return tot;
}

int main() {
	int tempScore;
	int projectScores[4];
	int testScores[2];
	int totalGrade;
	int i = 0;
	char gradeChar;

	while (i < 4)
	{
		cout << "Please enter a project score: ";
		cin >> tempScore;

		while (true)
		{
			if (cin.fail() || tempScore < 0 || tempScore > 50)
			{
				cin.clear();
				cin.ignore(numeric_limits<streamsize>::max(), '\n');
				cout << "Invalid project score entered" << endl << endl;
				cout << "Please enter a project score: ";
				cin >> tempScore;
			}
			else
			{
				break;
			}
		}
		projectScores[i++] = tempScore;
		cout << "Project score recorded" << endl << endl;
	}
	i = 0;

	while (i < 2)
	{
		cout << "Please enter a test score: ";
		cin >> tempScore;

		while (true)
		{
			if (cin.fail() || tempScore < 0 || tempScore > 100)
			{
				cin.clear();
				cin.ignore(numeric_limits<streamsize>::max(), '\n');
				cout << "Invalid test score entered" << endl << endl;
				cout << "Please enter a test score: ";
				cin >> tempScore;
			}
			else
			{
				break;
			}
		}
		testScores[i++] = tempScore;
		cout << "Project score recorded" << endl << endl;
	}
	cout.clear();
	totalGrade = sumArray(projectScores, 4) + sumArray(testScores, 2);

	cout << "Project Scores: " << joinArray(projectScores, 4, ", ") << "  " << sumArray(projectScores, 4) << endl;
	cout << "Test Scores: " << joinArray(testScores, 2, ", ") << "  " << sumArray(testScores, 2) << endl;
	cout << "Total Score: " << totalGrade << endl;
	cout << "Grade Score: " << getGradeChar(totalGrade) << endl;

	return 0;
}