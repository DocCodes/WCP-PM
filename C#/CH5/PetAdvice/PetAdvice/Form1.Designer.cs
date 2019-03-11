namespace PetAdvice
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
			this.pickerResidence = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.inputHours = new System.Windows.Forms.NumericUpDown();
			this.buttonSuggest = new System.Windows.Forms.Button();
			this.outputAnimal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputHours)).BeginInit();
			this.SuspendLayout();
			// 
			// pickerResidence
			// 
			this.pickerResidence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.pickerResidence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.pickerResidence.FormattingEnabled = true;
			this.pickerResidence.Items.AddRange(new object[] {
            "House",
            "Apartment",
            "Dormitory"});
			this.pickerResidence.Location = new System.Drawing.Point(15, 25);
			this.pickerResidence.MaxDropDownItems = 3;
			this.pickerResidence.Name = "pickerResidence";
			this.pickerResidence.Size = new System.Drawing.Size(134, 21);
			this.pickerResidence.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Residence";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Hours Home";
			// 
			// inputHours
			// 
			this.inputHours.Location = new System.Drawing.Point(15, 65);
			this.inputHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.inputHours.Name = "inputHours";
			this.inputHours.Size = new System.Drawing.Size(134, 20);
			this.inputHours.TabIndex = 3;
			// 
			// buttonSuggest
			// 
			this.buttonSuggest.Location = new System.Drawing.Point(15, 91);
			this.buttonSuggest.Name = "buttonSuggest";
			this.buttonSuggest.Size = new System.Drawing.Size(134, 23);
			this.buttonSuggest.TabIndex = 4;
			this.buttonSuggest.Text = "Suggest A Pet";
			this.buttonSuggest.UseVisualStyleBackColor = true;
			this.buttonSuggest.Click += new System.EventHandler(this.buttonSuggest_Click);
			// 
			// outputAnimal
			// 
			this.outputAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputAnimal.Location = new System.Drawing.Point(12, 117);
			this.outputAnimal.Name = "outputAnimal";
			this.outputAnimal.Size = new System.Drawing.Size(137, 51);
			this.outputAnimal.TabIndex = 5;
			this.outputAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(161, 177);
			this.Controls.Add(this.outputAnimal);
			this.Controls.Add(this.buttonSuggest);
			this.Controls.Add(this.inputHours);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pickerResidence);
			this.Name = "Form1";
			this.Text = "Pets";
			((System.ComponentModel.ISupportInitialize)(this.inputHours)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox pickerResidence;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown inputHours;
		private System.Windows.Forms.Button buttonSuggest;
		private System.Windows.Forms.Label outputAnimal;
	}
}

