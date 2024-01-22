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
            optionpanel = new Panel();
            TwoPlayerBtn = new Button();
            Singlebtn = new Button();
            playbtn = new Button();
            logopanel = new FlowLayoutPanel();
            sidepanel.SuspendLayout();
            optionpanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.FromArgb(138, 19, 18);
            sidepanel.Controls.Add(optionpanel);
            sidepanel.Controls.Add(playbtn);
            sidepanel.Controls.Add(logopanel);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Margin = new Padding(4);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(228, 480);
            sidepanel.TabIndex = 0;
            // 
            // optionpanel
            // 
            optionpanel.Controls.Add(TwoPlayerBtn);
            optionpanel.Controls.Add(Singlebtn);
            optionpanel.Dock = DockStyle.Top;
            optionpanel.Location = new Point(0, 140);
            optionpanel.Name = "optionpanel";
            optionpanel.Size = new Size(228, 64);
            optionpanel.TabIndex = 2;
            // 
            // TwoPlayerBtn
            // 
            TwoPlayerBtn.Dock = DockStyle.Top;
            TwoPlayerBtn.FlatAppearance.BorderSize = 0;
            TwoPlayerBtn.FlatStyle = FlatStyle.Flat;
            TwoPlayerBtn.ForeColor = Color.Gainsboro;
            TwoPlayerBtn.Location = new Point(0, 31);
            TwoPlayerBtn.Name = "TwoPlayerBtn";
            TwoPlayerBtn.Size = new Size(228, 31);
            TwoPlayerBtn.TabIndex = 1;
            TwoPlayerBtn.Text = "Two Player";
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
            Singlebtn.Size = new Size(228, 31);
            Singlebtn.TabIndex = 0;
            Singlebtn.Text = "Single Player";
            Singlebtn.UseVisualStyleBackColor = true;
            // 
            // playbtn
            // 
            playbtn.Dock = DockStyle.Top;
            playbtn.FlatAppearance.BorderSize = 0;
            playbtn.FlatStyle = FlatStyle.Flat;
            playbtn.ForeColor = Color.Gainsboro;
            playbtn.Location = new Point(0, 100);
            playbtn.Name = "playbtn";
            playbtn.Size = new Size(228, 40);
            playbtn.TabIndex = 0;
            playbtn.Text = "play";
            playbtn.UseVisualStyleBackColor = true;
            playbtn.Click += button1_Click;
            // 
            // logopanel
            // 
            logopanel.Dock = DockStyle.Top;
            logopanel.Location = new Point(0, 0);
            logopanel.Name = "logopanel";
            logopanel.Size = new Size(228, 100);
            logopanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 480);
            Controls.Add(sidepanel);
            Font = new Font("Microsoft Sans Serif", 10F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            sidepanel.ResumeLayout(false);
            optionpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidepanel;
        private FlowLayoutPanel logopanel;
        private Button playbtn;
        private Panel optionpanel;
        private Button Singlebtn;
        private Button TwoPlayerBtn;
    }
}
