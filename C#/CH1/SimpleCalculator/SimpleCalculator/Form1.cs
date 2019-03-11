using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : Calculator
	Date Created : 2018-08-20
	Date Updated : 2018-08-20
*/

namespace SimpleCalculator
{
	public partial class Form1 : Form
	{
		public long NumOne;
		public long NumTwo;

		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			OutputBox.Text = $"{NumOne} + {NumTwo} = {NumOne + NumTwo}";
		}

		private void ButtonSub_Click(object sender, EventArgs e)
		{
			OutputBox.Text = $"{NumOne} - {NumTwo} = {NumOne - NumTwo}";
		}

		private void ButtonMult_Click(object sender, EventArgs e)
		{
			OutputBox.Text = $"{NumOne} x {NumTwo} = {NumOne * NumTwo}";
		}

		private void ButtonDiv_Click(object sender, EventArgs e)
		{
			if (NumTwo == 0)
			{
				OutputBox.Text = "Divide By Zero Error";
			}
			else
			{
				OutputBox.Text = $"{NumOne} ÷ {NumTwo} = {NumOne / NumTwo}";
			}
		}

		private void InputNum1_ValueChanged(object sender, EventArgs e)
		{
			NumOne = Convert.ToInt64(InputNum1.Value);
		}

		private void InputNum2_ValueChanged(object sender, EventArgs e)
		{
			NumTwo = Convert.ToInt64(InputNum2.Value);
		}
	}
}
