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
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).BeginInit();
            SuspendLayout();
            // 
            // dgv_gameScore
            // 
            dgv_gameScore.Anchor = AnchorStyles.None;
            dgv_gameScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gameScore.Location = new Point(78, 122);
            dgv_gameScore.Name = "dgv_gameScore";
            dgv_gameScore.Size = new Size(478, 221);
            dgv_gameScore.TabIndex = 0;
            // 
            // showresultsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 480);
            Controls.Add(dgv_gameScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "showresultsform";
            Text = "showresultsform";
            Load += showresultsform_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_gameScore;
    }
}