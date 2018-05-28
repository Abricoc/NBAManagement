namespace Diplom
{
    partial class VisitorMenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.PhotosButton = new System.Windows.Forms.Button();
            this.MatchupsButton = new System.Windows.Forms.Button();
            this.PlayersButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.FooterLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 25);
            this.panel1.TabIndex = 6;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterLabel.ForeColor = System.Drawing.Color.White;
            this.FooterLabel.Location = new System.Drawing.Point(0, 0);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(982, 25);
            this.FooterLabel.TabIndex = 0;
            this.FooterLabel.Text = "label1";
            this.FooterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavigationPanel.Controls.Add(this.PhotosButton);
            this.NavigationPanel.Controls.Add(this.MatchupsButton);
            this.NavigationPanel.Controls.Add(this.PlayersButton);
            this.NavigationPanel.Controls.Add(this.TeamButton);
            this.NavigationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavigationPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NavigationPanel.Location = new System.Drawing.Point(58, 151);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(868, 370);
            this.NavigationPanel.TabIndex = 10;
            // 
            // PhotosButton
            // 
            this.PhotosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.PhotosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhotosButton.ForeColor = System.Drawing.Color.White;
            this.PhotosButton.Location = new System.Drawing.Point(536, 251);
            this.PhotosButton.Name = "PhotosButton";
            this.PhotosButton.Size = new System.Drawing.Size(259, 66);
            this.PhotosButton.TabIndex = 3;
            this.PhotosButton.Text = "Фотографии";
            this.PhotosButton.UseVisualStyleBackColor = false;
            this.PhotosButton.Click += new System.EventHandler(this.PhotosButton_Click);
            // 
            // MatchupsButton
            // 
            this.MatchupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.MatchupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchupsButton.ForeColor = System.Drawing.Color.White;
            this.MatchupsButton.Location = new System.Drawing.Point(69, 251);
            this.MatchupsButton.Name = "MatchupsButton";
            this.MatchupsButton.Size = new System.Drawing.Size(259, 66);
            this.MatchupsButton.TabIndex = 2;
            this.MatchupsButton.Text = "Матчи";
            this.MatchupsButton.UseVisualStyleBackColor = false;
            this.MatchupsButton.Click += new System.EventHandler(this.MatchupsButton_Click);
            // 
            // PlayersButton
            // 
            this.PlayersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.PlayersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersButton.ForeColor = System.Drawing.Color.White;
            this.PlayersButton.Location = new System.Drawing.Point(536, 54);
            this.PlayersButton.Name = "PlayersButton";
            this.PlayersButton.Size = new System.Drawing.Size(259, 66);
            this.PlayersButton.TabIndex = 1;
            this.PlayersButton.Text = "Игроки";
            this.PlayersButton.UseVisualStyleBackColor = false;
            this.PlayersButton.Click += new System.EventHandler(this.PlayersButton_Click);
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.TeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamButton.ForeColor = System.Drawing.Color.White;
            this.TeamButton.Location = new System.Drawing.Point(69, 54);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(259, 66);
            this.TeamButton.TabIndex = 0;
            this.TeamButton.Text = "Команды";
            this.TeamButton.UseVisualStyleBackColor = false;
            this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Controls.Add(this.Titlelabel);
            this.panel3.Controls.Add(this.ProgramNameLabel);
            this.panel3.Controls.Add(this.LogoPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 60);
            this.panel3.TabIndex = 11;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(895, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 31);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Titlelabel.Location = new System.Drawing.Point(378, 18);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(204, 31);
            this.Titlelabel.TabIndex = 10;
            this.Titlelabel.Text = "Меню посетителя";
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProgramNameLabel.Location = new System.Drawing.Point(42, 30);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(226, 24);
            this.ProgramNameLabel.TabIndex = 9;
            this.ProgramNameLabel.Text = "NBA Management System";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Diplom.Properties.Resources.logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(5, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(38, 54);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 8;
            this.LogoPictureBox.TabStop = false;
            // 
            // VisitorMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VisitorMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню посетителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitorMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.VisitorMenu_Load);
            this.panel1.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button PhotosButton;
        private System.Windows.Forms.Button MatchupsButton;
        private System.Windows.Forms.Button PlayersButton;
        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}