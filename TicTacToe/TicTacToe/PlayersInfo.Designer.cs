namespace TicTacToe
{
    partial class PlayersInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startbtn = new Button();
            TwoPlayesPanel = new Panel();
            player2Info = new Panel();
            txtp2Name = new TextBox();
            lblp2Name = new Label();
            rdp2O = new RadioButton();
            rdP2X = new RadioButton();
            Player1Info = new Panel();
            txtP1Name = new TextBox();
            lblP1Name = new Label();
            rdP1O = new RadioButton();
            rdP1X = new RadioButton();
            panel2players = new Panel();
            panelonePlayer = new Panel();
            panel1 = new Panel();
            onePlayerStartGame = new Button();
            onePlayerTxt = new TextBox();
            lblonePlayerName = new Label();
            TwoPlayesPanel.SuspendLayout();
            player2Info.SuspendLayout();
            Player1Info.SuspendLayout();
            panel2players.SuspendLayout();
            panelonePlayer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // startbtn
            // 
            startbtn.Anchor = AnchorStyles.None;
            startbtn.BackColor = Color.FromArgb(138, 19, 18);
            startbtn.Location = new Point(238, 194);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(201, 63);
            startbtn.TabIndex = 11;
            startbtn.Text = "Start The Game!";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // TwoPlayesPanel
            // 
            TwoPlayesPanel.Controls.Add(player2Info);
            TwoPlayesPanel.Controls.Add(Player1Info);
            TwoPlayesPanel.Dock = DockStyle.Top;
            TwoPlayesPanel.Location = new Point(0, 0);
            TwoPlayesPanel.Name = "TwoPlayesPanel";
            TwoPlayesPanel.Size = new Size(687, 178);
            TwoPlayesPanel.TabIndex = 4;
            // 
            // player2Info
            // 
            player2Info.Controls.Add(txtp2Name);
            player2Info.Controls.Add(lblp2Name);
            player2Info.Controls.Add(rdp2O);
            player2Info.Controls.Add(rdP2X);
            player2Info.Dock = DockStyle.Right;
            player2Info.Location = new Point(420, 0);
            player2Info.Name = "player2Info";
            player2Info.Size = new Size(267, 178);
            player2Info.TabIndex = 12;
            // 
            // txtp2Name
            // 
            txtp2Name.Location = new Point(134, 24);
            txtp2Name.Name = "txtp2Name";
            txtp2Name.Size = new Size(100, 23);
            txtp2Name.TabIndex = 3;
            // 
            // lblp2Name
            // 
            lblp2Name.AutoSize = true;
            lblp2Name.Font = new Font("Segoe UI", 12F);
            lblp2Name.ForeColor = Color.Firebrick;
            lblp2Name.Location = new Point(13, 24);
            lblp2Name.Name = "lblp2Name";
            lblp2Name.Size = new Size(115, 21);
            lblp2Name.TabIndex = 2;
            lblp2Name.Text = "Player2 Name :";
            // 
            // rdp2O
            // 
            rdp2O.AutoSize = true;
            rdp2O.Font = new Font("Segoe UI", 12F);
            rdp2O.ForeColor = Color.Firebrick;
            rdp2O.Location = new Point(142, 96);
            rdp2O.Name = "rdp2O";
            rdp2O.Size = new Size(40, 25);
            rdp2O.TabIndex = 1;
            rdp2O.TabStop = true;
            rdp2O.Text = "O";
            rdp2O.UseVisualStyleBackColor = true;
            rdp2O.CheckedChanged += rdp2Y_CheckedChanged;
            // 
            // rdP2X
            // 
            rdP2X.AutoSize = true;
            rdP2X.Font = new Font("Segoe UI", 12F);
            rdP2X.ForeColor = Color.Firebrick;
            rdP2X.Location = new Point(69, 96);
            rdP2X.Name = "rdP2X";
            rdP2X.Size = new Size(37, 25);
            rdP2X.TabIndex = 0;
            rdP2X.TabStop = true;
            rdP2X.Text = "X";
            rdP2X.UseVisualStyleBackColor = true;
            rdP2X.CheckedChanged += rdP2X_CheckedChanged;
            // 
            // Player1Info
            // 
            Player1Info.Controls.Add(txtP1Name);
            Player1Info.Controls.Add(lblP1Name);
            Player1Info.Controls.Add(rdP1O);
            Player1Info.Controls.Add(rdP1X);
            Player1Info.Dock = DockStyle.Left;
            Player1Info.Location = new Point(0, 0);
            Player1Info.Name = "Player1Info";
            Player1Info.Size = new Size(267, 178);
            Player1Info.TabIndex = 11;
            // 
            // txtP1Name
            // 
            txtP1Name.Location = new Point(134, 24);
            txtP1Name.Name = "txtP1Name";
            txtP1Name.Size = new Size(100, 23);
            txtP1Name.TabIndex = 3;
            // 
            // lblP1Name
            // 
            lblP1Name.AutoSize = true;
            lblP1Name.Font = new Font("Segoe UI", 12F);
            lblP1Name.ForeColor = Color.Firebrick;
            lblP1Name.Location = new Point(27, 27);
            lblP1Name.Name = "lblP1Name";
            lblP1Name.Size = new Size(115, 21);
            lblP1Name.TabIndex = 2;
            lblP1Name.Text = "Player1 Name :";
            // 
            // rdP1O
            // 
            rdP1O.AutoSize = true;
            rdP1O.Font = new Font("Segoe UI", 12F);
            rdP1O.ForeColor = Color.Firebrick;
            rdP1O.Location = new Point(156, 99);
            rdP1O.Name = "rdP1O";
            rdP1O.Size = new Size(40, 25);
            rdP1O.TabIndex = 1;
            rdP1O.TabStop = true;
            rdP1O.Text = "O";
            rdP1O.UseVisualStyleBackColor = true;
            rdP1O.CheckedChanged += rdP1Y_CheckedChanged;
            // 
            // rdP1X
            // 
            rdP1X.AutoSize = true;
            rdP1X.Font = new Font("Segoe UI", 12F);
            rdP1X.ForeColor = Color.Firebrick;
            rdP1X.Location = new Point(83, 99);
            rdP1X.Name = "rdP1X";
            rdP1X.Size = new Size(37, 25);
            rdP1X.TabIndex = 0;
            rdP1X.TabStop = true;
            rdP1X.Text = "X";
            rdP1X.UseVisualStyleBackColor = true;
            rdP1X.CheckedChanged += rdP1X_CheckedChanged;
            // 
            // panel2players
            // 
            panel2players.Controls.Add(TwoPlayesPanel);
            panel2players.Controls.Add(startbtn);
            panel2players.Dock = DockStyle.Top;
            panel2players.Location = new Point(0, 0);
            panel2players.Name = "panel2players";
            panel2players.Size = new Size(687, 286);
            panel2players.TabIndex = 12;
            // 
            // panelonePlayer
            // 
            panelonePlayer.Controls.Add(panel1);
            panelonePlayer.Dock = DockStyle.Top;
            panelonePlayer.Location = new Point(0, 286);
            panelonePlayer.Name = "panelonePlayer";
            panelonePlayer.Size = new Size(687, 146);
            panelonePlayer.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(onePlayerStartGame);
            panel1.Controls.Add(onePlayerTxt);
            panel1.Controls.Add(lblonePlayerName);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 137);
            panel1.TabIndex = 0;
            // 
            // onePlayerStartGame
            // 
            onePlayerStartGame.Anchor = AnchorStyles.None;
            onePlayerStartGame.BackColor = Color.FromArgb(138, 19, 18);
            onePlayerStartGame.Location = new Point(360, 46);
            onePlayerStartGame.Name = "onePlayerStartGame";
            onePlayerStartGame.Size = new Size(197, 35);
            onePlayerStartGame.TabIndex = 21;
            onePlayerStartGame.Text = "Start The Game!";
            onePlayerStartGame.UseVisualStyleBackColor = false;
            onePlayerStartGame.Click += onePlayerStartGame_Click;
            // 
            // onePlayerTxt
            // 
            onePlayerTxt.Location = new Point(205, 53);
            onePlayerTxt.Name = "onePlayerTxt";
            onePlayerTxt.Size = new Size(118, 23);
            onePlayerTxt.TabIndex = 20;
            // 
            // lblonePlayerName
            // 
            lblonePlayerName.AutoSize = true;
            lblonePlayerName.Font = new Font("Segoe UI", 12F);
            lblonePlayerName.ForeColor = Color.Firebrick;
            lblonePlayerName.Location = new Point(120, 53);
            lblonePlayerName.Name = "lblonePlayerName";
            lblonePlayerName.Size = new Size(59, 21);
            lblonePlayerName.TabIndex = 19;
            lblonePlayerName.Text = "Name :";
            // 
            // PlayersInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 211, 188);
            ClientSize = new Size(687, 480);
            Controls.Add(panelonePlayer);
            Controls.Add(panel2players);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayersInfo";
            Text = "GameInfo";
            TwoPlayesPanel.ResumeLayout(false);
            player2Info.ResumeLayout(false);
            player2Info.PerformLayout();
            Player1Info.ResumeLayout(false);
            Player1Info.PerformLayout();
            panel2players.ResumeLayout(false);
            panelonePlayer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button startbtn;
        private Panel TwoPlayesPanel;
        private Panel player2Info;
        private TextBox txtp2Name;
        private Label lblp2Name;
        private RadioButton rdp2O;
        private RadioButton rdP2X;
        private Panel Player1Info;
        private TextBox txtP1Name;
        private Label lblP1Name;
        private RadioButton rdP1O;
        private RadioButton rdP1X;
        private Panel panel2players;
        private Panel panelonePlayer;
        private Panel panel1;
        private Button onePlayerStartGame;
        private TextBox onePlayerTxt;
        private Label lblonePlayerName;
    }
}