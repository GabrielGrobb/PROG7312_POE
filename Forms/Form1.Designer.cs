﻿namespace PROG7312_POE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyAreas = new System.Windows.Forms.Button();
            this.btnCallNumbers = new System.Windows.Forms.Button();
            this.pgDataLoad = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMainMenu.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMainMenu.Location = new System.Drawing.Point(668, 58);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(529, 293);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplacingBooks.Location = new System.Drawing.Point(585, 487);
            this.btnReplacingBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(171, 59);
            this.btnReplacingBooks.TabIndex = 1;
            this.btnReplacingBooks.Text = "Replace Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = true;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifyAreas.Location = new System.Drawing.Point(865, 487);
            this.btnIdentifyAreas.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(171, 59);
            this.btnIdentifyAreas.TabIndex = 2;
            this.btnIdentifyAreas.Text = "Identify Areas";
            this.btnIdentifyAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyAreas.Click += new System.EventHandler(this.btnIdentifyAreas_Click);
            // 
            // btnCallNumbers
            // 
            this.btnCallNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallNumbers.Location = new System.Drawing.Point(1137, 487);
            this.btnCallNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallNumbers.Name = "btnCallNumbers";
            this.btnCallNumbers.Size = new System.Drawing.Size(185, 59);
            this.btnCallNumbers.TabIndex = 3;
            this.btnCallNumbers.Text = "Finding Call Numbers";
            this.btnCallNumbers.UseVisualStyleBackColor = true;
            this.btnCallNumbers.Click += new System.EventHandler(this.btnCallNumbers_Click);
            // 
            // pgDataLoad
            // 
            this.pgDataLoad.BackColor = System.Drawing.Color.Firebrick;
            this.pgDataLoad.ForeColor = System.Drawing.Color.Firebrick;
            this.pgDataLoad.Location = new System.Drawing.Point(585, 629);
            this.pgDataLoad.Margin = new System.Windows.Forms.Padding(4);
            this.pgDataLoad.Minimum = 1;
            this.pgDataLoad.Name = "pgDataLoad";
            this.pgDataLoad.Size = new System.Drawing.Size(737, 28);
            this.pgDataLoad.TabIndex = 5;
            this.pgDataLoad.Value = 1;
            this.pgDataLoad.Visible = false;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1215, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(465, 47);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(291, 41);
            this.MXP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_POE.Properties.Resources.Prog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1413, 719);
            this.Controls.Add(this.MXP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgDataLoad);
            this.Controls.Add(this.btnCallNumbers);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.lblMainMenu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1431, 766);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1431, 766);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyAreas;
        private System.Windows.Forms.Button btnCallNumbers;
        private System.Windows.Forms.ProgressBar pgDataLoad;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
    }
}

