namespace WidgetPayroll
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
			this.inputPayRate = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.inputHours = new System.Windows.Forms.NumericUpDown();
			this.outputGrossPay = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputPayRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.outputGrossPay)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pay Rate";
			// 
			// inputPayRate
			// 
			this.inputPayRate.DecimalPlaces = 2;
			this.inputPayRate.Location = new System.Drawing.Point(12, 25);
			this.inputPayRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.inputPayRate.Name = "inputPayRate";
			this.inputPayRate.Size = new System.Drawing.Size(106, 20);
			this.inputPayRate.TabIndex = 1;
			this.inputPayRate.Value = new decimal(new int[] {
            714,
            0,
            0,
            131072});
			this.inputPayRate.ValueChanged += new System.EventHandler(this.inputPayRate_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Hours Worked";
			// 
			// inputHours
			// 
			this.inputHours.Location = new System.Drawing.Point(12, 64);
			this.inputHours.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.inputHours.Name = "inputHours";
			this.inputHours.Size = new System.Drawing.Size(106, 20);
			this.inputHours.TabIndex = 3;
			this.inputHours.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.inputHours.ValueChanged += new System.EventHandler(this.inputHours_ValueChanged);
			// 
			// outputGrossPay
			// 
			this.outputGrossPay.DecimalPlaces = 2;
			this.outputGrossPay.Enabled = false;
			this.outputGrossPay.Location = new System.Drawing.Point(12, 103);
			this.outputGrossPay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.outputGrossPay.Name = "outputGrossPay";
			this.outputGrossPay.Size = new System.Drawing.Size(106, 20);
			this.outputGrossPay.TabIndex = 5;
			this.outputGrossPay.ThousandsSeparator = true;
			this.outputGrossPay.Value = new decimal(new int[] {
            2856,
            0,
            0,
            65536});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Gross Pay";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(130, 141);
			this.Controls.Add(this.outputGrossPay);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputHours);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputPayRate);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.inputPayRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.outputGrossPay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown inputPayRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown inputHours;
		private System.Windows.Forms.NumericUpDown outputGrossPay;
		private System.Windows.Forms.Label label3;
	}
}

