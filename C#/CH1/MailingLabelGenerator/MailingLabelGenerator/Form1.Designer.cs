namespace MailingLabelGenerator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.InputFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.InputAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.InputLastName = new System.Windows.Forms.TextBox();
			this.InputState = new System.Windows.Forms.ComboBox();
			this.InputCity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.InputZIP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.OutputLabel = new System.Windows.Forms.TextBox();
			this.ButtonSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// InputFirstName
			// 
			this.InputFirstName.Location = new System.Drawing.Point(15, 25);
			this.InputFirstName.Name = "InputFirstName";
			this.InputFirstName.Size = new System.Drawing.Size(115, 20);
			this.InputFirstName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// InputAddress
			// 
			this.InputAddress.Location = new System.Drawing.Point(15, 64);
			this.InputAddress.Name = "InputAddress";
			this.InputAddress.Size = new System.Drawing.Size(236, 20);
			this.InputAddress.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Address";
			// 
			// InputLastName
			// 
			this.InputLastName.Location = new System.Drawing.Point(136, 25);
			this.InputLastName.Name = "InputLastName";
			this.InputLastName.Size = new System.Drawing.Size(115, 20);
			this.InputLastName.TabIndex = 2;
			// 
			// InputState
			// 
			this.InputState.FormattingEnabled = true;
			this.InputState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
			this.InputState.Location = new System.Drawing.Point(99, 103);
			this.InputState.Name = "InputState";
			this.InputState.Size = new System.Drawing.Size(65, 21);
			this.InputState.TabIndex = 5;
			// 
			// InputCity
			// 
			this.InputCity.Location = new System.Drawing.Point(15, 103);
			this.InputCity.Name = "InputCity";
			this.InputCity.Size = new System.Drawing.Size(78, 20);
			this.InputCity.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "City";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(170, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "ZIP";
			// 
			// InputZIP
			// 
			this.InputZIP.Location = new System.Drawing.Point(170, 103);
			this.InputZIP.Name = "InputZIP";
			this.InputZIP.Size = new System.Drawing.Size(81, 20);
			this.InputZIP.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(99, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "State";
			// 
			// OutputLabel
			// 
			this.OutputLabel.Enabled = false;
			this.OutputLabel.Location = new System.Drawing.Point(15, 157);
			this.OutputLabel.Multiline = true;
			this.OutputLabel.Name = "OutputLabel";
			this.OutputLabel.Size = new System.Drawing.Size(236, 93);
			this.OutputLabel.TabIndex = 15;
			// 
			// ButtonSubmit
			// 
			this.ButtonSubmit.Location = new System.Drawing.Point(99, 130);
			this.ButtonSubmit.Name = "ButtonSubmit";
			this.ButtonSubmit.Size = new System.Drawing.Size(65, 21);
			this.ButtonSubmit.TabIndex = 16;
			this.ButtonSubmit.Text = "Submit";
			this.ButtonSubmit.UseVisualStyleBackColor = true;
			this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 262);
			this.Controls.Add(this.ButtonSubmit);
			this.Controls.Add(this.OutputLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.InputZIP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.InputCity);
			this.Controls.Add(this.InputState);
			this.Controls.Add(this.InputLastName);
			this.Controls.Add(this.InputAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.InputFirstName);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox InputFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox InputAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox InputLastName;
		private System.Windows.Forms.ComboBox InputState;
		private System.Windows.Forms.TextBox InputCity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox InputZIP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox OutputLabel;
		private System.Windows.Forms.Button ButtonSubmit;
	}
}

