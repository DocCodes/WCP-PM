using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowLoops
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			int inpStart = (int)inputStart.Value;
			int inpEnd = (int)inputEnd.Value;

			if (inpStart > inpEnd)
			{
				MessageBox.Show("The start number cannot be larger than the ending number.", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int[] lines = Enumerable.Range(inpStart, inpEnd + 1).ToArray();

			outputText.Lines = Array.ConvertAll(lines, item => item.ToString());
		}
	}
}