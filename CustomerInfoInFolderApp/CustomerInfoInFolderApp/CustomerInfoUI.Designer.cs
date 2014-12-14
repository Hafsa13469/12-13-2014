namespace CustomerInfoInFolderApp
{
    partial class CustomerInfoUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerInfoSaveTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Info";
            // 
            // CustomerInfoSaveTextBox
            // 
            this.CustomerInfoSaveTextBox.Location = new System.Drawing.Point(111, 47);
            this.CustomerInfoSaveTextBox.Multiline = true;
            this.CustomerInfoSaveTextBox.Name = "CustomerInfoSaveTextBox";
            this.CustomerInfoSaveTextBox.Size = new System.Drawing.Size(168, 37);
            this.CustomerInfoSaveTextBox.TabIndex = 1;
            this.CustomerInfoSaveTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(346, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(350, 156);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(111, 134);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(168, 134);
            this.nameListBox.TabIndex = 5;
            // 
            // CustomerInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 483);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.CustomerInfoSaveTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInfoUI";
            this.Text = "CustomerInfoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerInfoSaveTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox nameListBox;
    }
}

