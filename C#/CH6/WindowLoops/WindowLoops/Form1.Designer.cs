namespace WindowLoops
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.inputStart = new System.Windows.Forms.NumericUpDown();
			this.inputEnd = new System.Windows.Forms.NumericUpDown();
			this.outputText = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.inputStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start Number";
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(15, 66);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(63, 23);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "End Number";
			// 
			// inputStart
			// 
			this.inputStart.Location = new System.Drawing.Point(98, 12);
			this.inputStart.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.inputStart.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
			this.inputStart.Name = "inputStart";
			this.inputStart.Size = new System.Drawing.Size(139, 20);
			this.inputStart.TabIndex = 3;
			// 
			// inputEnd
			// 
			this.inputEnd.Location = new System.Drawing.Point(98, 38);
			this.inputEnd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.inputEnd.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
			this.inputEnd.Name = "inputEnd";
			this.inputEnd.Size = new System.Drawing.Size(139, 20);
			this.inputEnd.TabIndex = 4;
			// 
			// outputText
			// 
			this.outputText.Location = new System.Drawing.Point(12, 95);
			this.outputText.Multiline = true;
			this.outputText.Name = "outputText";
			this.outputText.ReadOnly = true;
			this.outputText.Size = new System.Drawing.Size(225, 155);
			this.outputText.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 262);
			this.Controls.Add(this.outputText);
			this.Controls.Add(this.inputEnd);
			this.Controls.Add(this.inputStart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.inputStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEnd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown inputStart;
		private System.Windows.Forms.NumericUpDown inputEnd;
		private System.Windows.Forms.TextBox outputText;
	}
}

