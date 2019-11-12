namespace SartasovLib.Views
{
    partial class PenaltiesView
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
            this.PenaltiesGrid = new System.Windows.Forms.DataGridView();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateField = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PenaltiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 253);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // PenaltiesGrid
            // 
            this.PenaltiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PenaltiesGrid.Location = new System.Drawing.Point(15, 39);
            this.PenaltiesGrid.Name = "PenaltiesGrid";
            this.PenaltiesGrid.Size = new System.Drawing.Size(482, 208);
            this.PenaltiesGrid.TabIndex = 4;
            // 
            // TypeField
            // 
            this.TypeField.Location = new System.Drawing.Point(131, 254);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(100, 20);
            this.TypeField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата от";
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(295, 254);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(200, 20);
            this.DateField.TabIndex = 9;
            // 
            // PenaltiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 289);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.PenaltiesGrid);
            this.Controls.Add(this.AddButton);
            this.Name = "PenaltiesView";
            this.Text = "Penalties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PenaltiesViewOnFormClosing);
            this.Load += new System.EventHandler(this.PenaltiesViewOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PenaltiesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView PenaltiesGrid;
        private System.Windows.Forms.TextBox TypeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateField;
    }
}