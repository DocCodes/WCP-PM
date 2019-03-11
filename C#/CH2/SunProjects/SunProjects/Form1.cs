using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : Calculates pay rate and other things for Sun Projects
	Date Created : 2018-08-21
	Date Updated : 2018-08-21
*/

namespace SunProjects
{
	public partial class Form1 : Form
	{
		const double FED_TAX = 0.20;
		const double FICA_TAX = 0.08;
		const double STATE_TAX = 0.025;

		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonSubmit_Click(object sender, EventArgs e)
		{
			double WorkHours = Convert.ToDouble(InputHours.Value); ;
			double PayRate = Convert.ToDouble(InputPay.Value);
			double GrossPay = WorkHours * PayRate;
			double FederalTax = GrossPay * FED_TAX;
			double SocialTax = GrossPay * FICA_TAX;
			double StateTax = GrossPay * STATE_TAX;
			double NetPay = GrossPay - FederalTax - SocialTax - StateTax;

			OutputGross.Value = Convert.ToDecimal(GrossPay);
			OutputFederal.Value = Convert.ToDecimal(FederalTax);
			OutputFICA.Value = Convert.ToDecimal(SocialTax);
			OutputState.Value = Convert.ToDecimal(StateTax);
			OutputNet.Value = Convert.ToDecimal(NetPay);
		}
	}
}
