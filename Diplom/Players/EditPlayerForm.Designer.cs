namespace Diplom
{
    partial class EditPlayerForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.TeamsComboBox = new System.Windows.Forms.ComboBox();
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.NumericUpDown();
            this.JoinYearPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.EditPlayerButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelTeamButton = new System.Windows.Forms.Button();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhotoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(501, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 29);
            this.label9.TabIndex = 84;
            this.label9.Text = "Команда";
            // 
            // TeamsComboBox
            // 
            this.TeamsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsComboBox.FormattingEnabled = true;
            this.TeamsComboBox.Location = new System.Drawing.Point(506, 501);
            this.TeamsComboBox.Name = "TeamsComboBox";
            this.TeamsComboBox.Size = new System.Drawing.Size(468, 37);
            this.TeamsComboBox.TabIndex = 83;
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDayPicker.Location = new System.Drawing.Point(506, 409);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(468, 36);
            this.BirthDayPicker.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(501, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 29);
            this.label8.TabIndex = 80;
            this.label8.Text = "Дата рождения";
            // 
            // WeightBox
            // 
            this.WeightBox.DecimalPlaces = 2;
            this.WeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightBox.Location = new System.Drawing.Point(17, 542);
            this.WeightBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(468, 36);
            this.WeightBox.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 78;
            this.label6.Text = "Вес";
            // 
            // HeightBox
            // 
            this.HeightBox.DecimalPlaces = 2;
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HeightBox.Location = new System.Drawing.Point(17, 435);
            this.HeightBox.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(468, 36);
            this.HeightBox.TabIndex = 77;
            // 
            // JoinYearPicker
            // 
            this.JoinYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JoinYearPicker.Location = new System.Drawing.Point(17, 313);
            this.JoinYearPicker.Name = "JoinYearPicker";
            this.JoinYearPicker.Size = new System.Drawing.Size(468, 36);
            this.JoinYearPicker.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "Позиция";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionComboBox.ForeColor = System.Drawing.Color.White;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(17, 214);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(468, 37);
            this.PositionComboBox.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 73;
            this.label5.Text = "Рост";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 72;
            this.label4.Text = "Начало карьеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "ФИО";
            // 
            // FIOBox
            // 
            this.FIOBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOBox.Location = new System.Drawing.Point(17, 126);
            this.FIOBox.MaxLength = 50;
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(468, 36);
            this.FIOBox.TabIndex = 70;
            // 
            // EditPlayerButton
            // 
            this.EditPlayerButton.AutoEllipsis = true;
            this.EditPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.EditPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPlayerButton.ForeColor = System.Drawing.Color.White;
            this.EditPlayerButton.Location = new System.Drawing.Point(541, 558);
            this.EditPlayerButton.Name = "EditPlayerButton";
            this.EditPlayerButton.Size = new System.Drawing.Size(181, 46);
            this.EditPlayerButton.TabIndex = 68;
            this.EditPlayerButton.Text = "Изменить";
            this.EditPlayerButton.UseVisualStyleBackColor = false;
            this.EditPlayerButton.Click += new System.EventHandler(this.EditPlayerButton_Click);
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
            this.panel3.TabIndex = 67;
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
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Изменение игрока";
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
            // CancelTeamButton
            // 
            this.CancelTeamButton.AutoEllipsis = true;
            this.CancelTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.CancelTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelTeamButton.ForeColor = System.Drawing.Color.White;
            this.CancelTeamButton.Location = new System.Drawing.Point(775, 558);
            this.CancelTeamButton.Name = "CancelTeamButton";
            this.CancelTeamButton.Size = new System.Drawing.Size(181, 46);
            this.CancelTeamButton.TabIndex = 69;
            this.CancelTeamButton.Text = "Отменить";
            this.CancelTeamButton.UseVisualStyleBackColor = false;
            this.CancelTeamButton.Click += new System.EventHandler(this.BackButton_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.FooterLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 25);
            this.panel1.TabIndex = 66;
            // 
            // PhotoFileDialog
            // 
            this.PhotoFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp,*.jpeg";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::Diplom.Properties.Resources.person;
            this.PhotoBox.Location = new System.Drawing.Point(658, 91);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(228, 219);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 82;
            this.PhotoBox.TabStop = false;
            this.PhotoBox.Click += new System.EventHandler(this.PhotoBox_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(306, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Для изменения фотографии нажмите на неё";
            // 
            // EditPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TeamsComboBox);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.BirthDayPicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.JoinYearPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.EditPlayerButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CancelTeamButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить игрока";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPlayerForm_FormClosing);
            this.Load += new System.EventHandler(this.EditPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TeamsComboBox;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.DateTimePicker BirthDayPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown WeightBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown HeightBox;
        private System.Windows.Forms.DateTimePicker JoinYearPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.Button EditPlayerButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button CancelTeamButton;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog PhotoFileDialog;
        private System.Windows.Forms.Label label10;
    }
}