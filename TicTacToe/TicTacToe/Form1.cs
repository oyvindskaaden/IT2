using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
            newGame.Text = "";
            textNext.Text = player;
            btWin = new Button[8, 3] 
            { 
                { bt1, bt2, bt3 }, 
                { bt4, bt5, bt6 }, 
                { bt7, bt8, bt9 }, 
                { bt1, bt4, bt7 }, 
                { bt2, bt5, bt8 }, 
                { bt3, bt6, bt9 }, 
                { bt1, bt5, bt9 }, 
                { bt3, bt5, bt7 } };
        }

        string player = "X";

        int turn;

        bool gameOver = false;

        Button[,] btWin;


        private void btClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (!gameOver)
            {
                if (b.Text == "")
                {
                    b.Text = player;
                    turn++;
                    if (player == "X")
                        player = "O";
                    else
                        player = "X";
                }

                CheckWin();
            }
        }

        private void CheckWin()
        {
            for (int i = 0; i < 8; i++)
            {
                if (btWin[i, 0].Text == btWin[i, 1].Text && btWin[i, 1].Text == btWin[i, 2].Text && btWin[i,2].Text.Length > 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        btWin[i, j].BackColor = Color.Green;
                    }
                    gameOver = true;
                    nextPlayer.Text = "Winner is:";
                    textNext.Text = btWin[i,0].Text;
                    newGame.Text = "Press here for new game";
                }

            }
            if (turn >= 9 && !gameOver)
            {
                gameOver = true;
                nextPlayer.Text = "DRAW!";
                textNext.Text = "";
                newGame.Text = "Press here for new game";
            }
            else if (!gameOver) {
                nextPlayer.Text = "Next player is:";
                textNext.Text = player;
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                turn = 0;
                gameOver = false;
                nextPlayer.Text = "Next player is:";
                newGame.Text = "";
                textNext.Text = player;
                bt1.Text = bt2.Text = bt3.Text = bt4.Text = bt5.Text = bt6.Text = bt7.Text = bt8.Text = bt9.Text = "";
                bt1.BackColor = bt2.BackColor = bt3.BackColor = bt4.BackColor = bt5.BackColor = bt6.BackColor = bt7.BackColor = bt8.BackColor = bt9.BackColor = Color.Transparent;

            }

        }
    }
}
