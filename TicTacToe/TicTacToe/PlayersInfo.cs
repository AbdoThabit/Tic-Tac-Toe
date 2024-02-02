using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TicTacToe.Core;

namespace TicTacToe
{

    public partial class PlayersInfo : Form
    {
        public MainForm BaseForm;
        public string player1Name;
        public string player2Name;
        public string player1choice;
        public string player2choice;
        public GameMode gamemode;

        public PlayersInfo(MainForm _baseform, GameMode _gamemode)
        {
            InitializeComponent();
            this.BaseForm = _baseform;
            this.gamemode = _gamemode;
            showChosenModePanel();
        }



        private void opennewform(Form f)
        {
            BaseForm.openChaild(f);
        }
        private void showChosenModePanel()
        {
            if (gamemode == GameMode.singlePlayer)
            {
                panelonePlayer.Visible = true;
                panel2players.Visible = false;
            }
            else
            {
                panelonePlayer.Visible = false;
                panel2players.Visible = true;
            }
        }
        private bool validData()
        {
            return (!string.IsNullOrEmpty(txtP1Name.Text) &&
                   !string.IsNullOrEmpty(txtP1Name.Text) &&
                   (rdP1X.Checked || rdP1O.Checked)) ||
                   !string.IsNullOrEmpty(onePlayerTxt.Text);
        }
        private bool twoPlayersValidData()
        {
            return !string.IsNullOrEmpty(txtP1Name.Text) &&
                   !string.IsNullOrEmpty(txtP1Name.Text) &&
                   (rdP1X.Checked || rdP1O.Checked);
        }
        private bool singlePlayerValidData()
        {
            return !string.IsNullOrEmpty(onePlayerTxt.Text);
        }
        private void getPlayersData()
        {
            if (gamemode == GameMode.twoPlayers)
            {
                player1Name = Services.capitalizeName(txtP1Name.Text);
                player2Name = Services.capitalizeName(txtp2Name.Text);
                if (rdP1X.Checked)
                {
                    player1choice = rdP1X.Text;
                    player2choice = rdp2O.Text;
                }
                else
                {
                    player1choice = rdP1O.Text;
                    player2choice = rdP2X.Text;
                }
            }
            else
            {
                player1Name = Services.capitalizeName(onePlayerTxt.Text);
                player2Name = "Computer";
                player1choice = "X";
                player2choice = "O";

            }
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                getPlayersData();
                opennewform(new GameForm(this));
            }
            else MessageBox.Show("not vaild data");
        }
        private void onePlayerStartGame_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                getPlayersData();
                opennewform(new GameForm(this)); 
            }
            else MessageBox.Show("not valid");
        }

        private void rdP1X_CheckedChanged(object sender, EventArgs e)
        {
            rdp2O.Checked = rdP1X.Checked;
        }

        private void rdP1Y_CheckedChanged(object sender, EventArgs e)
        {
            rdP2X.Checked = rdP1O.Checked;
        }

        private void rdP2X_CheckedChanged(object sender, EventArgs e)
        {
            rdP1O.Checked = rdP2X.Checked;
        }

        private void rdp2Y_CheckedChanged(object sender, EventArgs e)
        {
            rdP1X.Checked = rdp2O.Checked;
        }

        
    }
}
