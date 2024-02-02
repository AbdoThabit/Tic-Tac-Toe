namespace TicTacToe
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lbl_p2Symbol = new Label();
            label5 = new Label();
            lbl_name2 = new Label();
            label4 = new Label();
            lbl_player2score = new Label();
            lbl_titleplayerscore = new Label();
            label7 = new Label();
            gb_player1 = new GroupBox();
            lbl_p1Symbol = new Label();
            label1 = new Label();
            lbl_name1 = new Label();
            label3 = new Label();
            lbl_player1Score = new Label();
            label2 = new Label();
            lblNameTitle = new Label();
            a1_btn = new Button();
            a2_btn = new Button();
            a3_btn = new Button();
            b3_btn = new Button();
            b2_btn = new Button();
            b1_btn = new Button();
            c1_btn = new Button();
            c2_btn = new Button();
            c3_btn = new Button();
            timer = new System.Windows.Forms.Timer(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2 = new Panel();
            Save_btn = new Button();
            NewGame_btn = new Button();
            Restart_btn = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            gb_player1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(gb_player1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 136);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_p2Symbol);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl_name2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbl_player2score);
            groupBox1.Controls.Add(lbl_titleplayerscore);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = Color.Firebrick;
            groupBox1.Location = new Point(441, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player2";
            // 
            // lbl_p2Symbol
            // 
            lbl_p2Symbol.AutoSize = true;
            lbl_p2Symbol.ForeColor = Color.Firebrick;
            lbl_p2Symbol.Location = new Point(121, 57);
            lbl_p2Symbol.Name = "lbl_p2Symbol";
            lbl_p2Symbol.Size = new Size(55, 21);
            lbl_p2Symbol.TabIndex = 7;
            lbl_p2Symbol.Text = "label8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(0, 57);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 6;
            label5.Text = "Symbol :";
            // 
            // lbl_name2
            // 
            lbl_name2.AutoSize = true;
            lbl_name2.ForeColor = Color.Firebrick;
            lbl_name2.Location = new Point(121, 25);
            lbl_name2.Name = "lbl_name2";
            lbl_name2.Size = new Size(54, 21);
            lbl_name2.TabIndex = 5;
            lbl_name2.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 34);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 3;
            // 
            // lbl_player2score
            // 
            lbl_player2score.AutoSize = true;
            lbl_player2score.ForeColor = Color.Firebrick;
            lbl_player2score.Location = new Point(121, 89);
            lbl_player2score.Name = "lbl_player2score";
            lbl_player2score.Size = new Size(19, 21);
            lbl_player2score.TabIndex = 2;
            lbl_player2score.Text = "0";
            // 
            // lbl_titleplayerscore
            // 
            lbl_titleplayerscore.AutoSize = true;
            lbl_titleplayerscore.ForeColor = Color.Firebrick;
            lbl_titleplayerscore.Location = new Point(6, 89);
            lbl_titleplayerscore.Name = "lbl_titleplayerscore";
            lbl_titleplayerscore.Size = new Size(56, 21);
            lbl_titleplayerscore.TabIndex = 1;
            lbl_titleplayerscore.Text = "Score :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 0;
            label7.Text = "Name : ";
            // 
            // gb_player1
            // 
            gb_player1.Controls.Add(lbl_p1Symbol);
            gb_player1.Controls.Add(label1);
            gb_player1.Controls.Add(lbl_name1);
            gb_player1.Controls.Add(label3);
            gb_player1.Controls.Add(lbl_player1Score);
            gb_player1.Controls.Add(label2);
            gb_player1.Controls.Add(lblNameTitle);
            gb_player1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            gb_player1.ForeColor = Color.Firebrick;
            gb_player1.Location = new Point(0, 3);
            gb_player1.Name = "gb_player1";
            gb_player1.Size = new Size(246, 130);
            gb_player1.TabIndex = 0;
            gb_player1.TabStop = false;
            gb_player1.Text = "Player1";
            // 
            // lbl_p1Symbol
            // 
            lbl_p1Symbol.AutoSize = true;
            lbl_p1Symbol.ForeColor = Color.Firebrick;
            lbl_p1Symbol.Location = new Point(99, 57);
            lbl_p1Symbol.Name = "lbl_p1Symbol";
            lbl_p1Symbol.Size = new Size(55, 21);
            lbl_p1Symbol.TabIndex = 6;
            lbl_p1Symbol.Text = "label6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(0, 57);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 5;
            label1.Text = "Symbol :";
            label1.Click += label1_Click;
            // 
            // lbl_name1
            // 
            lbl_name1.AutoSize = true;
            lbl_name1.ForeColor = Color.Firebrick;
            lbl_name1.Location = new Point(99, 25);
            lbl_name1.Name = "lbl_name1";
            lbl_name1.Size = new Size(53, 21);
            lbl_name1.TabIndex = 4;
            lbl_name1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 34);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 3;
            // 
            // lbl_player1Score
            // 
            lbl_player1Score.AutoSize = true;
            lbl_player1Score.ForeColor = Color.Firebrick;
            lbl_player1Score.Location = new Point(99, 89);
            lbl_player1Score.Name = "lbl_player1Score";
            lbl_player1Score.Size = new Size(19, 21);
            lbl_player1Score.TabIndex = 2;
            lbl_player1Score.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Score :";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.ForeColor = Color.Firebrick;
            lblNameTitle.Location = new Point(6, 25);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(65, 21);
            lblNameTitle.TabIndex = 0;
            lblNameTitle.Text = "Name : ";
            // 
            // a1_btn
            // 
            a1_btn.Font = new Font("Segoe UI", 18F);
            a1_btn.Location = new Point(121, 142);
            a1_btn.Name = "a1_btn";
            a1_btn.Size = new Size(75, 75);
            a1_btn.TabIndex = 1;
            a1_btn.UseVisualStyleBackColor = true;
            a1_btn.Click += xoBtnsClick;
            // 
            // a2_btn
            // 
            a2_btn.Font = new Font("Segoe UI", 18F);
            a2_btn.Location = new Point(287, 142);
            a2_btn.Name = "a2_btn";
            a2_btn.Size = new Size(75, 75);
            a2_btn.TabIndex = 2;
            a2_btn.UseVisualStyleBackColor = true;
            a2_btn.Click += xoBtnsClick;
            // 
            // a3_btn
            // 
            a3_btn.Font = new Font("Segoe UI", 18F);
            a3_btn.Location = new Point(453, 142);
            a3_btn.Name = "a3_btn";
            a3_btn.Size = new Size(75, 75);
            a3_btn.TabIndex = 3;
            a3_btn.UseVisualStyleBackColor = true;
            a3_btn.Click += xoBtnsClick;
            // 
            // b3_btn
            // 
            b3_btn.Font = new Font("Segoe UI", 18F);
            b3_btn.Location = new Point(453, 232);
            b3_btn.Name = "b3_btn";
            b3_btn.Size = new Size(75, 75);
            b3_btn.TabIndex = 6;
            b3_btn.UseVisualStyleBackColor = true;
            b3_btn.Click += xoBtnsClick;
            // 
            // b2_btn
            // 
            b2_btn.Font = new Font("Segoe UI", 18F);
            b2_btn.Location = new Point(287, 232);
            b2_btn.Name = "b2_btn";
            b2_btn.Size = new Size(75, 75);
            b2_btn.TabIndex = 5;
            b2_btn.UseVisualStyleBackColor = true;
            b2_btn.Click += xoBtnsClick;
            // 
            // b1_btn
            // 
            b1_btn.Font = new Font("Segoe UI", 18F);
            b1_btn.Location = new Point(121, 232);
            b1_btn.Name = "b1_btn";
            b1_btn.Size = new Size(75, 75);
            b1_btn.TabIndex = 4;
            b1_btn.UseVisualStyleBackColor = true;
            b1_btn.Click += xoBtnsClick;
            // 
            // c1_btn
            // 
            c1_btn.Font = new Font("Segoe UI", 18F);
            c1_btn.Location = new Point(121, 324);
            c1_btn.Name = "c1_btn";
            c1_btn.Size = new Size(75, 75);
            c1_btn.TabIndex = 7;
            c1_btn.UseVisualStyleBackColor = true;
            c1_btn.Click += xoBtnsClick;
            // 
            // c2_btn
            // 
            c2_btn.Font = new Font("Segoe UI", 18F);
            c2_btn.Location = new Point(287, 324);
            c2_btn.Name = "c2_btn";
            c2_btn.Size = new Size(75, 75);
            c2_btn.TabIndex = 8;
            c2_btn.UseVisualStyleBackColor = true;
            c2_btn.Click += xoBtnsClick;
            // 
            // c3_btn
            // 
            c3_btn.Font = new Font("Segoe UI", 18F);
            c3_btn.Location = new Point(453, 324);
            c3_btn.Name = "c3_btn";
            c3_btn.Size = new Size(75, 75);
            c3_btn.TabIndex = 9;
            c3_btn.UseVisualStyleBackColor = true;
            c3_btn.Click += xoBtnsClick;
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(Save_btn);
            panel2.Controls.Add(NewGame_btn);
            panel2.Controls.Add(Restart_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 64);
            panel2.TabIndex = 10;
            // 
            // Save_btn
            // 
            Save_btn.Anchor = AnchorStyles.None;
            Save_btn.BackColor = Color.FromArgb(138, 19, 18);
            Save_btn.ForeColor = SystemColors.ButtonHighlight;
            Save_btn.Location = new Point(492, 7);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(182, 51);
            Save_btn.TabIndex = 14;
            Save_btn.Text = "Save!";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += Save_btn_Click;
            // 
            // NewGame_btn
            // 
            NewGame_btn.Anchor = AnchorStyles.None;
            NewGame_btn.BackColor = Color.FromArgb(138, 19, 18);
            NewGame_btn.ForeColor = SystemColors.ButtonHighlight;
            NewGame_btn.Location = new Point(253, 7);
            NewGame_btn.Name = "NewGame_btn";
            NewGame_btn.Size = new Size(182, 51);
            NewGame_btn.TabIndex = 13;
            NewGame_btn.Text = "New Game!";
            NewGame_btn.UseVisualStyleBackColor = false;
            NewGame_btn.Click += NewGame_btn_Click;
            // 
            // Restart_btn
            // 
            Restart_btn.Anchor = AnchorStyles.None;
            Restart_btn.BackColor = Color.FromArgb(138, 19, 18);
            Restart_btn.ForeColor = SystemColors.ButtonHighlight;
            Restart_btn.Location = new Point(14, 7);
            Restart_btn.Name = "Restart_btn";
            Restart_btn.Size = new Size(182, 51);
            Restart_btn.TabIndex = 12;
            Restart_btn.Text = "Restart!";
            Restart_btn.UseVisualStyleBackColor = false;
            Restart_btn.Click += Restart_btn_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 211, 188);
            ClientSize = new Size(687, 480);
            Controls.Add(panel2);
            Controls.Add(c3_btn);
            Controls.Add(c2_btn);
            Controls.Add(c1_btn);
            Controls.Add(b3_btn);
            Controls.Add(b2_btn);
            Controls.Add(b1_btn);
            Controls.Add(a3_btn);
            Controls.Add(a2_btn);
            Controls.Add(a1_btn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameForm";
            Text = "GameForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gb_player1.ResumeLayout(false);
            gb_player1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gb_player1;
        private Label label3;
        private Label lbl_player1Score;
        private Label label2;
        private Label lblNameTitle;
        private GroupBox groupBox1;
        private Label label4;
        private Label lbl_player2score;
        private Label lbl_titleplayerscore;
        private Label label7;
        private Button a1_btn;
        private Button a2_btn;
        private Button a3_btn;
        private Button b3_btn;
        private Button b2_btn;
        private Button b1_btn;
        private Button c1_btn;
        private Button c2_btn;
        private Button c3_btn;
        private System.Windows.Forms.Timer timer;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lbl_name2;
        private Label lbl_name1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label1;
        private Label label5;
        private Label lbl_p2Symbol;
        private Label lbl_p1Symbol;
        private Panel panel2;
        private Button Save_btn;
        private Button NewGame_btn;
        private Button Restart_btn;
    }
}