namespace SartasovLib
{
    partial class BooksView
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
            this.AddButton = new System.Windows.Forms.Button();
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IssueDateField = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(702, 265);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // BooksGrid
            // 
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Location = new System.Drawing.Point(12, 12);
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.Size = new System.Drawing.Size(765, 247);
            this.BooksGrid.TabIndex = 1;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(75, 266);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 2;
            // 
            // AuthorField
            // 
            this.AuthorField.Location = new System.Drawing.Point(224, 266);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(100, 20);
            this.AuthorField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год";
            // 
            // CostField
            // 
            this.CostField.Location = new System.Drawing.Point(596, 267);
            this.CostField.Name = "CostField";
            this.CostField.Size = new System.Drawing.Size(100, 20);
            this.CostField.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена";
            // 
            // IssueDateField
            // 
            this.IssueDateField.Location = new System.Drawing.Point(361, 266);
            this.IssueDateField.Name = "IssueDateField";
            this.IssueDateField.Size = new System.Drawing.Size(190, 20);
            this.IssueDateField.TabIndex = 11;
            // 
            // BooksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 293);
            this.Controls.Add(this.IssueDateField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.BooksGrid);
            this.Controls.Add(this.AddButton);
            this.Name = "BooksView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BooksViewOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox AuthorField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CostField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker IssueDateField;
    }
}

