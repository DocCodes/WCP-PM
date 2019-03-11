namespace SunProjects
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
			this.InputName = new System.Windows.Forms.TextBox();
			this.InputHours = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.InputPay = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.ButtonSubmit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.OutputGross = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.OutputNet = new System.Windows.Forms.NumericUpDown();
			this.OutputState = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.OutputFederal = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.OutputFICA = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.InputHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputGross)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputNet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputState)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputFederal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputFICA)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// InputName
			// 
			this.InputName.Location = new System.Drawing.Point(15, 25);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(174, 20);
			this.InputName.TabIndex = 1;
			// 
			// InputHours
			// 
			this.InputHours.DecimalPlaces = 1;
			this.InputHours.Location = new System.Drawing.Point(15, 64);
			this.InputHours.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.InputHours.Name = "InputHours";
			this.InputHours.Size = new System.Drawing.Size(84, 20);
			this.InputHours.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hours";
			// 
			// InputPay
			// 
			this.InputPay.DecimalPlaces = 2;
			this.InputPay.Location = new System.Drawing.Point(105, 64);
			this.InputPay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPay.Minimum = new decimal(new int[] {
            770,
            0,
            0,
            131072});
			this.InputPay.Name = "InputPay";
			this.InputPay.Size = new System.Drawing.Size(84, 20);
			this.InputPay.TabIndex = 3;
			this.InputPay.Value = new decimal(new int[] {
            770,
            0,
            0,
            131072});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(102, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pay Rate";
			// 
			// ButtonSubmit
			// 
			this.ButtonSubmit.Location = new System.Drawing.Point(105, 178);
			this.ButtonSubmit.Name = "ButtonSubmit";
			this.ButtonSubmit.Size = new System.Drawing.Size(84, 23);
			this.ButtonSubmit.TabIndex = 9;
			this.ButtonSubmit.Text = "Calculate";
			this.ButtonSubmit.UseVisualStyleBackColor = true;
			this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Gross Pay";
			// 
			// OutputGross
			// 
			this.OutputGross.DecimalPlaces = 2;
			this.OutputGross.Enabled = false;
			this.OutputGross.Location = new System.Drawing.Point(15, 103);
			this.OutputGross.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.OutputGross.Name = "OutputGross";
			this.OutputGross.Size = new System.Drawing.Size(84, 20);
			this.OutputGross.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(102, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Net Pay";
			// 
			// OutputNet
			// 
			this.OutputNet.DecimalPlaces = 2;
			this.OutputNet.Enabled = false;
			this.OutputNet.Location = new System.Drawing.Point(105, 103);
			this.OutputNet.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.OutputNet.Name = "OutputNet";
			this.OutputNet.Size = new System.Drawing.Size(84, 20);
			this.OutputNet.TabIndex = 5;
			// 
			// OutputState
			// 
			this.OutputState.DecimalPlaces = 2;
			this.OutputState.Enabled = false;
			this.OutputState.Location = new System.Drawing.Point(105, 142);
			this.OutputState.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.OutputState.Name = "OutputState";
			this.OutputState.Size = new System.Drawing.Size(84, 20);
			this.OutputState.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(102, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "State Tax";
			// 
			// OutputFederal
			// 
			this.OutputFederal.DecimalPlaces = 2;
			this.OutputFederal.Enabled = false;
			this.OutputFederal.Location = new System.Drawing.Point(15, 142);
			this.OutputFederal.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.OutputFederal.Name = "OutputFederal";
			this.OutputFederal.Size = new System.Drawing.Size(84, 20);
			this.OutputFederal.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Federal Tax";
			// 
			// OutputFICA
			// 
			this.OutputFICA.DecimalPlaces = 2;
			this.OutputFICA.Enabled = false;
			this.OutputFICA.Location = new System.Drawing.Point(15, 181);
			this.OutputFICA.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.OutputFICA.Name = "OutputFICA";
			this.OutputFICA.Size = new System.Drawing.Size(84, 20);
			this.OutputFICA.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 165);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "FICA Tax";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(201, 212);
			this.Controls.Add(this.OutputFICA);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.OutputState);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.OutputFederal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.OutputNet);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.OutputGross);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ButtonSubmit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.InputPay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.InputHours);
			this.Controls.Add(this.InputName);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Sun Projects";
			((System.ComponentModel.ISupportInitialize)(this.InputHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputGross)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputNet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputState)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputFederal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OutputFICA)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox InputName;
		private System.Windows.Forms.NumericUpDown InputHours;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown InputPay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ButtonSubmit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown OutputGross;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown OutputNet;
		private System.Windows.Forms.NumericUpDown OutputState;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown OutputFederal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown OutputFICA;
		private System.Windows.Forms.Label label8;
	}
}

