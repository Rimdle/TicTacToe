using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class TTT
    {
        static int y = SystemInformation.PrimaryMonitorSize.Height / 2;
        static int x = ( SystemInformation.PrimaryMonitorSize.Height / 6 ) * 2;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTT));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.Mover = new System.Windows.Forms.Button();
            this.NGBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.Diff = new System.Windows.Forms.Label();
            this.DiffSw = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.EndGame = new System.Windows.Forms.Label();
            this.EndText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(443, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(36, 32);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseClick);
            this.ExitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            this.ExitBtn.MouseHover += new System.EventHandler(this.ExitBtn_MouseHover);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinBtn.Location = new System.Drawing.Point(407, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(36, 32);
            this.MinBtn.TabIndex = 0;
            this.MinBtn.Text = "—";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinBtn_MouseClick);
            this.MinBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinBtn_MouseDown);
            this.MinBtn.MouseLeave += new System.EventHandler(this.MinBtn_MouseLeave);
            this.MinBtn.MouseHover += new System.EventHandler(this.MinBtn_MouseHover);
            this.MinBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinBtn_MouseUp);
            // 
            // Mover
            // 
            this.Mover.BackColor = System.Drawing.Color.Transparent;
            this.Mover.FlatAppearance.BorderSize = 0;
            this.Mover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Mover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mover.Location = new System.Drawing.Point(0, 0);
            this.Mover.Margin = new System.Windows.Forms.Padding(0);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(406, 32);
            this.Mover.TabIndex = 0;
            this.Mover.UseVisualStyleBackColor = false;
            this.Mover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseDown);
            this.Mover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseMove);
            // 
            // NGBtn
            // 
            this.NGBtn.BackColor = System.Drawing.Color.Transparent;
            this.NGBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NGBtn.BackgroundImage")));
            this.NGBtn.FlatAppearance.BorderSize = 0;
            this.NGBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NGBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NGBtn.Location = new System.Drawing.Point(100, 280);
            this.NGBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NGBtn.Name = "NGBtn";
            this.NGBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NGBtn.Size = new System.Drawing.Size(280, 72);
            this.NGBtn.TabIndex = 1;
            this.NGBtn.UseVisualStyleBackColor = false;
            this.NGBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NGBtn_MouseDown);
            this.NGBtn.MouseLeave += new System.EventHandler(this.NGBtn_MouseLeave);
            this.NGBtn.MouseHover += new System.EventHandler(this.NGBtn_MouseHover);
            this.NGBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NGBtn_MouseUp);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(50, 69);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(380, 160);
            this.Logo.TabIndex = 0;
            // 
            // Diff
            // 
            this.Diff.BackColor = System.Drawing.Color.Transparent;
            this.Diff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diff.Image = ((System.Drawing.Image)(resources.GetObject("Diff.Image")));
            this.Diff.Location = new System.Drawing.Point(100, 364);
            this.Diff.Margin = new System.Windows.Forms.Padding(0);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(185, 59);
            this.Diff.TabIndex = 2;
            // 
            // DiffSw
            // 
            this.DiffSw.BackColor = System.Drawing.Color.Transparent;
            this.DiffSw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiffSw.BackgroundImage")));
            this.DiffSw.FlatAppearance.BorderSize = 0;
            this.DiffSw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DiffSw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DiffSw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiffSw.Location = new System.Drawing.Point(291, 364);
            this.DiffSw.Margin = new System.Windows.Forms.Padding(0);
            this.DiffSw.Name = "DiffSw";
            this.DiffSw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiffSw.Size = new System.Drawing.Size(89, 59);
            this.DiffSw.TabIndex = 1;
            this.DiffSw.UseVisualStyleBackColor = false;
            this.DiffSw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiffSw_MouseDown);
            this.DiffSw.MouseLeave += new System.EventHandler(this.DiffSw_MouseLeave);
            this.DiffSw.MouseHover += new System.EventHandler(this.DiffSw_MouseHover);
            this.DiffSw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DiffSw_MouseUp);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B1.BackgroundImage")));
            this.B1.Enabled = false;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Location = new System.Drawing.Point(45, 284);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(120, 120);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Visible = false;
            this.B1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B1_MouseDown);
            this.B1.MouseLeave += new System.EventHandler(this.B1_MouseLeave);
            this.B1.MouseHover += new System.EventHandler(this.B1_MouseHover);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
            this.B2.Enabled = false;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Location = new System.Drawing.Point(180, 284);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(120, 120);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Visible = false;
            this.B2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B2_MouseDown);
            this.B2.MouseLeave += new System.EventHandler(this.B2_MouseLeave);
            this.B2.MouseHover += new System.EventHandler(this.B2_MouseHover);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B3.BackgroundImage")));
            this.B3.Enabled = false;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Location = new System.Drawing.Point(315, 284);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(120, 120);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Visible = false;
            this.B3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B3_MouseDown);
            this.B3.MouseLeave += new System.EventHandler(this.B3_MouseLeave);
            this.B3.MouseHover += new System.EventHandler(this.B3_MouseHover);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.Transparent;
            this.B4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B4.BackgroundImage")));
            this.B4.Enabled = false;
            this.B4.FlatAppearance.BorderSize = 0;
            this.B4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.Location = new System.Drawing.Point(45, 419);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(120, 120);
            this.B4.TabIndex = 4;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Visible = false;
            this.B4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B4_MouseDown);
            this.B4.MouseLeave += new System.EventHandler(this.B4_MouseLeave);
            this.B4.MouseHover += new System.EventHandler(this.B4_MouseHover);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.Transparent;
            this.B5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B5.BackgroundImage")));
            this.B5.Enabled = false;
            this.B5.FlatAppearance.BorderSize = 0;
            this.B5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B5.Location = new System.Drawing.Point(180, 419);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(120, 120);
            this.B5.TabIndex = 4;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Visible = false;
            this.B5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B5_MouseDown);
            this.B5.MouseLeave += new System.EventHandler(this.B5_MouseLeave);
            this.B5.MouseHover += new System.EventHandler(this.B5_MouseHover);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.Color.Transparent;
            this.B6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B6.BackgroundImage")));
            this.B6.Enabled = false;
            this.B6.FlatAppearance.BorderSize = 0;
            this.B6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B6.Location = new System.Drawing.Point(315, 419);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(120, 120);
            this.B6.TabIndex = 4;
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Visible = false;
            this.B6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B6_MouseDown);
            this.B6.MouseLeave += new System.EventHandler(this.B6_MouseLeave);
            this.B6.MouseHover += new System.EventHandler(this.B6_MouseHover);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.Color.Transparent;
            this.B7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B7.BackgroundImage")));
            this.B7.Enabled = false;
            this.B7.FlatAppearance.BorderSize = 0;
            this.B7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B7.Location = new System.Drawing.Point(45, 554);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(120, 120);
            this.B7.TabIndex = 4;
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Visible = false;
            this.B7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B7_MouseDown);
            this.B7.MouseLeave += new System.EventHandler(this.B7_MouseLeave);
            this.B7.MouseHover += new System.EventHandler(this.B7_MouseHover);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.Color.Transparent;
            this.B8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B8.BackgroundImage")));
            this.B8.Enabled = false;
            this.B8.FlatAppearance.BorderSize = 0;
            this.B8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B8.Location = new System.Drawing.Point(180, 554);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(120, 120);
            this.B8.TabIndex = 4;
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Visible = false;
            this.B8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B8_MouseDown);
            this.B8.MouseLeave += new System.EventHandler(this.B8_MouseLeave);
            this.B8.MouseHover += new System.EventHandler(this.B8_MouseHover);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.Color.Transparent;
            this.B9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B9.BackgroundImage")));
            this.B9.Enabled = false;
            this.B9.FlatAppearance.BorderSize = 0;
            this.B9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B9.Location = new System.Drawing.Point(315, 554);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(120, 120);
            this.B9.TabIndex = 4;
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Visible = false;
            this.B9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B9_MouseDown);
            this.B9.MouseLeave += new System.EventHandler(this.B9_MouseLeave);
            this.B9.MouseHover += new System.EventHandler(this.B9_MouseHover);
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.Transparent;
            this.EndGame.Enabled = false;
            this.EndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndGame.Image = ((System.Drawing.Image)(resources.GetObject("EndGame.Image")));
            this.EndGame.Location = new System.Drawing.Point(30, 338);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(420, 12);
            this.EndGame.TabIndex = 5;
            this.EndGame.Visible = false;
            // 
            // EndText
            // 
            this.EndText.BackColor = System.Drawing.Color.Transparent;
            this.EndText.FlatAppearance.BorderSize = 0;
            this.EndText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EndText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EndText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndText.ForeColor = System.Drawing.Color.Transparent;
            this.EndText.Location = new System.Drawing.Point(126, 227);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(228, 42);
            this.EndText.TabIndex = 6;
            this.EndText.UseVisualStyleBackColor = false;
            // 
            // TTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(480, 720);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.DiffSw);
            this.Controls.Add(this.NGBtn);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.ExitBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ExitBtn;
        private Button MinBtn;
        private Button Mover;
        private Button NGBtn;
        private Label Logo;
        private Label Diff;
        private Button DiffSw;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button B4;
        private Button B5;
        private Button B6;
        private Button B7;
        private Button B8;
        private Button B9;
        private Label EndGame;
        private Button EndText;
    }
}

