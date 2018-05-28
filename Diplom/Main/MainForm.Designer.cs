namespace Diplom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.VisitorButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Image3 = new System.Windows.Forms.PictureBox();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Titlelabel.Location = new System.Drawing.Point(255, 58);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(468, 51);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "NBA Management System";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionLabel.Location = new System.Drawing.Point(53, 131);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(865, 50);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "              Добро пожаловать для использования этой системы управления НБА, вы " +
    "можете \r\nперейти на различные страницы в соответствии с вашей ролью, нажав на кн" +
    "опки ниже.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AdminButton);
            this.panel2.Controls.Add(this.VisitorButton);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(246, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 214);
            this.panel2.TabIndex = 4;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(324, 71);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(170, 66);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Администратор";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // VisitorButton
            // 
            this.VisitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.VisitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitorButton.ForeColor = System.Drawing.Color.White;
            this.VisitorButton.Location = new System.Drawing.Point(39, 70);
            this.VisitorButton.Name = "VisitorButton";
            this.VisitorButton.Size = new System.Drawing.Size(170, 66);
            this.VisitorButton.TabIndex = 0;
            this.VisitorButton.Text = "Посетитель";
            this.VisitorButton.UseVisualStyleBackColor = false;
            this.VisitorButton.Click += new System.EventHandler(this.VisitorButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Image3);
            this.panel3.Controls.Add(this.Image2);
            this.panel3.Controls.Add(this.Image1);
            this.panel3.Controls.Add(this.NextButton);
            this.panel3.Controls.Add(this.ForwardButton);
            this.panel3.Location = new System.Drawing.Point(13, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 143);
            this.panel3.TabIndex = 5;
            // 
            // Image3
            // 
            this.Image3.Location = new System.Drawing.Point(636, 4);
            this.Image3.Name = "Image3";
            this.Image3.Size = new System.Drawing.Size(235, 134);
            this.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image3.TabIndex = 4;
            this.Image3.TabStop = false;
            // 
            // Image2
            // 
            this.Image2.Location = new System.Drawing.Point(363, 4);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(235, 134);
            this.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image2.TabIndex = 3;
            this.Image2.TabStop = false;
            // 
            // Image1
            // 
            this.Image1.Location = new System.Drawing.Point(86, 4);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(235, 134);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 2;
            this.Image1.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(877, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 134);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardButton.Location = new System.Drawing.Point(4, 4);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 134);
            this.ForwardButton.TabIndex = 0;
            this.ForwardButton.Text = "<";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Diplom.Properties.Resources.logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(13, 13);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(83, 132);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button VisitorButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.PictureBox Image3;
        private System.Windows.Forms.PictureBox Image2;
        private System.Windows.Forms.PictureBox Image1;
    }
}

