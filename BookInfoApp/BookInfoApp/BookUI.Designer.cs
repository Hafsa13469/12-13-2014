namespace BookInfoApp
{
    partial class BookUI
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
            this.isbnAddTextBox = new System.Windows.Forms.TextBox();
            this.detailAddTextBox = new System.Windows.Forms.TextBox();
            this.isbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.isbnDetailTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isbnAddTextBox
            // 
            this.isbnAddTextBox.Location = new System.Drawing.Point(120, 33);
            this.isbnAddTextBox.Name = "isbnAddTextBox";
            this.isbnAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.isbnAddTextBox.TabIndex = 0;
            // 
            // detailAddTextBox
            // 
            this.detailAddTextBox.Location = new System.Drawing.Point(120, 87);
            this.detailAddTextBox.Multiline = true;
            this.detailAddTextBox.Name = "detailAddTextBox";
            this.detailAddTextBox.Size = new System.Drawing.Size(100, 58);
            this.detailAddTextBox.TabIndex = 1;
            // 
            // isbnSearchTextBox
            // 
            this.isbnSearchTextBox.Location = new System.Drawing.Point(120, 166);
            this.isbnSearchTextBox.Name = "isbnSearchTextBox";
            this.isbnSearchTextBox.Size = new System.Drawing.Size(128, 20);
            this.isbnSearchTextBox.TabIndex = 3;
            // 
            // isbnDetailTextBox
            // 
            this.isbnDetailTextBox.Location = new System.Drawing.Point(120, 217);
            this.isbnDetailTextBox.Multiline = true;
            this.isbnDetailTextBox.Name = "isbnDetailTextBox";
            this.isbnDetailTextBox.Size = new System.Drawing.Size(128, 97);
            this.isbnDetailTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(268, 40);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(278, 331);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // BookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 438);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.isbnDetailTextBox);
            this.Controls.Add(this.isbnSearchTextBox);
            this.Controls.Add(this.detailAddTextBox);
            this.Controls.Add(this.isbnAddTextBox);
            this.Name = "BookUI";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isbnAddTextBox;
        private System.Windows.Forms.TextBox detailAddTextBox;
        private System.Windows.Forms.TextBox isbnSearchTextBox;
        private System.Windows.Forms.TextBox isbnDetailTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

