namespace Анализ_категорий
{
    partial class Column
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
            this.listBox_Column = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBox_Column
            // 
            this.listBox_Column.FormattingEnabled = true;
            this.listBox_Column.Location = new System.Drawing.Point(28, 83);
            this.listBox_Column.Name = "listBox_Column";
            this.listBox_Column.Size = new System.Drawing.Size(734, 526);
            this.listBox_Column.TabIndex = 0;
            // 
            // Column
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 680);
            this.Controls.Add(this.listBox_Column);
            this.Name = "Column";
            this.Text = "Column";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox listBox_Column;
    }
}