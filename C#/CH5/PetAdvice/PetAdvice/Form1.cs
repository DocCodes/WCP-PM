using System;
using System.Windows.Forms;

namespace PetAdvice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSuggest_Click(object sender, EventArgs e)
		{
			Owner petOwner;
			if (pickerResidence.SelectedIndex < 0)
			{
				MessageBox.Show($"The residence which you have entered is invalid.", "Invalid Residence", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			petOwner = new Owner(pickerResidence.SelectedItem.ToString(), (int)inputHours.Value);
			outputAnimal.Text = petOwner.Suggestion;
		}
	}

	public class Owner
	{
		public Owner(string residence, int hoursHome)
		{
			Residence = residence;
			HoursHome = hoursHome;
		}

		public string Residence { get; set; }
		private char ResidenceCode
		{
			get
			{
				switch (Residence)
				{
					case "House":
						return 'H';
					case "Apartment":
						return 'A';
					case "Dormitory":
						return 'D';
					default:
						return 'U';
				}
			}
		}
		public int HoursHome { get; set; }
		public string Suggestion
		{
			get
			{
				switch (ResidenceCode)
				{
					case 'H':
						if (HoursHome >= 18)
						{
							return "Pot Belly Pig";
						}
						else if (HoursHome >= 10)
						{
							return "Dog";
						}
						else
						{
							return "Snake";
						}
					case 'A':
						if (HoursHome >= 10)
						{
							return "Cat";
						}
						else
						{
							return "Hamster";
						}
					case 'D':
						if (HoursHome >= 6)
						{
							return "Fish";
						}
						else
						{
							return "Ant";
						}
					default:
						return "None";
				}
			}
		}
	}
}
