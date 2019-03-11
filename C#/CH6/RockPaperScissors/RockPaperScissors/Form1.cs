using System;
using System.Windows.Forms;

/*
	Author       : Evan Elias Young
	Comment      : Rock paper scissors
	Date Created : 2018-09-24
	Date Updated : 2018-09-24
*/

namespace RockPaperScissors
{
	public partial class Form1 : Form
	{
		public Random rng = new Random((int)DateTime.Now.Ticks);
		public string language = "ENG";
		public char[] moves = { 'R', 'P', 'S' };
		public int wins = 0;
		public int losses = 0;
		public int ties = 0;
		public bool started = false;

		public Form1()
		{
			InitializeComponent();
		}

		public void ChangeImage(PictureBox image, char moveCode)
		{
			switch (moveCode)
			{
				case 'R':
					image.Image = Properties.Resources.rock;
					break;
				case 'P':
					image.Image = Properties.Resources.paper;
					break;
				case 'S':
					image.Image = Properties.Resources.scissors;
					break;
				default:
					image.Image = Properties.Resources.question;
					break;
			}
		}

		public void UpdateCounts()
		{
			outWins.Text = wins.ToString();
			outTies.Text = ties.ToString();
			outLosses.Text = losses.ToString();
		}

		public void MakePlay(char playerMove)
		{
			char robotMove = moves[rng.Next() % 3];
			started = true;

			ChangeImage(imgRobot, robotMove);
			ChangeImage(imgPlayer, playerMove);

			if (robotMove == playerMove)
			{
				lblMatch.Text = language == "ENG" ? "Tie" : "Empate";
				ties += 1;
			}
			else
			{
				switch (robotMove)
				{
					case 'R':
						if (playerMove == 'P')
						{
							lblMatch.Text = language == "ENG" ? "Paper Covers Rock" : "El Papel Cubre La Piedra";
							wins++;
						}
						else
						{
							lblMatch.Text = language == "ENG" ? "Rock Smashes Scissors" : "La Piedra Rompe Las Tijeras";
							losses++;
						}
						break;
					case 'P':
						if (playerMove == 'S')
						{
							lblMatch.Text = language == "ENG" ? "Scissors Cut Paper" : "Las Tijeras Cortan El Papel";
							wins++;
						}
						else
						{
							lblMatch.Text = language == "ENG" ? "Paper Covers Rock" : "El Papel Cubre La Piedra";
							losses++;
						}
						break;
					case 'S':
						if (playerMove == 'R')
						{
							lblMatch.Text = language == "ENG" ? "Rock Smashes Scissors" : "La Piedra Rompe Las Tijeras";
							wins++;
						}
						else
						{
							lblMatch.Text = language == "ENG" ? "Scissors Cut Paper" : "Las Tijeras Cortan El Papel";
							losses++;
						}
						break;
				}
			}

			UpdateCounts();
		}

		private void imgLanguage_Click(object sender, EventArgs e)
		{
			if (language == "ENG")
			{
				language = "ESP";

				if (!started) { lblMatch.Text = "Escoge Una Jugada Para Empezar"; }
				ActiveForm.Text = "Piedra Papel Tijeras";
				lblPlayer.Text = "Jugador";
			}
			else
			{
				language = "ENG";

				if (!started) { lblMatch.Text = "Choose A Move To Begin"; }
				ActiveForm.Text = "Rock Paper Scissors";
				lblPlayer.Text = "Player";
			}
		}

		private void imgRock_Click(object sender, EventArgs e)
		{
			MakePlay('R');
		}

		private void imgPaper_Click(object sender, EventArgs e)
		{
			MakePlay('P');
		}

		private void imgScissors_Click(object sender, EventArgs e)
		{
			MakePlay('S');
		}
	}
}
