namespace RockPaperScissors
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
			this.lblRobot = new System.Windows.Forms.Label();
			this.lblPlayer = new System.Windows.Forms.Label();
			this.lblMatch = new System.Windows.Forms.Label();
			this.imgLanguage = new System.Windows.Forms.PictureBox();
			this.imgScissors = new System.Windows.Forms.PictureBox();
			this.imgPaper = new System.Windows.Forms.PictureBox();
			this.imgRock = new System.Windows.Forms.PictureBox();
			this.imgPlayer = new System.Windows.Forms.PictureBox();
			this.imgRobot = new System.Windows.Forms.PictureBox();
			this.lblWins = new System.Windows.Forms.Label();
			this.lblLosses = new System.Windows.Forms.Label();
			this.lblTies = new System.Windows.Forms.Label();
			this.outTies = new System.Windows.Forms.Label();
			this.outLosses = new System.Windows.Forms.Label();
			this.outWins = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgLanguage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgScissors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRobot)).BeginInit();
			this.SuspendLayout();
			// 
			// lblRobot
			// 
			this.lblRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRobot.Location = new System.Drawing.Point(12, 9);
			this.lblRobot.Name = "lblRobot";
			this.lblRobot.Size = new System.Drawing.Size(128, 28);
			this.lblRobot.TabIndex = 1;
			this.lblRobot.Text = "AI Dusty";
			this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPlayer
			// 
			this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayer.Location = new System.Drawing.Point(157, 9);
			this.lblPlayer.Name = "lblPlayer";
			this.lblPlayer.Size = new System.Drawing.Size(128, 28);
			this.lblPlayer.TabIndex = 3;
			this.lblPlayer.Text = "Player";
			this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMatch
			// 
			this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatch.Location = new System.Drawing.Point(12, 227);
			this.lblMatch.Name = "lblMatch";
			this.lblMatch.Size = new System.Drawing.Size(273, 64);
			this.lblMatch.TabIndex = 8;
			this.lblMatch.Text = "Choose A Move To Begin";
			this.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imgLanguage
			// 
			this.imgLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgLanguage.Image = global::RockPaperScissors.Properties.Resources.language;
			this.imgLanguage.Location = new System.Drawing.Point(253, 361);
			this.imgLanguage.Name = "imgLanguage";
			this.imgLanguage.Size = new System.Drawing.Size(32, 32);
			this.imgLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLanguage.TabIndex = 9;
			this.imgLanguage.TabStop = false;
			this.imgLanguage.Click += new System.EventHandler(this.imgLanguage_Click);
			// 
			// imgScissors
			// 
			this.imgScissors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgScissors.Image = global::RockPaperScissors.Properties.Resources.scissors;
			this.imgScissors.InitialImage = null;
			this.imgScissors.Location = new System.Drawing.Point(245, 174);
			this.imgScissors.Name = "imgScissors";
			this.imgScissors.Size = new System.Drawing.Size(40, 40);
			this.imgScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgScissors.TabIndex = 7;
			this.imgScissors.TabStop = false;
			this.imgScissors.Click += new System.EventHandler(this.imgScissors_Click);
			// 
			// imgPaper
			// 
			this.imgPaper.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgPaper.Image = global::RockPaperScissors.Properties.Resources.paper;
			this.imgPaper.InitialImage = null;
			this.imgPaper.Location = new System.Drawing.Point(201, 174);
			this.imgPaper.Name = "imgPaper";
			this.imgPaper.Size = new System.Drawing.Size(40, 40);
			this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgPaper.TabIndex = 6;
			this.imgPaper.TabStop = false;
			this.imgPaper.Click += new System.EventHandler(this.imgPaper_Click);
			// 
			// imgRock
			// 
			this.imgRock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgRock.Image = global::RockPaperScissors.Properties.Resources.rock;
			this.imgRock.InitialImage = null;
			this.imgRock.Location = new System.Drawing.Point(157, 174);
			this.imgRock.Name = "imgRock";
			this.imgRock.Size = new System.Drawing.Size(40, 40);
			this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgRock.TabIndex = 5;
			this.imgRock.TabStop = false;
			this.imgRock.Click += new System.EventHandler(this.imgRock_Click);
			// 
			// imgPlayer
			// 
			this.imgPlayer.Image = global::RockPaperScissors.Properties.Resources.question;
			this.imgPlayer.InitialImage = null;
			this.imgPlayer.Location = new System.Drawing.Point(157, 40);
			this.imgPlayer.Name = "imgPlayer";
			this.imgPlayer.Size = new System.Drawing.Size(128, 128);
			this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgPlayer.TabIndex = 4;
			this.imgPlayer.TabStop = false;
			// 
			// imgRobot
			// 
			this.imgRobot.Image = global::RockPaperScissors.Properties.Resources.question;
			this.imgRobot.InitialImage = null;
			this.imgRobot.Location = new System.Drawing.Point(12, 40);
			this.imgRobot.Name = "imgRobot";
			this.imgRobot.Size = new System.Drawing.Size(128, 128);
			this.imgRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgRobot.TabIndex = 2;
			this.imgRobot.TabStop = false;
			// 
			// lblWins
			// 
			this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWins.Location = new System.Drawing.Point(12, 295);
			this.lblWins.Name = "lblWins";
			this.lblWins.Size = new System.Drawing.Size(96, 28);
			this.lblWins.TabIndex = 10;
			this.lblWins.Text = "Wins";
			this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLosses
			// 
			this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLosses.Location = new System.Drawing.Point(189, 295);
			this.lblLosses.Name = "lblLosses";
			this.lblLosses.Size = new System.Drawing.Size(96, 28);
			this.lblLosses.TabIndex = 11;
			this.lblLosses.Text = "Losses";
			this.lblLosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTies
			// 
			this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTies.Location = new System.Drawing.Point(114, 295);
			this.lblTies.Name = "lblTies";
			this.lblTies.Size = new System.Drawing.Size(69, 28);
			this.lblTies.TabIndex = 12;
			this.lblTies.Text = "Ties";
			this.lblTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// outTies
			// 
			this.outTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outTies.Location = new System.Drawing.Point(114, 323);
			this.outTies.Name = "outTies";
			this.outTies.Size = new System.Drawing.Size(69, 28);
			this.outTies.TabIndex = 15;
			this.outTies.Text = "0";
			this.outTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// outLosses
			// 
			this.outLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outLosses.Location = new System.Drawing.Point(189, 323);
			this.outLosses.Name = "outLosses";
			this.outLosses.Size = new System.Drawing.Size(96, 28);
			this.outLosses.TabIndex = 14;
			this.outLosses.Text = "0";
			this.outLosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// outWins
			// 
			this.outWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outWins.Location = new System.Drawing.Point(12, 323);
			this.outWins.Name = "outWins";
			this.outWins.Size = new System.Drawing.Size(96, 28);
			this.outWins.TabIndex = 13;
			this.outWins.Text = "0";
			this.outWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 405);
			this.Controls.Add(this.outTies);
			this.Controls.Add(this.outLosses);
			this.Controls.Add(this.outWins);
			this.Controls.Add(this.lblTies);
			this.Controls.Add(this.lblLosses);
			this.Controls.Add(this.lblWins);
			this.Controls.Add(this.imgLanguage);
			this.Controls.Add(this.lblMatch);
			this.Controls.Add(this.imgScissors);
			this.Controls.Add(this.imgPaper);
			this.Controls.Add(this.imgRock);
			this.Controls.Add(this.imgPlayer);
			this.Controls.Add(this.lblPlayer);
			this.Controls.Add(this.imgRobot);
			this.Controls.Add(this.lblRobot);
			this.Name = "Form1";
			this.Text = "Rock Paper Scissors";
			((System.ComponentModel.ISupportInitialize)(this.imgLanguage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgScissors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgRobot)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblRobot;
		private System.Windows.Forms.PictureBox imgRobot;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.PictureBox imgPlayer;
		private System.Windows.Forms.PictureBox imgRock;
		private System.Windows.Forms.PictureBox imgPaper;
		private System.Windows.Forms.PictureBox imgScissors;
		private System.Windows.Forms.Label lblMatch;
		private System.Windows.Forms.PictureBox imgLanguage;
		private System.Windows.Forms.Label lblWins;
		private System.Windows.Forms.Label lblLosses;
		private System.Windows.Forms.Label lblTies;
		private System.Windows.Forms.Label outTies;
		private System.Windows.Forms.Label outLosses;
		private System.Windows.Forms.Label outWins;
	}
}

