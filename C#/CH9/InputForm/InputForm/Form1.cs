using System;
using System.Windows.Forms;

namespace InputForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void clearInputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inpName.Text = "";
			inpEmail.Text = "";
			inpPhone.Text = "";
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Input Form Version 2018-12-11 Evan Elias Young", "Input Form");
		}

		private void processInputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Name: {inpName.Text}\nEmail: {inpEmail.Text}\nPhone: {inpPhone.Text}", "Input Form");
		}
	}
}
