namespace SimpleCalculator
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
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonSub = new System.Windows.Forms.Button();
			this.ButtonDiv = new System.Windows.Forms.Button();
			this.ButtonMult = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.OutputBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.InputNum1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum2)).BeginInit();
			this.SuspendLayout();
			// 
			// InputNum1
			// 
			this.InputNum1.Location = new System.Drawing.Point(71, 7);
			this.InputNum1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputNum1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
			this.InputNum1.Name = "InputNum1";
			this.InputNum1.Size = new System.Drawing.Size(120, 20);
			this.InputNum1.TabIndex = 0;
			this.InputNum1.ThousandsSeparator = true;
			this.InputNum1.ValueChanged += new System.EventHandler(this.InputNum1_ValueChanged);
			// 
			// InputNum2
			// 
			this.InputNum2.Location = new System.Drawing.Point(71, 33);
			this.InputNum2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputNum2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
			this.InputNum2.Name = "InputNum2";
			this.InputNum2.Size = new System.Drawing.Size(120, 20);
			this.InputNum2.TabIndex = 1;
			this.InputNum2.ThousandsSeparator = true;
			this.InputNum2.ValueChanged += new System.EventHandler(this.InputNum2_ValueChanged);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAdd.Location = new System.Drawing.Point(71, 59);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(53, 53);
			this.ButtonAdd.TabIndex = 2;
			this.ButtonAdd.Text = "+";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ButtonSub
			// 
			this.ButtonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSub.Location = new System.Drawing.Point(138, 59);
			this.ButtonSub.Name = "ButtonSub";
			this.ButtonSub.Size = new System.Drawing.Size(53, 53);
			this.ButtonSub.TabIndex = 3;
			this.ButtonSub.Text = "-";
			this.ButtonSub.UseVisualStyleBackColor = true;
			this.ButtonSub.Click += new System.EventHandler(this.ButtonSub_Click);
			// 
			// ButtonDiv
			// 
			this.ButtonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDiv.Location = new System.Drawing.Point(138, 118);
			this.ButtonDiv.Name = "ButtonDiv";
			this.ButtonDiv.Size = new System.Drawing.Size(53, 53);
			this.ButtonDiv.TabIndex = 5;
			this.ButtonDiv.Text = "÷";
			this.ButtonDiv.UseVisualStyleBackColor = true;
			this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
			// 
			// ButtonMult
			// 
			this.ButtonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMult.Location = new System.Drawing.Point(71, 118);
			this.ButtonMult.Name = "ButtonMult";
			this.ButtonMult.Size = new System.Drawing.Size(53, 53);
			this.ButtonMult.TabIndex = 4;
			this.ButtonMult.Text = "x";
			this.ButtonMult.UseVisualStyleBackColor = true;
			this.ButtonMult.Click += new System.EventHandler(this.ButtonMult_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Number 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Number 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Operand";
			// 
			// OutputBox
			// 
			this.OutputBox.Enabled = false;
			this.OutputBox.Location = new System.Drawing.Point(71, 177);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.Size = new System.Drawing.Size(120, 20);
			this.OutputBox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Answer";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 211);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OutputBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonDiv);
			this.Controls.Add(this.ButtonMult);
			this.Controls.Add(this.ButtonSub);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.InputNum2);
			this.Controls.Add(this.InputNum1);
			this.Name = "Form1";
			this.Text = "Calculator";
			((System.ComponentModel.ISupportInitialize)(this.InputNum1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputNum2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown InputNum1;
		private System.Windows.Forms.NumericUpDown InputNum2;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Button ButtonSub;
		private System.Windows.Forms.Button ButtonDiv;
		private System.Windows.Forms.Button ButtonMult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox OutputBox;
	}
}

