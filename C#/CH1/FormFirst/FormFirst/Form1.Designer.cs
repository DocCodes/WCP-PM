namespace FormFirst
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
			this.InputName = new System.Windows.Forms.TextBox();
			this.LabelOne = new System.Windows.Forms.Label();
			this.ButtonName = new System.Windows.Forms.Button();
			this.OutputName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// InputName
			// 
			this.InputName.Location = new System.Drawing.Point(15, 25);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(145, 20);
			this.InputName.TabIndex = 0;
			// 
			// LabelOne
			// 
			this.LabelOne.AutoSize = true;
			this.LabelOne.Location = new System.Drawing.Point(12, 9);
			this.LabelOne.Name = "LabelOne";
			this.LabelOne.Size = new System.Drawing.Size(84, 13);
			this.LabelOne.TabIndex = 1;
			this.LabelOne.Text = "Enter your name";
			// 
			// ButtonName
			// 
			this.ButtonName.Location = new System.Drawing.Point(15, 51);
			this.ButtonName.Name = "ButtonName";
			this.ButtonName.Size = new System.Drawing.Size(145, 23);
			this.ButtonName.TabIndex = 2;
			this.ButtonName.Text = "Enter";
			this.ButtonName.UseVisualStyleBackColor = true;
			this.ButtonName.Click += new System.EventHandler(this.ButtonName_Click);
			// 
			// OutputName
			// 
			this.OutputName.AutoSize = true;
			this.OutputName.Location = new System.Drawing.Point(12, 77);
			this.OutputName.Name = "OutputName";
			this.OutputName.Size = new System.Drawing.Size(0, 13);
			this.OutputName.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(172, 100);
			this.Controls.Add(this.OutputName);
			this.Controls.Add(this.ButtonName);
			this.Controls.Add(this.LabelOne);
			this.Controls.Add(this.InputName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputName;
		private System.Windows.Forms.Label LabelOne;
		private System.Windows.Forms.Button ButtonName;
		private System.Windows.Forms.Label OutputName;
	}
}

