namespace SartasovLib.Views
{
    partial class MainMenuView
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
            this.BooksAccountingButton = new System.Windows.Forms.Button();
            this.PenaltiesAccountingButton = new System.Windows.Forms.Button();
            this.PenaltiesButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BooksAccountingButton
            // 
            this.BooksAccountingButton.Location = new System.Drawing.Point(12, 12);
            this.BooksAccountingButton.Name = "BooksAccountingButton";
            this.BooksAccountingButton.Size = new System.Drawing.Size(100, 55);
            this.BooksAccountingButton.TabIndex = 0;
            this.BooksAccountingButton.Text = "Учет Книг";
            this.BooksAccountingButton.UseVisualStyleBackColor = true;
            this.BooksAccountingButton.Click += new System.EventHandler(this.BooksAccountingButtonOnClick);
            // 
            // PenaltiesAccountingButton
            // 
            this.PenaltiesAccountingButton.Location = new System.Drawing.Point(118, 12);
            this.PenaltiesAccountingButton.Name = "PenaltiesAccountingButton";
            this.PenaltiesAccountingButton.Size = new System.Drawing.Size(100, 55);
            this.PenaltiesAccountingButton.TabIndex = 1;
            this.PenaltiesAccountingButton.Text = "Учет Штрафов";
            this.PenaltiesAccountingButton.UseVisualStyleBackColor = true;
            this.PenaltiesAccountingButton.Click += new System.EventHandler(this.PenaltiesAccountingButtonOnClick);
            // 
            // PenaltiesButton
            // 
            this.PenaltiesButton.Location = new System.Drawing.Point(118, 73);
            this.PenaltiesButton.Name = "PenaltiesButton";
            this.PenaltiesButton.Size = new System.Drawing.Size(100, 55);
            this.PenaltiesButton.TabIndex = 3;
            this.PenaltiesButton.Text = "Штрафы";
            this.PenaltiesButton.UseVisualStyleBackColor = true;
            this.PenaltiesButton.Click += new System.EventHandler(this.PenaltiesButtonOnClick);
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(12, 73);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(100, 55);
            this.BooksButton.TabIndex = 2;
            this.BooksButton.Text = "Книги";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButtonOnClick);
            // 
            // AccountsButton
            // 
            this.AccountsButton.Location = new System.Drawing.Point(12, 134);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(206, 55);
            this.AccountsButton.TabIndex = 4;
            this.AccountsButton.Text = "Абонементы";
            this.AccountsButton.UseVisualStyleBackColor = true;
            this.AccountsButton.Click += new System.EventHandler(this.AccountsButtonOnClick);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 202);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.PenaltiesButton);
            this.Controls.Add(this.BooksButton);
            this.Controls.Add(this.PenaltiesAccountingButton);
            this.Controls.Add(this.BooksAccountingButton);
            this.Name = "MainMenuView";
            this.Text = "MainMenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BooksAccountingButton;
        private System.Windows.Forms.Button PenaltiesAccountingButton;
        private System.Windows.Forms.Button PenaltiesButton;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button AccountsButton;
    }
}