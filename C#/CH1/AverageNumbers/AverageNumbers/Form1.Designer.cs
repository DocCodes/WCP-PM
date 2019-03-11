namespace AverageNumbers
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
			this.InputNum1 = new System.Windows.Forms.NumericUpDown();
			this.InputNum2 = new System.Windows.Forms.NumericUpDown();
			this.InputNum4 = new System.Windows.Forms.NumericUpDown();
			this.InputNum3 = new System.Windows.Forms.NumericUpDown();
			this.InputNum5 = new System.Windows.Forms.NumericUpDown();
			this.OutputAverage = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.InputNum1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum5)).BeginInit();
			this.SuspendLayout();
			// 
			// InputNum1
			// 
			this.InputNum1.Location = new System.Drawing.Point(66, 56);
			this.InputNum1.Name = "InputNum1";
			this.InputNum1.Size = new System.Drawing.Size(120, 20);
			this.InputNum1.TabIndex = 0;
			this.InputNum1.ValueChanged += new System.EventHandler(this.InputNum1_ValueChanged);
			// 
			// InputNum2
			// 
			this.InputNum2.Location = new System.Drawing.Point(66, 82);
			this.InputNum2.Name = "InputNum2";
			this.InputNum2.Size = new System.Drawing.Size(120, 20);
			this.InputNum2.TabIndex = 1;
			this.InputNum2.ValueChanged += new System.EventHandler(this.InputNum2_ValueChanged);
			// 
			// InputNum4
			// 
			this.InputNum4.Location = new System.Drawing.Point(66, 134);
			this.InputNum4.Name = "InputNum4";
			this.InputNum4.Size = new System.Drawing.Size(120, 20);
			this.InputNum4.TabIndex = 3;
			this.InputNum4.ValueChanged += new System.EventHandler(this.InputNum4_ValueChanged);
			// 
			// InputNum3
			// 
			this.InputNum3.Location = new System.Drawing.Point(66, 108);
			this.InputNum3.Name = "InputNum3";
			this.InputNum3.Size = new System.Drawing.Size(120, 20);
			this.InputNum3.TabIndex = 2;
			this.InputNum3.ValueChanged += new System.EventHandler(this.InputNum3_ValueChanged);
			// 
			// InputNum5
			// 
			this.InputNum5.Location = new System.Drawing.Point(66, 160);
			this.InputNum5.Name = "InputNum5";
			this.InputNum5.Size = new System.Drawing.Size(120, 20);
			this.InputNum5.TabIndex = 4;
			this.InputNum5.ValueChanged += new System.EventHandler(this.InputNum5_ValueChanged);
			// 
			// OutputAverage
			// 
			this.OutputAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputAverage.Location = new System.Drawing.Point(192, 56);
			this.OutputAverage.Name = "OutputAverage";
			this.OutputAverage.Size = new System.Drawing.Size(124, 124);
			this.OutputAverage.TabIndex = 5;
			this.OutputAverage.Text = "0";
			this.OutputAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Number 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Number 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Number 3";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Number 4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Number 5";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(192, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 40);
			this.label6.TabIndex = 11;
			this.label6.Text = "Average";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 40);
			this.label7.TabIndex = 12;
			this.label7.Text = "Numbers To Average";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 193);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OutputAverage);
			this.Controls.Add(this.InputNum5);
			this.Controls.Add(this.InputNum4);
			this.Controls.Add(this.InputNum3);
			this.Controls.Add(this.InputNum2);
			this.Controls.Add(this.InputNum1);
			this.Name = "Form1";
			this.Text = "Average";
			((System.ComponentModel.ISupportInitialize)(this.InputNum1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown InputNum1;
		private System.Windows.Forms.NumericUpDown InputNum2;
		private System.Windows.Forms.NumericUpDown InputNum4;
		private System.Windows.Forms.NumericUpDown InputNum3;
		private System.Windows.Forms.NumericUpDown InputNum5;
		private System.Windows.Forms.Label OutputAverage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

