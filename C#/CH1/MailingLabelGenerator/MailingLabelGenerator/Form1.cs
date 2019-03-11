using System;
using System.Windows.Forms;

/*
	Author       : Evan Young
	Comment      : Creates a mailing label
	Date Created : 2018-08-17
	Date Updated : 2018-08-17
*/

namespace MailingLabelGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool CheckInvalidValues(string FirstName, string LastName, string Address, string City, string ZIP, int State)
		{
			string MessageCap = "";
			string MessageBody = "";
			if (ZIP.Length != 5)
			{
				MessageBody = "The ZIP code you have entered is invalid.";
				MessageCap = "Invalid ZIP Code";
			}
			if (ZIP == "")
			{
				MessageBody = "Your ZIP code cannot be blank.";
				MessageCap = "Invalid ZIP Code";
			}
			if (State < 0)
			{
				MessageBody = "The state you have selected is invalid.";
				MessageCap = "Invalid State";
			}
			if (City == "")
			{
				MessageBody = "Your city cannot be blank.";
				MessageCap = "Invalid City";
			}
			if (Address == "")
			{
				MessageBody = "Your address cannot be blank.";
				MessageCap = "Invalid Address";
			}
			if (LastName == "")
			{
				MessageBody = "Your last name cannot be blank.";
				MessageCap = "Invalid Last Name";
			}
			if (FirstName == "")
			{
				MessageBody = "Your first name cannot be blank.";
				MessageCap = "Invalid First Name";
			}

			if (MessageBody != "")
			{
				MessageBox.Show(MessageBody, MessageCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return true;
			}
			return false;
		}

		private void ButtonSubmit_Click(object sender, EventArgs e)
		{
			string FirstName = InputFirstName.Text;
			string LastName = InputLastName.Text;
			string Address = InputAddress.Text;
			string City = InputCity.Text;
			string ZIP = InputZIP.Text;
			string State = InputState.Text;
			int SelState = InputState.SelectedIndex;
			bool HasError = CheckInvalidValues(FirstName, LastName, Address, City, ZIP, SelState);

			if (!HasError)
			{
				OutputLabel.Lines = new string[] {
				$"{FirstName} {LastName}",
				Address,
				$"{City}, {State}  {ZIP}"
			};
			}
		}
	}
}