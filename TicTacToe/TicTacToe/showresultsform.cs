using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Data;

namespace TicTacToe
{
    public partial class showresultsform : Form
    {
        public showresultsform()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            DataTable dt = DbContext.Select("select p1.Name , p2.Name , g.[GID],g.[P1Score],g.[P2Score],g.[GameDate] from Player p1 join Game g on p1.id = g.P1id join player p2 on p2.id = g.P2id", "Server=.\\SQLEXPRESS;Database=TicTacToe;Trusted_Connection=True;TrustServerCertificate=True");
            dgv_gameScore.DataSource = dt;
        }

        private void showresultsform_Load(object sender, EventArgs e)
        {

        }
    }
}
