using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : Averages numbers together
	Date Created : 2018-08-17
	Date Updated : 2018-08-17
*/

namespace AverageNumbers
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void HandleValuesUpdate()
		{
			decimal NumOne = InputNum1.Value;
			decimal NumTwo = InputNum2.Value;
			decimal NumThree = InputNum3.Value;
			decimal NumFour = InputNum4.Value;
			decimal NumFive = InputNum5.Value;
			decimal Average = (NumOne + NumTwo + NumThree + NumFour + NumFive) / 5;

			OutputAverage.Text = Average.ToString();
		}

		private void InputNum1_ValueChanged(object sender, EventArgs e)
		{
			HandleValuesUpdate();
		}

		private void InputNum2_ValueChanged(object sender, EventArgs e)
		{
			HandleValuesUpdate();
		}

		private void InputNum3_ValueChanged(object sender, EventArgs e)
		{
			HandleValuesUpdate();
		}

		private void InputNum4_ValueChanged(object sender, EventArgs e)
		{
			HandleValuesUpdate();
		}

		private void InputNum5_ValueChanged(object sender, EventArgs e)
		{
			HandleValuesUpdate();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
