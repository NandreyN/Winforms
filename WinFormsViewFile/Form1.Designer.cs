namespace WinFormsViewFile
{
    partial class Form1
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
            this.Choose = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.MainSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(308, 267);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(110, 23);
            this.Choose.TabIndex = 0;
            this.Choose.Text = "Choose";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(406, 203);
            this.textBox.TabIndex = 1;
            // 
            // MainSearch
            // 
            this.MainSearch.Location = new System.Drawing.Point(12, 241);
            this.MainSearch.Name = "MainSearch";
            this.MainSearch.Size = new System.Drawing.Size(406, 20);
            this.MainSearch.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(13, 266);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(97, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 302);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainSearch);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Choose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox MainSearch;
        private System.Windows.Forms.Button SearchButton;
    }
}

