namespace Diplom
{
    partial class TeamDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TeamTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RosterDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MatchupsDataGridView = new System.Windows.Forms.DataGridView();
            this.TeamLogoBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.TeamTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RosterDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 25);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel3.TabIndex = 17;
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
            this.label2.Location = new System.Drawing.Point(370, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подробности команды";
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
            // TeamTabControl
            // 
            this.TeamTabControl.Controls.Add(this.tabPage1);
            this.TeamTabControl.Controls.Add(this.tabPage2);
            this.TeamTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamTabControl.Location = new System.Drawing.Point(13, 179);
            this.TeamTabControl.Name = "TeamTabControl";
            this.TeamTabControl.SelectedIndex = 0;
            this.TeamTabControl.Size = new System.Drawing.Size(957, 443);
            this.TeamTabControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RosterDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RosterDataGridView
            // 
            this.RosterDataGridView.AllowUserToAddRows = false;
            this.RosterDataGridView.AllowUserToDeleteRows = false;
            this.RosterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RosterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RosterDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RosterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RosterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RosterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.RosterDataGridView.MultiSelect = false;
            this.RosterDataGridView.Name = "RosterDataGridView";
            this.RosterDataGridView.ReadOnly = true;
            this.RosterDataGridView.RowHeadersVisible = false;
            this.RosterDataGridView.RowTemplate.Height = 24;
            this.RosterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RosterDataGridView.Size = new System.Drawing.Size(943, 395);
            this.RosterDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MatchupsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Матчи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MatchupsDataGridView
            // 
            this.MatchupsDataGridView.AllowUserToAddRows = false;
            this.MatchupsDataGridView.AllowUserToDeleteRows = false;
            this.MatchupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatchupsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MatchupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchupsDataGridView.Location = new System.Drawing.Point(6, 7);
            this.MatchupsDataGridView.MultiSelect = false;
            this.MatchupsDataGridView.Name = "MatchupsDataGridView";
            this.MatchupsDataGridView.ReadOnly = true;
            this.MatchupsDataGridView.RowHeadersVisible = false;
            this.MatchupsDataGridView.RowTemplate.Height = 24;
            this.MatchupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MatchupsDataGridView.Size = new System.Drawing.Size(936, 401);
            this.MatchupsDataGridView.TabIndex = 1;
            // 
            // TeamLogoBox
            // 
            this.TeamLogoBox.Location = new System.Drawing.Point(13, 73);
            this.TeamLogoBox.Name = "TeamLogoBox";
            this.TeamLogoBox.Size = new System.Drawing.Size(100, 100);
            this.TeamLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeamLogoBox.TabIndex = 19;
            this.TeamLogoBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(119, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(264, 149);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(171, 24);
            this.SeasonsComboBox.TabIndex = 21;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(451, 145);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(103, 30);
            this.SubmitButton.TabIndex = 22;
            this.SubmitButton.Text = "Применить";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TeamDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SeasonsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamLogoBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TeamTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeamDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробности команды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.TeamTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RosterDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatchupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.TabControl TeamTabControl;
        private System.Windows.Forms.PictureBox TeamLogoBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridView RosterDataGridView;
        private System.Windows.Forms.DataGridView MatchupsDataGridView;
    }
}