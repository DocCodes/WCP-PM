namespace Pizzaria
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.checkToppings = new System.Windows.Forms.CheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboSpecialty = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboSauce = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboCrust = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboSize = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.numericGarlic = new System.Windows.Forms.NumericUpDown();
			this.lblGarlic = new System.Windows.Forms.Label();
			this.numericCheese = new System.Windows.Forms.NumericUpDown();
			this.lblCheese = new System.Windows.Forms.Label();
			this.numericWings = new System.Windows.Forms.NumericUpDown();
			this.lblWings = new System.Windows.Forms.Label();
			this.numericWater = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.numericSoda = new System.Windows.Forms.NumericUpDown();
			this.lblSoda = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.textPhone = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericGarlic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCheese)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWater)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSoda)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(406, 234);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.checkToppings);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.comboSpecialty);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.comboSauce);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.comboCrust);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.comboSize);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(398, 208);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Pizza";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(184, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Toppings";
			// 
			// checkToppings
			// 
			this.checkToppings.FormattingEnabled = true;
			this.checkToppings.Items.AddRange(new object[] {
            "Extra Cheese",
            "Pepperoni",
            "Onions",
            "Garlic",
            "Green Peppers",
            "Red Peppers",
            "Green Olives",
            "Mushroom",
            "Black Olives",
            "Chicken",
            "Bacon",
            "Beef",
            "Ham",
            "Sausage"});
			this.checkToppings.Location = new System.Drawing.Point(187, 41);
			this.checkToppings.Name = "checkToppings";
			this.checkToppings.Size = new System.Drawing.Size(205, 154);
			this.checkToppings.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Specialty Pizza";
			// 
			// comboSpecialty
			// 
			this.comboSpecialty.FormattingEnabled = true;
			this.comboSpecialty.Items.AddRange(new object[] {
            "None",
            "BLT Pizza – $18.95",
            "Supreme – $18.95",
            "BBQ Chicken – $18.95",
            "Meat Lovers – $18.95",
            "Veggie Lovers – $18.95",
            "Hawaiian – $18.95"});
			this.comboSpecialty.Location = new System.Drawing.Point(6, 170);
			this.comboSpecialty.Name = "comboSpecialty";
			this.comboSpecialty.Size = new System.Drawing.Size(175, 21);
			this.comboSpecialty.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pizza Sauce";
			// 
			// comboSauce
			// 
			this.comboSauce.FormattingEnabled = true;
			this.comboSauce.Items.AddRange(new object[] {
            "Tomato",
            "White",
            "Pesto",
            "Ranch"});
			this.comboSauce.Location = new System.Drawing.Point(6, 127);
			this.comboSauce.Name = "comboSauce";
			this.comboSauce.Size = new System.Drawing.Size(175, 21);
			this.comboSauce.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Crust Style";
			// 
			// comboCrust
			// 
			this.comboCrust.FormattingEnabled = true;
			this.comboCrust.Items.AddRange(new object[] {
            "Thin & Crispy",
            "Regular",
            "Pan"});
			this.comboCrust.Location = new System.Drawing.Point(6, 84);
			this.comboCrust.Name = "comboCrust";
			this.comboCrust.Size = new System.Drawing.Size(175, 21);
			this.comboCrust.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pizza Size";
			// 
			// comboSize
			// 
			this.comboSize.FormattingEnabled = true;
			this.comboSize.Items.AddRange(new object[] {
            "Small (10\") - $9.95",
            "Medium (12\") - $12.95",
            "Large (16\") - $15.95"});
			this.comboSize.Location = new System.Drawing.Point(6, 41);
			this.comboSize.Name = "comboSize";
			this.comboSize.Size = new System.Drawing.Size(175, 21);
			this.comboSize.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.numericGarlic);
			this.tabPage2.Controls.Add(this.lblGarlic);
			this.tabPage2.Controls.Add(this.numericCheese);
			this.tabPage2.Controls.Add(this.lblCheese);
			this.tabPage2.Controls.Add(this.numericWings);
			this.tabPage2.Controls.Add(this.lblWings);
			this.tabPage2.Controls.Add(this.numericWater);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.numericSoda);
			this.tabPage2.Controls.Add(this.lblSoda);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(398, 208);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Beverages";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// numericGarlic
			// 
			this.numericGarlic.Location = new System.Drawing.Point(188, 127);
			this.numericGarlic.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericGarlic.Name = "numericGarlic";
			this.numericGarlic.Size = new System.Drawing.Size(170, 20);
			this.numericGarlic.TabIndex = 12;
			// 
			// lblGarlic
			// 
			this.lblGarlic.AutoSize = true;
			this.lblGarlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGarlic.Location = new System.Drawing.Point(185, 108);
			this.lblGarlic.Name = "lblGarlic";
			this.lblGarlic.Size = new System.Drawing.Size(123, 16);
			this.lblGarlic.TabIndex = 11;
			this.lblGarlic.Text = "Garlic Sticks - $2.99";
			// 
			// numericCheese
			// 
			this.numericCheese.Location = new System.Drawing.Point(188, 84);
			this.numericCheese.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericCheese.Name = "numericCheese";
			this.numericCheese.Size = new System.Drawing.Size(170, 20);
			this.numericCheese.TabIndex = 10;
			// 
			// lblCheese
			// 
			this.lblCheese.AutoSize = true;
			this.lblCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCheese.Location = new System.Drawing.Point(185, 65);
			this.lblCheese.Name = "lblCheese";
			this.lblCheese.Size = new System.Drawing.Size(135, 16);
			this.lblCheese.TabIndex = 9;
			this.lblCheese.Text = "Cheese Sticks - $3.99";
			// 
			// numericWings
			// 
			this.numericWings.Location = new System.Drawing.Point(188, 41);
			this.numericWings.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericWings.Name = "numericWings";
			this.numericWings.Size = new System.Drawing.Size(170, 20);
			this.numericWings.TabIndex = 8;
			// 
			// lblWings
			// 
			this.lblWings.AutoSize = true;
			this.lblWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWings.Location = new System.Drawing.Point(185, 22);
			this.lblWings.Name = "lblWings";
			this.lblWings.Size = new System.Drawing.Size(111, 16);
			this.lblWings.TabIndex = 7;
			this.lblWings.Text = "Hot Wings - $4.99";
			// 
			// numericWater
			// 
			this.numericWater.Location = new System.Drawing.Point(9, 84);
			this.numericWater.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericWater.Name = "numericWater";
			this.numericWater.Size = new System.Drawing.Size(170, 20);
			this.numericWater.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Water – Free";
			// 
			// numericSoda
			// 
			this.numericSoda.Location = new System.Drawing.Point(9, 41);
			this.numericSoda.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericSoda.Name = "numericSoda";
			this.numericSoda.Size = new System.Drawing.Size(170, 20);
			this.numericSoda.TabIndex = 4;
			// 
			// lblSoda
			// 
			this.lblSoda.AutoSize = true;
			this.lblSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoda.Location = new System.Drawing.Point(6, 22);
			this.lblSoda.Name = "lblSoda";
			this.lblSoda.Size = new System.Drawing.Size(113, 16);
			this.lblSoda.TabIndex = 3;
			this.lblSoda.Text = "Soft Drinks - $1.75";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.textPhone);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.textEmail);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.textAddress);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.textName);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(398, 208);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Customer Info";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// textPhone
			// 
			this.textPhone.Location = new System.Drawing.Point(9, 170);
			this.textPhone.Name = "textPhone";
			this.textPhone.Size = new System.Drawing.Size(186, 20);
			this.textPhone.TabIndex = 11;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 151);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(98, 16);
			this.label14.TabIndex = 10;
			this.label14.Text = "Phone Number";
			// 
			// textEmail
			// 
			this.textEmail.Location = new System.Drawing.Point(9, 127);
			this.textEmail.Name = "textEmail";
			this.textEmail.Size = new System.Drawing.Size(186, 20);
			this.textEmail.TabIndex = 9;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 108);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "Email Address";
			// 
			// textAddress
			// 
			this.textAddress.Location = new System.Drawing.Point(9, 84);
			this.textAddress.Name = "textAddress";
			this.textAddress.Size = new System.Drawing.Size(186, 20);
			this.textAddress.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 65);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 16);
			this.label12.TabIndex = 6;
			this.label12.Text = "Delivery Address";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(9, 41);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(186, 20);
			this.textName.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Delivery Name";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(11, 240);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(319, 240);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Order";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 273);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Buscemi\'s Pizza Expressway";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericGarlic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCheese)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWater)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSoda)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.ComboBox comboSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboCrust;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboSauce;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboSpecialty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox checkToppings;
		private System.Windows.Forms.Label lblSoda;
		private System.Windows.Forms.NumericUpDown numericSoda;
		private System.Windows.Forms.NumericUpDown numericWater;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericCheese;
		private System.Windows.Forms.Label lblCheese;
		private System.Windows.Forms.NumericUpDown numericWings;
		private System.Windows.Forms.Label lblWings;
		private System.Windows.Forms.NumericUpDown numericGarlic;
		private System.Windows.Forms.Label lblGarlic;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textAddress;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textEmail;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textPhone;
	}
}

