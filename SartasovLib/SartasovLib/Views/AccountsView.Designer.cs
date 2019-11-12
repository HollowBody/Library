namespace SartasovLib.Views
{
    partial class AccountsView
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
            this.AddButton = new System.Windows.Forms.Button();
            this.AccountsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SurNameField = new System.Windows.Forms.TextBox();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.SerialField = new System.Windows.Forms.TextBox();
            this.NumberField = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 274);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // AccountsGrid
            // 
            this.AccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGrid.Location = new System.Drawing.Point(12, 12);
            this.AccountsGrid.Name = "AccountsGrid";
            this.AccountsGrid.Size = new System.Drawing.Size(630, 256);
            this.AccountsGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Серия";
            // 
            // SurNameField
            // 
            this.SurNameField.Location = new System.Drawing.Point(313, 276);
            this.SurNameField.Name = "SurNameField";
            this.SurNameField.Size = new System.Drawing.Size(100, 20);
            this.SurNameField.TabIndex = 7;
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(313, 300);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(100, 20);
            this.FirstNameField.TabIndex = 8;
            // 
            // SerialField
            // 
            this.SerialField.Location = new System.Drawing.Point(313, 325);
            this.SerialField.Name = "SerialField";
            this.SerialField.Size = new System.Drawing.Size(100, 20);
            this.SerialField.TabIndex = 9;
            // 
            // NumberField
            // 
            this.NumberField.Location = new System.Drawing.Point(313, 352);
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(100, 20);
            this.NumberField.TabIndex = 10;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(12, 350);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 11;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButtonOnClick);
            // 
            // AccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 377);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.SerialField);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.SurNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountsGrid);
            this.Controls.Add(this.AddButton);
            this.Name = "AccountsView";
            this.Text = "Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountsViewOnFormClosing);
            this.Load += new System.EventHandler(this.AccountsViewOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView AccountsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurNameField;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox SerialField;
        private System.Windows.Forms.TextBox NumberField;
        private System.Windows.Forms.Button ChangeButton;
    }
}