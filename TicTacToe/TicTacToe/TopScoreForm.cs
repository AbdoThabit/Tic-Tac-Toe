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

namespace TicTacToe
{
    public partial class TopScoreForm_ : Form
    {
        public TopScoreForm_()
        {
            InitializeComponent();
            getTopScores();
        }
        private void getTopScores()
        {
         dgv_topScore.DataSource = Services.getMaxScores();

        }
}
}
