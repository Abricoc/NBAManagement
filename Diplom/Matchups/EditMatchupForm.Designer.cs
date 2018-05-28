namespace Diplom
{
    partial class EditMatchupForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.HomeScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamsAwayComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.PhotoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AwayScore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TeamsHomeComboBox = new System.Windows.Forms.ComboBox();
            this.BeginMatchupPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.MatchupTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditMatchupButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelTeamButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(536, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 29);
            this.label8.TabIndex = 108;
            this.label8.Text = "Счёт гостевой команды";
            // 
            // HomeScore
            // 
            this.HomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeScore.Location = new System.Drawing.Point(541, 124);
            this.HomeScore.MaxLength = 3;
            this.HomeScore.Name = "HomeScore";
            this.HomeScore.Size = new System.Drawing.Size(415, 36);
            this.HomeScore.TabIndex = 107;
            this.HomeScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HomeScore_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(536, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 29);
            this.label6.TabIndex = 106;
            this.label6.Text = "Счёт домашней команды";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 105;
            this.label5.Text = "Гостевая команда";
            // 
            // TeamsAwayComboBox
            // 
            this.TeamsAwayComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.TeamsAwayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamsAwayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsAwayComboBox.ForeColor = System.Drawing.Color.White;
            this.TeamsAwayComboBox.FormattingEnabled = true;
            this.TeamsAwayComboBox.Location = new System.Drawing.Point(17, 518);
            this.TeamsAwayComboBox.Name = "TeamsAwayComboBox";
            this.TeamsAwayComboBox.Size = new System.Drawing.Size(468, 37);
            this.TeamsAwayComboBox.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 99;
            this.label3.Text = "Сезон";
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.SeasonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeasonsComboBox.ForeColor = System.Drawing.Color.White;
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(17, 123);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(468, 37);
            this.SeasonsComboBox.TabIndex = 97;
            // 
            // PhotoFileDialog
            // 
            this.PhotoFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp,*.jpeg";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(378, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Редактирование матча";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Titlelabel.Location = new System.Drawing.Point(42, 30);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(226, 24);
            this.Titlelabel.TabIndex = 9;
            this.Titlelabel.Text = "NBA Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.FooterLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 25);
            this.panel1.TabIndex = 92;
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
            // AwayScore
            // 
            this.AwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AwayScore.Location = new System.Drawing.Point(541, 232);
            this.AwayScore.MaxLength = 3;
            this.AwayScore.Name = "AwayScore";
            this.AwayScore.Size = new System.Drawing.Size(415, 36);
            this.AwayScore.TabIndex = 109;
            this.AwayScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HomeScore_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 29);
            this.label9.TabIndex = 103;
            this.label9.Text = "Домашняя команда";
            // 
            // TeamsHomeComboBox
            // 
            this.TeamsHomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamsHomeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsHomeComboBox.FormattingEnabled = true;
            this.TeamsHomeComboBox.Location = new System.Drawing.Point(17, 413);
            this.TeamsHomeComboBox.Name = "TeamsHomeComboBox";
            this.TeamsHomeComboBox.Size = new System.Drawing.Size(468, 37);
            this.TeamsHomeComboBox.TabIndex = 102;
            // 
            // BeginMatchupPicker
            // 
            this.BeginMatchupPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginMatchupPicker.Location = new System.Drawing.Point(17, 313);
            this.BeginMatchupPicker.Name = "BeginMatchupPicker";
            this.BeginMatchupPicker.Size = new System.Drawing.Size(468, 36);
            this.BeginMatchupPicker.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 100;
            this.label7.Text = "Тип матча";
            // 
            // MatchupTypesComboBox
            // 
            this.MatchupTypesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.MatchupTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchupTypesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchupTypesComboBox.ForeColor = System.Drawing.Color.White;
            this.MatchupTypesComboBox.FormattingEnabled = true;
            this.MatchupTypesComboBox.Location = new System.Drawing.Point(17, 214);
            this.MatchupTypesComboBox.Name = "MatchupTypesComboBox";
            this.MatchupTypesComboBox.Size = new System.Drawing.Size(468, 37);
            this.MatchupTypesComboBox.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "Дата матча";
            // 
            // EditMatchupButton
            // 
            this.EditMatchupButton.AutoEllipsis = true;
            this.EditMatchupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.EditMatchupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditMatchupButton.ForeColor = System.Drawing.Color.White;
            this.EditMatchupButton.Location = new System.Drawing.Point(541, 558);
            this.EditMatchupButton.Name = "EditMatchupButton";
            this.EditMatchupButton.Size = new System.Drawing.Size(181, 46);
            this.EditMatchupButton.TabIndex = 94;
            this.EditMatchupButton.Text = "Изменить";
            this.EditMatchupButton.UseVisualStyleBackColor = false;
            this.EditMatchupButton.Click += new System.EventHandler(this.EditMatchupButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Titlelabel);
            this.panel3.Controls.Add(this.LogoPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 60);
            this.panel3.TabIndex = 93;
            // 
            // CancelTeamButton
            // 
            this.CancelTeamButton.AutoEllipsis = true;
            this.CancelTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.CancelTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelTeamButton.ForeColor = System.Drawing.Color.White;
            this.CancelTeamButton.Location = new System.Drawing.Point(775, 558);
            this.CancelTeamButton.Name = "CancelTeamButton";
            this.CancelTeamButton.Size = new System.Drawing.Size(181, 46);
            this.CancelTeamButton.TabIndex = 95;
            this.CancelTeamButton.Text = "Отменить";
            this.CancelTeamButton.UseVisualStyleBackColor = false;
            this.CancelTeamButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditMatchupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HomeScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamsAwayComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SeasonsComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AwayScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TeamsHomeComboBox);
            this.Controls.Add(this.BeginMatchupPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MatchupTypesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditMatchupButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CancelTeamButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditMatchupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование матча";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMatchupForm_FormClosing);
            this.Load += new System.EventHandler(this.EditMatchupForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HomeScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TeamsAwayComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.OpenFileDialog PhotoFileDialog;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.TextBox AwayScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TeamsHomeComboBox;
        private System.Windows.Forms.DateTimePicker BeginMatchupPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MatchupTypesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditMatchupButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CancelTeamButton;
    }
}