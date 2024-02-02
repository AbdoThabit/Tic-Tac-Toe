namespace TicTacToe
{
    public enum GameMode
    {
        singlePlayer,
        twoPlayers
    }
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            hideOpetionalPanelsAtStart();
        }


        private void hideOpetionalPanelsAtStart()
        {
            Gameoptionpanel.Visible = false;
            Resultoptionpanel.Visible = false;

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void playbtn_Click(object sender, EventArgs e)
        {

            if (Gameoptionpanel.Visible)
                Gameoptionpanel.Visible = false;
            else
                Gameoptionpanel.Visible = true;
        }
        private void Resultbtn_Click(object sender, EventArgs e)
        {
            if (Resultoptionpanel.Visible)
                Resultoptionpanel.Visible = false;
            else
                Resultoptionpanel.Visible = true;
        }


        private Form ActiveForm = null;
        public void openChaild(Form chaildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();

            ActiveForm = chaildForm;
            chaildForm.TopLevel = false;
            chaildForm.FormBorderStyle = FormBorderStyle.None;
            chaildForm.Dock = DockStyle.Fill;
            ActiveFormPanel.Controls.Add(chaildForm);
            ActiveFormPanel.Tag = chaildForm;
            chaildForm.BringToFront();
            chaildForm.Show();


        }

        private void GameScoresbtn_Click(object sender, EventArgs e)
        {
            openChaild(new showresultsform());
        }
        private void Singlebtn_Click(object sender, EventArgs e)
        {
            openChaild(new PlayersInfo(this, GameMode.singlePlayer));
        }

        private void TwoPlayerBtn_Click(object sender, EventArgs e)
        {
            openChaild(new PlayersInfo(this, GameMode.twoPlayers));
        }

        private void TopScorebtn_Click(object sender, EventArgs e)
        {
            openChaild(new TopScoreForm_());
        }
    }
}
