namespace TicTacToe
{
    partial class TopScoreForm_
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
            dgv_topScore = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_topScore).BeginInit();
            SuspendLayout();
            // 
            // dgv_topScore
            // 
            dgv_topScore.Anchor = AnchorStyles.None;
            dgv_topScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topScore.Location = new Point(214, 120);
            dgv_topScore.Name = "dgv_topScore";
            dgv_topScore.Size = new Size(225, 196);
            dgv_topScore.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(121, 42);
            label1.Name = "label1";
            label1.Size = new Size(465, 37);
            label1.TabIndex = 1;
            label1.Text = "Players with top Scores in all matches ";
            // 
            // TopScoreForm_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 211, 188);
            ClientSize = new Size(687, 480);
            Controls.Add(label1);
            Controls.Add(dgv_topScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TopScoreForm_";
            Text = "TopScoreForm_";
            ((System.ComponentModel.ISupportInitialize)dgv_topScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_topScore;
        private Label label1;
    }
}