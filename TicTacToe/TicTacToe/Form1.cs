namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Gameoptionpanel.Visible = true;
            Resultoptionpanel.Visible = false;
        }
        private void Resultbtn_Click(object sender, EventArgs e)
        {
            Resultoptionpanel.Visible = true;
            Gameoptionpanel.Visible = false;
        }

        private void Singlebtn_Click(object sender, EventArgs e)
        {

        }
        private Form ActiveForm = null;
        private void openChaild(Form chaildForm)
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



    }
}
