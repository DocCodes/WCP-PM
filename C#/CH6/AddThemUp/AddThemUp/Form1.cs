using System;
using System.Windows.Forms;

/*
	Author       : Evan Elias Young
	Comment      : Adds up the even numbers in a range of numbers.
	Date Created : 2018-09-25
	Date Updated : 2018-09-25
*/

namespace AddThemUp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			int start = (int)inputStart.Value;
			int end = (int)inputEnd.Value;
			int tot = 0;

			if (start > end)
			{
				MessageBox.Show("The starting number must be less than the ending number.", "Invalid Numbers Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			for (int i = start; i <= end; i++)
			{
				tot += i % 2 == 0 ? i : 0;
			}

			outputSum.Value = tot;
		}
	}
}
