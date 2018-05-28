﻿namespace Diplom
{
    partial class ManageMatchupsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteMatchupButton = new System.Windows.Forms.Button();
            this.EditMatchupButton = new System.Windows.Forms.Button();
            this.AddMatchupButton = new System.Windows.Forms.Button();
            this.MatchupsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchupsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.TabIndex = 25;
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
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Управление матчами";
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
            // DeleteMatchupButton
            // 
            this.DeleteMatchupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.DeleteMatchupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMatchupButton.ForeColor = System.Drawing.Color.White;
            this.DeleteMatchupButton.Location = new System.Drawing.Point(287, 79);
            this.DeleteMatchupButton.Name = "DeleteMatchupButton";
            this.DeleteMatchupButton.Size = new System.Drawing.Size(121, 66);
            this.DeleteMatchupButton.TabIndex = 22;
            this.DeleteMatchupButton.Text = "Удалить";
            this.DeleteMatchupButton.UseVisualStyleBackColor = false;
            this.DeleteMatchupButton.Click += new System.EventHandler(this.DeleteMatchupButton_Click);
            // 
            // EditMatchupButton
            // 
            this.EditMatchupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.EditMatchupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditMatchupButton.ForeColor = System.Drawing.Color.White;
            this.EditMatchupButton.Location = new System.Drawing.Point(146, 79);
            this.EditMatchupButton.Name = "EditMatchupButton";
            this.EditMatchupButton.Size = new System.Drawing.Size(135, 66);
            this.EditMatchupButton.TabIndex = 23;
            this.EditMatchupButton.Text = "Изменить";
            this.EditMatchupButton.UseVisualStyleBackColor = false;
            this.EditMatchupButton.Click += new System.EventHandler(this.EditMatchupButton_Click);
            // 
            // AddMatchupButton
            // 
            this.AddMatchupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.AddMatchupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMatchupButton.ForeColor = System.Drawing.Color.White;
            this.AddMatchupButton.Location = new System.Drawing.Point(10, 79);
            this.AddMatchupButton.Name = "AddMatchupButton";
            this.AddMatchupButton.Size = new System.Drawing.Size(130, 66);
            this.AddMatchupButton.TabIndex = 21;
            this.AddMatchupButton.Text = "Добавить";
            this.AddMatchupButton.UseVisualStyleBackColor = false;
            this.AddMatchupButton.Click += new System.EventHandler(this.AddMatchupButton_Click);
            // 
            // MatchupsDataGridView
            // 
            this.MatchupsDataGridView.AllowUserToAddRows = false;
            this.MatchupsDataGridView.AllowUserToDeleteRows = false;
            this.MatchupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatchupsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MatchupsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchupsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MatchupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchupsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatchupsDataGridView.Location = new System.Drawing.Point(10, 151);
            this.MatchupsDataGridView.MultiSelect = false;
            this.MatchupsDataGridView.Name = "MatchupsDataGridView";
            this.MatchupsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchupsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MatchupsDataGridView.RowHeadersVisible = false;
            this.MatchupsDataGridView.RowTemplate.Height = 24;
            this.MatchupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MatchupsDataGridView.Size = new System.Drawing.Size(960, 471);
            this.MatchupsDataGridView.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 25);
            this.panel1.TabIndex = 24;
            // 
            // ManageMatchupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteMatchupButton);
            this.Controls.Add(this.EditMatchupButton);
            this.Controls.Add(this.AddMatchupButton);
            this.Controls.Add(this.MatchupsDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageMatchupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление матчами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageMatchupsForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageMatchupsForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchupsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button DeleteMatchupButton;
        private System.Windows.Forms.Button EditMatchupButton;
        private System.Windows.Forms.Button AddMatchupButton;
        private System.Windows.Forms.DataGridView MatchupsDataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}