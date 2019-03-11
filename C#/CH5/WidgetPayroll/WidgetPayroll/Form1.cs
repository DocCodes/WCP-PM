using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : Widget Payroll calculator
	Date Created : 2018-09-06
	Date Updated : 2018-09-06
*/

namespace WidgetPayroll
{
	public partial class Form1 : Form
	{
		public Pay workerPay = new Pay(7.14M, 40);

		public Form1()
		{
			InitializeComponent();
		}

		private void UpdateDisplay()
		{
			outputGrossPay.Value = workerPay.Gross;
		}

		private void inputPayRate_ValueChanged(object sender, EventArgs e)
		{
			decimal inpVal = inputPayRate.Value;
			decimal[] validRates =
			{
				7.14M, 10.25M, 12.88M
			};

			if (Array.IndexOf(validRates, inpVal) != -1)
			{
				workerPay.Rate = inpVal;
			}
			else
			{
				MessageBox.Show($"The entered value \"{inpVal:C2}\" is not valid. It must be one of {string.Join(", ", validRates)}", "Invalid Pay Rate");
				inputPayRate.Value = workerPay.Rate;
			}
			UpdateDisplay();
		}

		private void inputHours_ValueChanged(object sender, EventArgs e)
		{
			int inpVal = (int)inputHours.Value;
			int[] validHours =
			{
				40, 45, 50
			};

			if (Array.IndexOf(validHours, inpVal) != -1)
			{
				workerPay.TotalHours = inpVal;
			}
			else
			{
				
				MessageBox.Show($"The entered value \"{inpVal:N0}\" is not valid. It must be one of {string.Join(", ", validHours)}.", "Invalid Hours Worked");
				inputHours.Value = workerPay.TotalHours;
			}
			UpdateDisplay();
		}
	}

	public class Pay
	{
		public Pay(decimal rate, int hours, int overtimeDivide = 40, decimal overtimeRate = 2.00M)
		{
			Rate = rate;
			TotalHours = hours;
			OvertimeDivide = overtimeDivide;
			OvertimeRate = overtimeRate;
		}

		public decimal Rate { get; set; }
		public int TotalHours { get; set; }
		public int Hours
		{
			get
			{
				return Math.Min(TotalHours, OvertimeDivide);
			}
		}
		public int OvertimeDivide { get; set; }
		public int OvertimeHours
		{
			get
			{
				return TotalHours > OvertimeDivide ? TotalHours - OvertimeDivide : 0;
			}
		}
		public decimal OvertimeRate { get; set; }
		public decimal Gross
		{
			get
			{
				return (Hours * Rate) + (OvertimeHours * Rate * OvertimeRate);
			}
		}
	}
}
