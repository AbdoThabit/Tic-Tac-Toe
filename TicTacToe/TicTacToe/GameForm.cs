using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private string player1name, player2name, player1choice, player2choice;
        private int player1score, player2score;
        private bool isPlayer1Turn;
        private PlayersInfo info;
        private List<Button> buttons;
        private GameMode gameMode;
        public GameForm(PlayersInfo _info)
        {
            InitializeComponent();
            this.info = _info;
            player1name = info.player1Name;
            player2name = info.player2Name;
            player1choice = info.player1choice;
            player2choice = info.player2choice;
            player1score = 0;
            player2score = 0;
            isPlayer1Turn = true;
            gameMode = info.gamemode;
            buttons = new List<Button> { a1_btn, a2_btn, a3_btn, b1_btn, b2_btn, b3_btn, c1_btn, c2_btn, c3_btn };
            setInfo();
        }
        private void restartGame()
        {

            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.Text = "";
                btn.BackColor = DefaultBackColor;
            }
            setInfo();
            isPlayer1Turn = true;
        }
        private void newGame()
        {
            player1score = 0;
            player2score = 0;
            restartGame();
        }
        public void setInfo()
        {
            lbl_p1Symbol.Text = player1choice.ToString();
            lbl_p2Symbol.Text = player2choice.ToString();
            lbl_name1.Text = player1name.ToString();
            lbl_name2.Text = player2name.ToString();
            lbl_player1Score.Text = player1score.ToString();
            lbl_player2score.Text = player2score.ToString();

        }
        private void xoBtnsClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                if (isPlayer1Turn)
                {
                    btn.Text = player1choice;
                    btn.Enabled = false;

                    if (gameCheck(player1name, player1choice, ref player1score))
                    {
                        restartGame();
                        return;
                    }
                    if (gameMode == GameMode.singlePlayer)
                    {
                        timer.Start();
                        computerMove();
                    }
                    isPlayer1Turn = !isPlayer1Turn;

                }
                else
                {
                    btn.Text = player2choice;
                    btn.Enabled = false;

                    isPlayer1Turn = !isPlayer1Turn;
                    if (gameCheck(player2name, player2choice, ref player2score))
                    {
                        restartGame();
                        return;
                    }

                }


            }
        }
        private bool gameCheck(string playername, string symbol, ref int playerScore)
        {
            if ((a1_btn.Text == symbol && a2_btn.Text == symbol && a3_btn.Text == symbol) ||
               (b1_btn.Text == symbol && b2_btn.Text == symbol && b3_btn.Text == symbol) ||
               (c1_btn.Text == symbol && c2_btn.Text == symbol && c3_btn.Text == symbol) ||
               (a1_btn.Text == symbol && b1_btn.Text == symbol && c1_btn.Text == symbol) ||
               (a2_btn.Text == symbol && b2_btn.Text == symbol && c2_btn.Text == symbol) ||
               (a3_btn.Text == symbol && b3_btn.Text == symbol && c3_btn.Text == symbol) ||
               (a1_btn.Text == symbol && b2_btn.Text == symbol && c3_btn.Text == symbol) ||
               (a3_btn.Text == symbol && b2_btn.Text == symbol && c1_btn.Text == symbol))
            {
                playerScore++;
                MessageBox.Show($"{playername} wins !");
                restartGame();
                return true;

            }
            else
            {
                return false;
            }
        }
        private void computerMove()
        {
            Random random = new Random();
            int index;
            if (buttons.Count > 0)
            {

                index = random.Next(buttons.Count);
                buttons[index].Text = player2choice;
                timer.Stop();
                buttons[index].Enabled = false;

                isPlayer1Turn = !isPlayer1Turn;

            }
            gameCheck(player2name, player2choice, ref player2score);





        }

        private void Restart_btn_Click(object sender, EventArgs e)
        {
            restartGame();
        }
        private void NewGame_btn_Click(object sender, EventArgs e)
        {
            newGame();
        }

        
        private void Save_btn_Click(object sender, EventArgs e)
        {
            Services.insertintoGame(player1name, player2name,player1score,player2score);
            newGame();
        }

        private void lbl_player2score_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

