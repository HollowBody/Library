namespace SartasovLib.Views
{
    partial class AccountingView
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
            this.AccountingGrid = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AccountsDrop = new System.Windows.Forms.ComboBox();
            this.BookDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.IssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CompletionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountingGrid
            // 
            this.AccountingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountingGrid.Location = new System.Drawing.Point(12, 12);
            this.AccountingGrid.Name = "AccountingGrid";
            this.AccountingGrid.Size = new System.Drawing.Size(776, 266);
            this.AccountingGrid.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 284);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 313);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonOnClick);
            // 
            // AccountsDrop
            // 
            this.AccountsDrop.FormattingEnabled = true;
            this.AccountsDrop.Location = new System.Drawing.Point(161, 283);
            this.AccountsDrop.Name = "AccountsDrop";
            this.AccountsDrop.Size = new System.Drawing.Size(387, 21);
            this.AccountsDrop.TabIndex = 3;
            // 
            // BookDrop
            // 
            this.BookDrop.FormattingEnabled = true;
            this.BookDrop.Location = new System.Drawing.Point(161, 310);
            this.BookDrop.Name = "BookDrop";
            this.BookDrop.Size = new System.Drawing.Size(387, 21);
            this.BookDrop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Абонемент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Книга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата выдачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата сдачи";
            // 
            // TypeField
            // 
            this.TypeField.Location = new System.Drawing.Point(161, 337);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(125, 20);
            this.TypeField.TabIndex = 10;
            // 
            // IssueDatePicker
            // 
            this.IssueDatePicker.Location = new System.Drawing.Point(161, 363);
            this.IssueDatePicker.Name = "IssueDatePicker";
            this.IssueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.IssueDatePicker.TabIndex = 11;
            // 
            // CompletionDatePicker
            // 
            this.CompletionDatePicker.Location = new System.Drawing.Point(161, 389);
            this.CompletionDatePicker.Name = "CompletionDatePicker";
            this.CompletionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.CompletionDatePicker.TabIndex = 12;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(12, 415);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(75, 23);
            this.Report.TabIndex = 13;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.ReportOnClick);
            // 
            // AccountingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.CompletionDatePicker);
            this.Controls.Add(this.IssueDatePicker);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookDrop);
            this.Controls.Add(this.AccountsDrop);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AccountingGrid);
            this.Name = "AccountingView";
            this.Text = "Accounting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountingViewOnFormClosing);
            this.Load += new System.EventHandler(this.AccountingViewOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AccountingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountingGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox AccountsDrop;
        private System.Windows.Forms.ComboBox BookDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TypeField;
        private System.Windows.Forms.DateTimePicker IssueDatePicker;
        private System.Windows.Forms.DateTimePicker CompletionDatePicker;
        private System.Windows.Forms.Button Report;
    }
}