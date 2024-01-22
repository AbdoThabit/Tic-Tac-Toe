namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidepanel = new Panel();
            Resultoptionpanel = new Panel();
            TopScorebtn = new Button();
            GameScoresbtn = new Button();
            Resultbtn = new Button();
            Gameoptionpanel = new Panel();
            TwoPlayerBtn = new Button();
            Singlebtn = new Button();
            playbtn = new Button();
            logopanel = new FlowLayoutPanel();
            bottomPanel = new Panel();
            ActiveFormPanel = new Panel();
            sidepanel.SuspendLayout();
            Resultoptionpanel.SuspendLayout();
            Gameoptionpanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.AutoScroll = true;
            sidepanel.BackColor = Color.FromArgb(138, 19, 18);
            sidepanel.Controls.Add(Resultoptionpanel);
            sidepanel.Controls.Add(Resultbtn);
            sidepanel.Controls.Add(Gameoptionpanel);
            sidepanel.Controls.Add(playbtn);
            sidepanel.Controls.Add(logopanel);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Margin = new Padding(4);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(228, 480);
            sidepanel.TabIndex = 0;
            // 
            // Resultoptionpanel
            // 
            Resultoptionpanel.Controls.Add(TopScorebtn);
            Resultoptionpanel.Controls.Add(GameScoresbtn);
            Resultoptionpanel.Dock = DockStyle.Top;
            Resultoptionpanel.Location = new Point(0, 244);
            Resultoptionpanel.Name = "Resultoptionpanel";
            Resultoptionpanel.Size = new Size(228, 64);
            Resultoptionpanel.TabIndex = 4;
            // 
            // TopScorebtn
            // 
            TopScorebtn.Dock = DockStyle.Top;
            TopScorebtn.FlatAppearance.BorderSize = 0;
            TopScorebtn.FlatStyle = FlatStyle.Flat;
            TopScorebtn.ForeColor = Color.Gainsboro;
            TopScorebtn.Location = new Point(0, 31);
            TopScorebtn.Name = "TopScorebtn";
            TopScorebtn.Padding = new Padding(35, 0, 0, 0);
            TopScorebtn.Size = new Size(228, 33);
            TopScorebtn.TabIndex = 1;
            TopScorebtn.Text = "Top Score";
            TopScorebtn.TextAlign = ContentAlignment.MiddleLeft;
            TopScorebtn.UseVisualStyleBackColor = true;
            // 
            // GameScoresbtn
            // 
            GameScoresbtn.Dock = DockStyle.Top;
            GameScoresbtn.FlatAppearance.BorderSize = 0;
            GameScoresbtn.FlatStyle = FlatStyle.Flat;
            GameScoresbtn.ForeColor = Color.Gainsboro;
            GameScoresbtn.Location = new Point(0, 0);
            GameScoresbtn.Name = "GameScoresbtn";
            GameScoresbtn.Padding = new Padding(35, 0, 0, 0);
            GameScoresbtn.Size = new Size(228, 31);
            GameScoresbtn.TabIndex = 0;
            GameScoresbtn.Text = "Game Scores";
            GameScoresbtn.TextAlign = ContentAlignment.MiddleLeft;
            GameScoresbtn.UseVisualStyleBackColor = true;
            GameScoresbtn.Click += GameScoresbtn_Click;
            // 
            // Resultbtn
            // 
            Resultbtn.Dock = DockStyle.Top;
            Resultbtn.FlatAppearance.BorderSize = 0;
            Resultbtn.FlatStyle = FlatStyle.Flat;
            Resultbtn.ForeColor = Color.Gainsboro;
            Resultbtn.Location = new Point(0, 204);
            Resultbtn.Name = "Resultbtn";
            Resultbtn.Padding = new Padding(10, 0, 0, 0);
            Resultbtn.Size = new Size(228, 40);
            Resultbtn.TabIndex = 3;
            Resultbtn.Text = "Show Result";
            Resultbtn.TextAlign = ContentAlignment.MiddleLeft;
            Resultbtn.UseVisualStyleBackColor = true;
            Resultbtn.Click += Resultbtn_Click;
            // 
            // Gameoptionpanel
            // 
            Gameoptionpanel.Controls.Add(TwoPlayerBtn);
            Gameoptionpanel.Controls.Add(Singlebtn);
            Gameoptionpanel.Dock = DockStyle.Top;
            Gameoptionpanel.Location = new Point(0, 140);
            Gameoptionpanel.Name = "Gameoptionpanel";
            Gameoptionpanel.Size = new Size(228, 64);
            Gameoptionpanel.TabIndex = 2;
            // 
            // TwoPlayerBtn
            // 
            TwoPlayerBtn.Dock = DockStyle.Top;
            TwoPlayerBtn.FlatAppearance.BorderSize = 0;
            TwoPlayerBtn.FlatStyle = FlatStyle.Flat;
            TwoPlayerBtn.ForeColor = Color.Gainsboro;
            TwoPlayerBtn.Location = new Point(0, 31);
            TwoPlayerBtn.Name = "TwoPlayerBtn";
            TwoPlayerBtn.Padding = new Padding(35, 0, 0, 0);
            TwoPlayerBtn.Size = new Size(228, 40);
            TwoPlayerBtn.TabIndex = 1;
            TwoPlayerBtn.Text = "Two Player";
            TwoPlayerBtn.TextAlign = ContentAlignment.MiddleLeft;
            TwoPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // Singlebtn
            // 
            Singlebtn.Dock = DockStyle.Top;
            Singlebtn.FlatAppearance.BorderSize = 0;
            Singlebtn.FlatStyle = FlatStyle.Flat;
            Singlebtn.ForeColor = Color.Gainsboro;
            Singlebtn.Location = new Point(0, 0);
            Singlebtn.Name = "Singlebtn";
            Singlebtn.Padding = new Padding(35, 0, 0, 0);
            Singlebtn.Size = new Size(228, 31);
            Singlebtn.TabIndex = 0;
            Singlebtn.Text = "Single Player";
            Singlebtn.TextAlign = ContentAlignment.MiddleLeft;
            Singlebtn.UseVisualStyleBackColor = true;
            Singlebtn.Click += Singlebtn_Click;
            // 
            // playbtn
            // 
            playbtn.Dock = DockStyle.Top;
            playbtn.FlatAppearance.BorderSize = 0;
            playbtn.FlatStyle = FlatStyle.Flat;
            playbtn.ForeColor = Color.Gainsboro;
            playbtn.Location = new Point(0, 100);
            playbtn.Name = "playbtn";
            playbtn.Padding = new Padding(10, 0, 0, 0);
            playbtn.Size = new Size(228, 40);
            playbtn.TabIndex = 0;
            playbtn.Text = "play";
            playbtn.TextAlign = ContentAlignment.MiddleLeft;
            playbtn.UseVisualStyleBackColor = true;
            playbtn.Click += playbtn_Click;
            // 
            // logopanel
            // 
            logopanel.Dock = DockStyle.Top;
            logopanel.Location = new Point(0, 0);
            logopanel.Name = "logopanel";
            logopanel.Size = new Size(228, 100);
            logopanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(138, 19, 18);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(228, 412);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(687, 68);
            bottomPanel.TabIndex = 1;
            // 
            // ActiveFormPanel
            // 
            ActiveFormPanel.BackColor = Color.FromArgb(130, 40, 40);
            ActiveFormPanel.Dock = DockStyle.Fill;
            ActiveFormPanel.Location = new Point(228, 0);
            ActiveFormPanel.Name = "ActiveFormPanel";
            ActiveFormPanel.Size = new Size(687, 412);
            ActiveFormPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 480);
            Controls.Add(ActiveFormPanel);
            Controls.Add(bottomPanel);
            Controls.Add(sidepanel);
            Font = new Font("Microsoft Sans Serif", 10F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            sidepanel.ResumeLayout(false);
            Resultoptionpanel.ResumeLayout(false);
            Gameoptionpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidepanel;
        private FlowLayoutPanel logopanel;
        private Button playbtn;
        private Panel Gameoptionpanel;
        private Button Singlebtn;
        private Button TwoPlayerBtn;
        private Panel bottomPanel;
        private Button Resultbtn;
        private Panel Resultoptionpanel;
        private Button TopScorebtn;
        private Button GameScoresbtn;
        private Panel ActiveFormPanel;
    }
}
