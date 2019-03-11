using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pizzaria
{
	public partial class Form1 : Form
	{

		const decimal PRICE_S = 9.95M;
		const decimal PRICE_M = 12.95M;
		const decimal PRICE_L = 15.95M;
		const decimal PRICE_SODA = 1.75M;
		const decimal PRICE_WINGS = 4.99M;
		const decimal PRICE_CHEESE = 3.99M;
		const decimal PRICE_GARLIC = 2.99M;

		public Form1()
		{
			InitializeComponent();
			TabEdits();
			SetFormPrices();
			SetFormDefaults();
		}

		private void SetFormPrices()
		{
			comboSize.Items[0] = $"Small (10\") – {PRICE_S:C2}";
			comboSize.Items[1] = $"Medium (14\") – {PRICE_M:C2}";
			comboSize.Items[2] = $"Large (16\") – {PRICE_L:C2}";

			lblSoda.Text = $"Soda – {PRICE_SODA:C2}";
			lblWings.Text = $"Hot Wings – {PRICE_WINGS:C2}";
			lblCheese.Text = $"Cheese Sticks – {PRICE_CHEESE:C2}";
			lblGarlic.Text = $"Garlic Sticks – {PRICE_GARLIC:C2}";
		}

		private void SetFormDefaults()
		{
			comboSize.SelectedIndex = 1;
			comboCrust.SelectedIndex = 0;
			comboSauce.SelectedIndex = 0;
			comboSpecialty.SelectedIndex = 0;

			numericSoda.Value = 0;
			numericWater.Value = 0;
			numericWings.Value = 0;
			numericCheese.Value = 0;
			numericGarlic.Value = 0;

			textName.Text = "";
			textAddress.Text = "";
			textEmail.Text = "";
			textPhone.Text = "555-555-5555";

			for (int i = 0; i < checkToppings.Items.Count; i++)
			{
				checkToppings.SetItemChecked(i, false);
			}
		}

		private void TabEdits()
		{
			Label tempLabel;

			foreach (TabPage tab in tabControl1.TabPages)
			{
				tempLabel = new Label();
				tempLabel.Text = Text;
				tempLabel.Font = new Font(Font.OriginalFontName, 12, FontStyle.Bold);
				tempLabel.Width = tab.Width;
				tempLabel.TextAlign = ContentAlignment.BottomCenter;

				tab.BackgroundImageLayout = ImageLayout.Center;
				tab.BackgroundImage = Properties.Resources.buscemi;
				tab.Controls.Add(tempLabel);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			SetFormDefaults();
			tabControl1.SelectTab(0);
		}

		private bool ValidateUserInput()
		{
			if (!Regex.IsMatch(textName.Text, @"^[A-z ]+$"))
			{
				MessageBox.Show("Invalid delivery name entered.", Text);
				return false;
			}
			if (!Regex.IsMatch(textAddress.Text, @"^[\w ]+$"))
			{
				MessageBox.Show("Invalid delivery address entered.", Text);
				return false;
			}
			if (!Regex.IsMatch(textEmail.Text, @"^\w+@\w+.\w+$"))
			{
				MessageBox.Show("Invalid email address entered.", Text);
				return false;
			}
			if (!Regex.IsMatch(textPhone.Text, @"^\d{3}\-\d{3}\-\d{4}$"))
			{
				MessageBox.Show("Invalid phone number entered.", Text);
				return false;
			}
			if (textPhone.Text == "555-555-5555")
			{
				MessageBox.Show("Invalid phone number entered.", Text);
				return false;
			}
			return true;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (!ValidateUserInput()) { return; }
			List<string> lines = new List<string>();
			decimal totalCost, pizzaCost, toppingCost, sideCost, drinkCost;
			pizzaCost = new decimal[] { PRICE_S, PRICE_M, PRICE_L }[comboSize.SelectedIndex];
			toppingCost = checkToppings.CheckedItems.Count * 1.50M;
			sideCost = numericWings.Value * PRICE_WINGS + numericCheese.Value * PRICE_CHEESE + numericGarlic.Value * PRICE_GARLIC;
			drinkCost = numericSoda.Value * PRICE_SODA;
			totalCost = pizzaCost + toppingCost + sideCost + drinkCost;

			lines.Add($"Order Summary – {totalCost:C2}");
			lines.Add(new string('-', 60));
			lines.Add($"Pizza – {pizzaCost:C2}");
			lines.Add(comboSize.Items[comboSize.SelectedIndex].ToString());
			lines.Add(comboCrust.Items[comboCrust.SelectedIndex].ToString());
			lines.Add(comboSauce.Items[comboSauce.SelectedIndex].ToString());
			lines.Add(comboSpecialty.Items[comboSpecialty.SelectedIndex].ToString());
			lines.Add("");

			lines.Add(new string('-', 60));
			lines.Add($"Toppings – {toppingCost:C2}");
			foreach (var chk in checkToppings.CheckedItems)
			{
				lines.Add(chk.ToString());
			}
			lines.Add("");

			lines.Add(new string('-', 60));
			lines.Add($"Sides – {sideCost:C2}");
			lines.Add($"Hot Wings – {numericWings.Value}");
			lines.Add($"Cheese Sticks – {numericCheese.Value}");
			lines.Add($"Garlic Sticks – {numericGarlic.Value}");
			lines.Add("");

			lines.Add(new string('-', 60));
			lines.Add($"Beverages – {drinkCost:C2}");
			lines.Add($"Soda – {numericSoda.Value}");
			lines.Add($"Water – {numericWater.Value}");
			lines.Add("");

			lines.Add(new string('-', 60));
			lines.Add($"Delivery");
			lines.Add($"Name – {textName.Text}");
			lines.Add($"Address – {textAddress.Text}");
			lines.Add($"Email – {textEmail.Text}");
			lines.Add($"Phone – {textPhone.Text}");
			lines.Add("");

			lines.Add(new string('-', 60));
			lines.Add($"Thank you for ordering from {Text}");

			MessageBox.Show(string.Join(Environment.NewLine, lines), Text);
		}
	}
}
