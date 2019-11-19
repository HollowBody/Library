namespace SartasovLib.Views
{
    partial class PenaltiesAccountingView
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
            this.TypeDrop = new System.Windows.Forms.ComboBox();
            this.SumField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PenaltiesAccountingGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountsDrop = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltiesAccountingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип";
            // 
            // TypeDrop
            // 
            this.TypeDrop.FormattingEnabled = true;
            this.TypeDrop.Location = new System.Drawing.Point(108, 210);
            this.TypeDrop.Name = "TypeDrop";
            this.TypeDrop.Size = new System.Drawing.Size(270, 21);
            this.TypeDrop.TabIndex = 4;
            // 
            // SumField
            // 
            this.SumField.Location = new System.Drawing.Point(108, 248);
            this.SumField.Name = "SumField";
            this.SumField.Size = new System.Drawing.Size(270, 20);
            this.SumField.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер штрафа";
            // 
            // PenaltiesAccountingGrid
            // 
            this.PenaltiesAccountingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PenaltiesAccountingGrid.Location = new System.Drawing.Point(15, 12);
            this.PenaltiesAccountingGrid.Name = "PenaltiesAccountingGrid";
            this.PenaltiesAccountingGrid.Size = new System.Drawing.Size(799, 150);
            this.PenaltiesAccountingGrid.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Абонемент";
            // 
            // AccountsDrop
            // 
            this.AccountsDrop.FormattingEnabled = true;
            this.AccountsDrop.Location = new System.Drawing.Point(108, 173);
            this.AccountsDrop.Name = "AccountsDrop";
            this.AccountsDrop.Size = new System.Drawing.Size(270, 21);
            this.AccountsDrop.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(384, 171);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(430, 97);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // PenaltiesAccountingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 282);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountsDrop);
            this.Controls.Add(this.PenaltiesAccountingGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeDrop);
            this.Name = "PenaltiesAccountingView";
            this.Text = "PenaltiesAccounting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PenaltiesAccountingViewOnFormClosing);
            this.Load += new System.EventHandler(this.PenaltiesAccountingViewOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PenaltiesAccountingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeDrop;
        private System.Windows.Forms.TextBox SumField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PenaltiesAccountingGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AccountsDrop;
        private System.Windows.Forms.Button AddButton;
    }
}