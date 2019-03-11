/*
	Author       : Evan Elias Young
	Comment      : Student class
	Date Created : 2018-10-23
	Date Updated : 2018-10-23
*/

namespace StudentApp
{
	/// <summary>
	/// Represents a Student object.
	/// </summary>
	class Student
	{
		#region Properties
		/// <summary>
		/// The student's major.
		/// </summary>
		public string Major { get; set; }

		/// <summary>
		/// The student's id number.
		/// </summary>
		public string ID { get; set; }

		/// <summary>
		/// The student's first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// The student's last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// The student's score on the first exam.
		/// </summary>
		public int Score1 { get; set; }

		/// <summary>
		/// The student's score on the second exam.
		/// </summary>
		public int Score2 { get; set; }

		/// <summary>
		/// The student's score on the third exam.
		/// </summary>
		public int Score3 { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Represents a Student object.
		/// </summary>
		public Student() { }

		/// <summary>
		/// Represents a Student object.
		/// </summary>
		/// <param name="id">The student's id number.</param>
		public Student(string id)
		{
			ID = id;
		}

		/// <summary>
		/// Represents a Student object.
		/// </summary>
		/// <param name="id">The student's id number.</param>
		/// <param name="lastName">The student's last name.</param>
		/// <param name="firstName">The student's first name</param>
		public Student(string id, string lastName, string firstName)
		{
			ID = id;
			FirstName = firstName;
			LastName = lastName;
		}

		/// <summary>
		/// Represents a Student object.
		/// </summary>
		/// <param name="id">The student's id number.</param>
		/// <param name="lastName">The student's last name.</param>
		/// <param name="firstName">The student's first name</param>
		/// <param name="score1">The student's score on the first exam.</param>
		/// <param name="score2">The student's score on the second exam.</param>
		/// <param name="score3">The student's score on the third exam.</param>
		public Student(string id, string lastName, string firstName, int score1, int score2, int score3)
		{
			ID = id;
			FirstName = firstName;
			LastName = lastName;
			Score1 = score1;
			Score2 = score2;
			Score3 = score3;
		}
		#endregion

		#region Other Methods
		/// <summary>
		/// Calculates the average of the student's test scores.
		/// </summary>
		/// <returns>The average of the student's test scores.</returns>
		public double CalculateAverage()
		{
			return (double)(Score1 + Score2 + Score3) / 3;
		}
		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString()
		{
			return $"Name: {FirstName} {LastName}\nMajor: {Major}\nScore: {CalculateAverage()}";
		}
		#endregion
	}
}
