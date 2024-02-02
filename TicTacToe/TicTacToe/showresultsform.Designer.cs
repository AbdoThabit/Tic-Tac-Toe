namespace TicTacToe
{
    partial class showresultsform
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
            dgv_gameScore = new DataGridView();
            panel_editOption = new Panel();
            Delete_btn = new Button();
            Update_btn = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_player2Name = new TextBox();
            txt_player1Name = new TextBox();
            nud_Player2Score = new NumericUpDown();
            nud_player1Score = new NumericUpDown();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).BeginInit();
            panel_editOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Player2Score).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_player1Score).BeginInit();
            SuspendLayout();
            // 
            // dgv_gameScore
            // 
            dgv_gameScore.Anchor = AnchorStyles.None;
            dgv_gameScore.BackgroundColor = Color.FromArgb(225, 211, 188);
            dgv_gameScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gameScore.Location = new Point(93, 48);
            dgv_gameScore.Name = "dgv_gameScore";
            dgv_gameScore.Size = new Size(478, 221);
            dgv_gameScore.TabIndex = 0;
            dgv_gameScore.RowHeaderMouseDoubleClick += dgv_gameScore_RowHeaderMouseDoubleClick;
            // 
            // panel_editOption
            // 
            panel_editOption.Controls.Add(Delete_btn);
            panel_editOption.Controls.Add(Update_btn);
            panel_editOption.Controls.Add(label5);
            panel_editOption.Controls.Add(label4);
            panel_editOption.Controls.Add(label3);
            panel_editOption.Controls.Add(label2);
            panel_editOption.Controls.Add(txt_player2Name);
            panel_editOption.Controls.Add(txt_player1Name);
            panel_editOption.Controls.Add(nud_Player2Score);
            panel_editOption.Controls.Add(nud_player1Score);
            panel_editOption.Controls.Add(label1);
            panel_editOption.Controls.Add(comboBox1);
            panel_editOption.Dock = DockStyle.Bottom;
            panel_editOption.Location = new Point(0, 289);
            panel_editOption.Name = "panel_editOption";
            panel_editOption.Size = new Size(687, 191);
            panel_editOption.TabIndex = 1;
            // 
            // Delete_btn
            // 
            Delete_btn.Anchor = AnchorStyles.None;
            Delete_btn.BackColor = Color.FromArgb(138, 19, 18);
            Delete_btn.ForeColor = SystemColors.ButtonHighlight;
            Delete_btn.Location = new Point(342, 135);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(182, 44);
            Delete_btn.TabIndex = 15;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Anchor = AnchorStyles.None;
            Update_btn.BackColor = Color.FromArgb(138, 19, 18);
            Update_btn.ForeColor = SystemColors.ButtonHighlight;
            Update_btn.Location = new Point(103, 135);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(182, 44);
            Update_btn.TabIndex = 14;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(527, 61);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 9;
            label5.Text = "Player2Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(193, 61);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 8;
            label4.Text = "Player1Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(389, 61);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 7;
            label3.Text = "Player2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(47, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 6;
            label2.Text = "Player1";
            // 
            // txt_player2Name
            // 
            txt_player2Name.Location = new Point(370, 92);
            txt_player2Name.Name = "txt_player2Name";
            txt_player2Name.Size = new Size(100, 23);
            txt_player2Name.TabIndex = 5;
            // 
            // txt_player1Name
            // 
            txt_player1Name.Location = new Point(36, 92);
            txt_player1Name.Name = "txt_player1Name";
            txt_player1Name.Size = new Size(100, 23);
            txt_player1Name.TabIndex = 4;
            // 
            // nud_Player2Score
            // 
            nud_Player2Score.Location = new Point(527, 92);
            nud_Player2Score.Name = "nud_Player2Score";
            nud_Player2Score.Size = new Size(120, 23);
            nud_Player2Score.TabIndex = 3;
            // 
            // nud_player1Score
            // 
            nud_player1Score.Location = new Point(193, 92);
            nud_player1Score.Name = "nud_player1Score";
            nud_player1Score.Size = new Size(120, 23);
            nud_player1Score.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(181, 14);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 1;
            label1.Text = "Adminstration";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // showresultsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 211, 188);
            ClientSize = new Size(687, 480);
            Controls.Add(panel_editOption);
            Controls.Add(dgv_gameScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "showresultsform";
            Text = "showresultsform";
            Load += showresultsform_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).EndInit();
            panel_editOption.ResumeLayout(false);
            panel_editOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Player2Score).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_player1Score).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_gameScore;
        private Panel panel_editOption;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_player2Name;
        private TextBox txt_player1Name;
        private NumericUpDown nud_Player2Score;
        private NumericUpDown nud_player1Score;
        private Label label1;
        private ComboBox comboBox1;
        private Button Delete_btn;
        private Button Update_btn;
    }
}