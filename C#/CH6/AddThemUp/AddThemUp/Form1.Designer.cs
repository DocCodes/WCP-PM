namespace AddThemUp
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
			this.label2 = new System.Windows.Forms.Label();
			this.inputStart = new System.Windows.Forms.NumericUpDown();
			this.inputEnd = new System.Windows.Forms.NumericUpDown();
			this.buttonRun = new System.Windows.Forms.Button();
			this.outputSum = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.outputSum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "End Number";
			// 
			// inputStart
			// 
			this.inputStart.Location = new System.Drawing.Point(87, 7);
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
			this.inputStart.Size = new System.Drawing.Size(134, 20);
			this.inputStart.TabIndex = 2;
			// 
			// inputEnd
			// 
			this.inputEnd.Location = new System.Drawing.Point(87, 33);
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
			this.inputEnd.Size = new System.Drawing.Size(134, 20);
			this.inputEnd.TabIndex = 3;
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(77, 134);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(75, 23);
			this.buttonRun.TabIndex = 4;
			this.buttonRun.Text = "Run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// outputSum
			// 
			this.outputSum.Location = new System.Drawing.Point(12, 99);
			this.outputSum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.outputSum.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
			this.outputSum.Name = "outputSum";
			this.outputSum.Size = new System.Drawing.Size(209, 20);
			this.outputSum.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Summed";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 169);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.outputSum);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.inputEnd);
			this.Controls.Add(this.inputStart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "AddThemUp";
			((System.ComponentModel.ISupportInitialize)(this.inputStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.outputSum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown inputStart;
		private System.Windows.Forms.NumericUpDown inputEnd;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.NumericUpDown outputSum;
		private System.Windows.Forms.Label label3;
	}
}

