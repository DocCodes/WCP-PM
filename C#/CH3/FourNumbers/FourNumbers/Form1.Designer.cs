namespace FourNumbers
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
			this.input1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.labelRange1 = new System.Windows.Forms.Label();
			this.labelRange2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.input2 = new System.Windows.Forms.NumericUpDown();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.labelRange3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.input3 = new System.Windows.Forms.NumericUpDown();
			this.labelRange4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.input4 = new System.Windows.Forms.NumericUpDown();
			this.labelRange5 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.input5 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.input5)).BeginInit();
			this.SuspendLayout();
			// 
			// input1
			// 
			this.input1.Location = new System.Drawing.Point(15, 25);
			this.input1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.input1.Name = "input1";
			this.input1.Size = new System.Drawing.Size(120, 20);
			this.input1.TabIndex = 1;
			this.input1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Number 1";
			// 
			// labelRange1
			// 
			this.labelRange1.AutoSize = true;
			this.labelRange1.Location = new System.Drawing.Point(71, 9);
			this.labelRange1.Name = "labelRange1";
			this.labelRange1.Size = new System.Drawing.Size(40, 13);
			this.labelRange1.TabIndex = 2;
			this.labelRange1.Text = "1 - 100";
			// 
			// labelRange2
			// 
			this.labelRange2.AutoSize = true;
			this.labelRange2.Location = new System.Drawing.Point(71, 48);
			this.labelRange2.Name = "labelRange2";
			this.labelRange2.Size = new System.Drawing.Size(28, 13);
			this.labelRange2.TabIndex = 5;
			this.labelRange2.Text = "? - ?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Number 2";
			// 
			// input2
			// 
			this.input2.Enabled = false;
			this.input2.Location = new System.Drawing.Point(15, 64);
			this.input2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.input2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.input2.Name = "input2";
			this.input2.Size = new System.Drawing.Size(120, 20);
			this.input2.TabIndex = 2;
			this.input2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(15, 207);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(120, 23);
			this.buttonSubmit.TabIndex = 5;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// labelRange3
			// 
			this.labelRange3.AutoSize = true;
			this.labelRange3.Location = new System.Drawing.Point(74, 87);
			this.labelRange3.Name = "labelRange3";
			this.labelRange3.Size = new System.Drawing.Size(28, 13);
			this.labelRange3.TabIndex = 9;
			this.labelRange3.Text = "? - ?";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Number 3";
			// 
			// input3
			// 
			this.input3.Enabled = false;
			this.input3.Location = new System.Drawing.Point(15, 103);
			this.input3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.input3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.input3.Name = "input3";
			this.input3.Size = new System.Drawing.Size(120, 20);
			this.input3.TabIndex = 3;
			this.input3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// labelRange4
			// 
			this.labelRange4.AutoSize = true;
			this.labelRange4.Location = new System.Drawing.Point(74, 126);
			this.labelRange4.Name = "labelRange4";
			this.labelRange4.Size = new System.Drawing.Size(28, 13);
			this.labelRange4.TabIndex = 12;
			this.labelRange4.Text = "? - ?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Number 4";
			// 
			// input4
			// 
			this.input4.Enabled = false;
			this.input4.Location = new System.Drawing.Point(15, 142);
			this.input4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.input4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.input4.Name = "input4";
			this.input4.Size = new System.Drawing.Size(120, 20);
			this.input4.TabIndex = 4;
			this.input4.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// labelRange5
			// 
			this.labelRange5.AutoSize = true;
			this.labelRange5.Location = new System.Drawing.Point(74, 165);
			this.labelRange5.Name = "labelRange5";
			this.labelRange5.Size = new System.Drawing.Size(28, 13);
			this.labelRange5.TabIndex = 15;
			this.labelRange5.Text = "? - ?";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Number 5";
			// 
			// input5
			// 
			this.input5.Enabled = false;
			this.input5.Location = new System.Drawing.Point(15, 181);
			this.input5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.input5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.input5.Name = "input5";
			this.input5.Size = new System.Drawing.Size(120, 20);
			this.input5.TabIndex = 13;
			this.input5.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(152, 239);
			this.Controls.Add(this.labelRange5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.input5);
			this.Controls.Add(this.labelRange4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.input4);
			this.Controls.Add(this.labelRange3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.input3);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.labelRange2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.input2);
			this.Controls.Add(this.labelRange1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.input1);
			this.Name = "Form1";
			this.Text = "Four Numbers";
			((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.input5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown input1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelRange1;
		private System.Windows.Forms.Label labelRange2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown input2;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Label labelRange3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown input3;
		private System.Windows.Forms.Label labelRange4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown input4;
		private System.Windows.Forms.Label labelRange5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown input5;
	}
}

