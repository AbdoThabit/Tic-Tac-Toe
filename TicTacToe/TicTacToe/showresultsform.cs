using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;
using TicTacToe.Data;

namespace TicTacToe
{
    public partial class showresultsform : Form
    {
        private int id;
        public showresultsform()
        {
            InitializeComponent();
            showEditPanel(false);
            getData();
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("Admin");

        }
        private void showEditPanel(bool show)
        {
            panel_editOption.Visible = show;
        }
        private void getData()
        {
            dgv_gameScore.DataSource = Services.getAllGamesResult();
        }

        private void showresultsform_Load(object sender, EventArgs e)
        {

        }

        private void dgv_gameScore_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = (int)dgv_gameScore.SelectedRows[0].Cells[0].Value;
            txt_player1Name.Text = (string)dgv_gameScore.SelectedRows[0].Cells[1].Value;
            nud_player1Score.Value = (int)dgv_gameScore.SelectedRows[0].Cells[2].Value;
            txt_player2Name.Text = (string)dgv_gameScore.SelectedRows[0].Cells[3].Value;
            nud_Player2Score.Value = (int)dgv_gameScore.SelectedRows[0].Cells[4].Value;
            showEditPanel(true);

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex != 1) MessageBox.Show("only admins can apply changes to results");
            else
            {
                Services.updateGametable((int)nud_player1Score.Value, (int)nud_Player2Score.Value, id);
                MessageBox.Show("done!");
                getData();
                showEditPanel(false);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1) MessageBox.Show("only admins can apply changes to results");
            else
            {
                Services.deleteFromeGame( id);
                MessageBox.Show("done!");
                getData();
                showEditPanel(false);
            }
        }
    }
}
