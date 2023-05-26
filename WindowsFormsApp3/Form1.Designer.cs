namespace WindowsFormsApp3
{
    partial class Form1
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
            this.drivesListBox = new System.Windows.Forms.ListBox();
            this.directoriesListBox = new System.Windows.Forms.ListBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.propertiesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drivesListBox
            // 
            this.drivesListBox.FormattingEnabled = true;
            this.drivesListBox.Location = new System.Drawing.Point(13, 45);
            this.drivesListBox.Name = "drivesListBox";
            this.drivesListBox.Size = new System.Drawing.Size(148, 147);
            this.drivesListBox.TabIndex = 0;
            this.drivesListBox.SelectedIndexChanged += new System.EventHandler(this.drivesListBox_SelectedIndexChanged);
            // 
            // directoriesListBox
            // 
            this.directoriesListBox.FormattingEnabled = true;
            this.directoriesListBox.Location = new System.Drawing.Point(513, 45);
            this.directoriesListBox.Name = "directoriesListBox";
            this.directoriesListBox.Size = new System.Drawing.Size(213, 186);
            this.directoriesListBox.TabIndex = 1;
            this.directoriesListBox.SelectedIndexChanged += new System.EventHandler(this.directoriesListBox_SelectedIndexChanged);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(513, 237);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(213, 186);
            this.filesListBox.TabIndex = 2;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // propertiesTextBox
            // 
            this.propertiesTextBox.Location = new System.Drawing.Point(233, 45);
            this.propertiesTextBox.Multiline = true;
            this.propertiesTextBox.Name = "propertiesTextBox";
            this.propertiesTextBox.Size = new System.Drawing.Size(214, 96);
            this.propertiesTextBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 275);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(381, 163);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(233, 156);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(214, 96);
            this.contentTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.propertiesTextBox);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.directoriesListBox);
            this.Controls.Add(this.drivesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox drivesListBox;
        private System.Windows.Forms.ListBox directoriesListBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.TextBox propertiesTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox contentTextBox;
    }
}

