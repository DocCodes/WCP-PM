using System;
using System.Windows.Forms;

namespace SkiSign
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void processInputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string output = "";
			foreach (object ev in checkListItems.CheckedItems)
			{
				output += $"{ev.ToString()}\n";
			}
			MessageBox.Show(output, "Items Needed");
		}

		private void clearInputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < checkListItems.Items.Count; i++)
			{
				checkListItems.SetItemChecked(i, false);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
