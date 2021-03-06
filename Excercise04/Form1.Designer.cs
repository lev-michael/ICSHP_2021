﻿namespace Excercise04
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
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accurancyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newGameStripMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.matchAnyLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchFirstLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 226;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(1178, 344);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accurancyLabel,
            this.difficultyLabel,
            this.difficultProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1178, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(88, 25);
            this.correctLabel.Text = "Correct: 0";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(87, 25);
            this.missedLabel.Text = "Missed: 0";
            // 
            // accurancyLabel
            // 
            this.accurancyLabel.Name = "accurancyLabel";
            this.accurancyLabel.Size = new System.Drawing.Size(116, 25);
            this.accurancyLabel.Text = "Accuracy: 0%";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(77, 25);
            this.difficultyLabel.Text = "Difficult:";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultProgressBar
            // 
            this.difficultProgressBar.Maximum = 800;
            this.difficultProgressBar.Name = "difficultProgressBar";
            this.difficultProgressBar.Size = new System.Drawing.Size(200, 24);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameStripMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newGameStripMenu
            // 
            this.newGameStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newGameStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchAnyLetterToolStripMenuItem,
            this.matchFirstLetterToolStripMenuItem,
            this.matchWordsToolStripMenuItem});
            this.newGameStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("newGameStripMenu.Image")));
            this.newGameStripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGameStripMenu.Name = "newGameStripMenu";
            this.newGameStripMenu.Size = new System.Drawing.Size(116, 29);
            this.newGameStripMenu.Text = "New Game";
            // 
            // matchAnyLetterToolStripMenuItem
            // 
            this.matchAnyLetterToolStripMenuItem.Name = "matchAnyLetterToolStripMenuItem";
            this.matchAnyLetterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.matchAnyLetterToolStripMenuItem.Text = "Match any letter";
            this.matchAnyLetterToolStripMenuItem.Click += new System.EventHandler(this.matchAnyLetterToolStripMenuItem_Click);
            // 
            // matchFirstLetterToolStripMenuItem
            // 
            this.matchFirstLetterToolStripMenuItem.Name = "matchFirstLetterToolStripMenuItem";
            this.matchFirstLetterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.matchFirstLetterToolStripMenuItem.Text = "Match first letter";
            this.matchFirstLetterToolStripMenuItem.Click += new System.EventHandler(this.matchFirstLetterToolStripMenuItem_Click);
            // 
            // matchWordsToolStripMenuItem
            // 
            this.matchWordsToolStripMenuItem.Name = "matchWordsToolStripMenuItem";
            this.matchWordsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.matchWordsToolStripMenuItem.Text = "Match words";
            this.matchWordsToolStripMenuItem.Click += new System.EventHandler(this.matchWordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 344);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel accurancyLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton newGameStripMenu;
        private System.Windows.Forms.ToolStripMenuItem matchAnyLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchFirstLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchWordsToolStripMenuItem;
    }
}

