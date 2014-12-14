namespace DictionaryApp
{
    partial class StudentInfoUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idInputText = new System.Windows.Forms.TextBox();
            this.idSearchText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.detailsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id";
            // 
            // idInputText
            // 
            this.idInputText.Location = new System.Drawing.Point(55, 22);
            this.idInputText.Name = "idInputText";
            this.idInputText.Size = new System.Drawing.Size(100, 20);
            this.idInputText.TabIndex = 0;
            // 
            // idSearchText
            // 
            this.idSearchText.Location = new System.Drawing.Point(55, 168);
            this.idSearchText.Name = "idSearchText";
            this.idSearchText.Size = new System.Drawing.Size(100, 20);
            this.idSearchText.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(200, 128);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(200, 164);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(72, 206);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(103, 36);
            this.ShowAllButton.TabIndex = 5;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // detailsText
            // 
            this.detailsText.Location = new System.Drawing.Point(55, 57);
            this.detailsText.Multiline = true;
            this.detailsText.Name = "detailsText";
            this.detailsText.Size = new System.Drawing.Size(100, 73);
            this.detailsText.TabIndex = 1;
            // 
            // StudentInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.detailsText);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.idSearchText);
            this.Controls.Add(this.idInputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentInfoUI";
            this.Text = "StudentInfoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idInputText;
        private System.Windows.Forms.TextBox idSearchText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.TextBox detailsText;
    }
}

