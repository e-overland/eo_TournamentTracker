
namespace TournamentTracker
{
    partial class frmTournViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournViewer));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.ddRound = new System.Windows.Forms.ComboBox();
            this.chkbxUnplayed = new System.Windows.Forms.CheckBox();
            this.listbxMatchup = new System.Windows.Forms.ListBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblTeam1Score = new System.Windows.Forms.Label();
            this.txtbxTeam1Score = new System.Windows.Forms.TextBox();
            this.txtbxTeam2score = new System.Windows.Forms.TextBox();
            this.lblTeam2Score = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(296, 30);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(193, 65);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(23, 127);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(124, 46);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round:";
            // 
            // ddRound
            // 
            this.ddRound.FormattingEnabled = true;
            this.ddRound.Location = new System.Drawing.Point(153, 128);
            this.ddRound.Name = "ddRound";
            this.ddRound.Size = new System.Drawing.Size(287, 45);
            this.ddRound.TabIndex = 3;
            // 
            // chkbxUnplayed
            // 
            this.chkbxUnplayed.AutoSize = true;
            this.chkbxUnplayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkbxUnplayed.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUnplayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.chkbxUnplayed.Location = new System.Drawing.Point(153, 179);
            this.chkbxUnplayed.Name = "chkbxUnplayed";
            this.chkbxUnplayed.Size = new System.Drawing.Size(257, 50);
            this.chkbxUnplayed.TabIndex = 4;
            this.chkbxUnplayed.Text = "Unplayed Only";
            this.chkbxUnplayed.UseVisualStyleBackColor = true;
            // 
            // listbxMatchup
            // 
            this.listbxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbxMatchup.FormattingEnabled = true;
            this.listbxMatchup.ItemHeight = 37;
            this.listbxMatchup.Location = new System.Drawing.Point(31, 303);
            this.listbxMatchup.Name = "listbxMatchup";
            this.listbxMatchup.Size = new System.Drawing.Size(409, 335);
            this.listbxMatchup.TabIndex = 5;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeam1.Location = new System.Drawing.Point(496, 303);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(217, 46);
            this.lblTeam1.TabIndex = 6;
            this.lblTeam1.Text = "<Team One>";
            // 
            // lblTeam1Score
            // 
            this.lblTeam1Score.AutoSize = true;
            this.lblTeam1Score.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeam1Score.Location = new System.Drawing.Point(496, 374);
            this.lblTeam1Score.Name = "lblTeam1Score";
            this.lblTeam1Score.Size = new System.Drawing.Size(104, 46);
            this.lblTeam1Score.TabIndex = 7;
            this.lblTeam1Score.Text = "Score";
            // 
            // txtbxTeam1Score
            // 
            this.txtbxTeam1Score.Location = new System.Drawing.Point(622, 377);
            this.txtbxTeam1Score.Name = "txtbxTeam1Score";
            this.txtbxTeam1Score.Size = new System.Drawing.Size(100, 43);
            this.txtbxTeam1Score.TabIndex = 8;
            // 
            // txtbxTeam2score
            // 
            this.txtbxTeam2score.Location = new System.Drawing.Point(622, 591);
            this.txtbxTeam2score.Name = "txtbxTeam2score";
            this.txtbxTeam2score.Size = new System.Drawing.Size(100, 43);
            this.txtbxTeam2score.TabIndex = 11;
            // 
            // lblTeam2Score
            // 
            this.lblTeam2Score.AutoSize = true;
            this.lblTeam2Score.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeam2Score.Location = new System.Drawing.Point(496, 588);
            this.lblTeam2Score.Name = "lblTeam2Score";
            this.lblTeam2Score.Size = new System.Drawing.Size(104, 46);
            this.lblTeam2Score.TabIndex = 10;
            this.lblTeam2Score.Text = "Score";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeam2.Location = new System.Drawing.Point(496, 517);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(215, 46);
            this.lblTeam2.TabIndex = 9;
            this.lblTeam2.Text = "<Team Two>";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVersus.Location = new System.Drawing.Point(570, 446);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(87, 46);
            this.lblVersus.TabIndex = 12;
            this.lblVersus.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(711, 446);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(111, 48);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // frmTournViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 679);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.txtbxTeam2score);
            this.Controls.Add(this.lblTeam2Score);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.txtbxTeam1Score);
            this.Controls.Add(this.lblTeam1Score);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.listbxMatchup);
            this.Controls.Add(this.chkbxUnplayed);
            this.Controls.Add(this.ddRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmTournViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox ddRound;
        private System.Windows.Forms.CheckBox chkbxUnplayed;
        private System.Windows.Forms.ListBox listbxMatchup;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblTeam1Score;
        private System.Windows.Forms.TextBox txtbxTeam1Score;
        private System.Windows.Forms.TextBox txtbxTeam2score;
        private System.Windows.Forms.Label lblTeam2Score;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

