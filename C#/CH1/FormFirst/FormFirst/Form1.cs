using System;
using System.Windows.Forms;

namespace FormFirst
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonName_Click(object sender, EventArgs e)
		{
			OutputName.Text = $"Hello there, {InputName.Text}!";
			OutputName.Font = new System.Drawing.Font(OutputName.Font.FontFamily, (float)(OutputName.Font.Size * 1.1));
		}
	}
}
