using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FourNumbers
{
	public partial class Form1 : Form
	{
		private static List<int> numbers = new List<int> { };
		private static Random rng = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		private void DisplayNumbers(List<int> numbers)
		{
			NumericUpDown[] inputs = { input1, input2, input3, input4, input5 };

			for (int i = 0; i < numbers.Count; i++)
			{
				inputs[i].Value = numbers[i];
			}
		}

		private void UpdateRange(Label labelRange, int min, int max)
		{
			labelRange.Text = $"{min} - {max}";
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			if (numbers.Count < 5)
			{
				if (numbers.Count == 0)
				{
					numbers.Add(Convert.ToInt32(input1.Value));
					UpdateRange(labelRange2, 1, numbers[0]);
					numbers.Add(rng.Next(1, numbers[0]));
					input1.Enabled = false;
				}
				else if (numbers.Count == 2)
				{
					UpdateRange(labelRange3, numbers[1], numbers[1] + 100);
					numbers.Add(rng.Next(numbers[1], numbers[1] + 100));
				}
				else if (numbers.Count == 3)
				{
					UpdateRange(labelRange4, numbers[2], numbers[2] + 100);
					numbers.Add(rng.Next(numbers[2], numbers[2] + 100));
				}
				else
				{
					UpdateRange(labelRange5, numbers[3], numbers[3] + 100);
					numbers.Add(rng.Next(numbers[3], numbers[3] + 100));
				}
				DisplayNumbers(numbers);
			}
		}
	}
}
