using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : A calculator
	Date Created : 2018-08-20
	Date Updated : 2018-08-20
*/

namespace Calculator
{
	public partial class Form1 : Form
	{
		public long NumOne = 0;
		public long NumTwo = 0;
		public bool NumOneSet = false;
		public bool NumTwoSet = false;
		public string NumRunner = "";
		public char CurOpt = '+';
		public long Answer = 0;

		public Form1()
		{
			InitializeComponent();
			UpdateDisplay();
		}

		private void UpdateDisplay()
		{
			string OutputText = "";
			switch (CurOpt)
			{
				case '+':
					Answer = NumOne + NumTwo;
					break;
				case '-':
					Answer = NumOne - NumTwo;
					break;
				case '*':
					Answer = NumOne * NumTwo;
					break;
				case '/':
					Answer = NumOne / NumTwo;
					break;
			}
			if (NumOneSet)
			{
				OutputText += NumOne.ToString();
			}
			else if (NumRunner != "")
			{
				OutputText += NumRunner;
			}
			else
			{
				OutputText += 0;
			}
			OutputText += $" {CurOpt} ";
			if (NumTwoSet)
			{
				OutputText += NumTwo.ToString();
			}
			else if (NumOneSet && NumRunner != "")
			{
				OutputText += NumRunner;
			}
			else
			{
				OutputText += 0;
			}
			OutputText += $" = {Answer}";

			OutputAnswer.Text = OutputText;
		}
		public void NumberButtonClick(short Number)
		{
			NumRunner += Number.ToString();
			UpdateDisplay();
		}
		public void OptButtonClick(char Opt)
		{
			CurOpt = Opt;
			CommitNumRunner();
			UpdateDisplay();
		}
		private void ButtonClr_Click(object sender, EventArgs e)
		{
			NumOne = 0;
			NumTwo = 0;
			NumOneSet = false;
			NumTwoSet = false;
			NumRunner = "";
			CurOpt = '+';
			Answer = 0;
			UpdateDisplay();
		}
		public void CommitNumRunner()
		{
			if (NumRunner != "")
			{
				if (!NumOneSet)
				{
					NumOne = Convert.ToInt16(NumRunner);
					NumOneSet = true;
				}
				else if (!NumTwoSet)
				{
					NumTwo = Convert.ToInt16(NumRunner);
					NumTwoSet = true;
				}
			}
			NumRunner = "";
			UpdateDisplay();
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			NumberButtonClick(0);
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			NumberButtonClick(1);
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			NumberButtonClick(2);
		}
		private void Button3_Click(object sender, EventArgs e)
		{
			NumberButtonClick(3);
		}
		private void Button4_Click(object sender, EventArgs e)
		{
			NumberButtonClick(4);
		}
		private void Button5_Click(object sender, EventArgs e)
		{
			NumberButtonClick(5);
		}
		private void Button6_Click(object sender, EventArgs e)
		{
			NumberButtonClick(6);
		}
		private void Button7_Click(object sender, EventArgs e)
		{
			NumberButtonClick(7);
		}
		private void Button8_Click(object sender, EventArgs e)
		{
			NumberButtonClick(8);
		}
		private void Button9_Click(object sender, EventArgs e)
		{
			NumberButtonClick(9);
		}
		private void ButtonDiv_Click(object sender, EventArgs e)
		{
			OptButtonClick('/');
		}
		private void ButtonMult_Click(object sender, EventArgs e)
		{
			OptButtonClick('*');
		}
		private void ButtonSub_Click(object sender, EventArgs e)
		{
			OptButtonClick('-');
		}
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			OptButtonClick('+');
		}

		private void ButtonEnt_Click(object sender, EventArgs e)
		{
			CommitNumRunner();
		}
	}
}
