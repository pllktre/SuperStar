namespace Анализ_категорий
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вкладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вкладкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DateReport = new MetroFramework.Controls.MetroComboBox();
            this.labelPeroid1 = new System.Windows.Forms.Label();
            this.DatePeriod1 = new System.Windows.Forms.Label();
            this.labelParameter = new System.Windows.Forms.Label();
            this.labelReport = new System.Windows.Forms.Label();
            this.DatePeriod2 = new System.Windows.Forms.Label();
            this.labelPeroid2 = new System.Windows.Forms.Label();
            this.DatePeriod3 = new System.Windows.Forms.Label();
            this.labelPeroid3 = new System.Windows.Forms.Label();
            this.labelPeroidPrice = new System.Windows.Forms.Label();
            this.DatePeriodPrice = new System.Windows.Forms.Label();
            this.labelProcent = new System.Windows.Forms.Label();
            this.ProcentPrize = new System.Windows.Forms.Label();
            this.CoeffTax = new System.Windows.Forms.Label();
            this.labelCoeff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вкладкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вкладкаToolStripMenuItem
            // 
            this.вкладкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вкладкаToolStripMenuItem1});
            this.вкладкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.вкладкаToolStripMenuItem.Name = "вкладкаToolStripMenuItem";
            this.вкладкаToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.вкладкаToolStripMenuItem.Text = "Вкладка";
            // 
            // вкладкаToolStripMenuItem1
            // 
            this.вкладкаToolStripMenuItem1.Name = "вкладкаToolStripMenuItem1";
            this.вкладкаToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.вкладкаToolStripMenuItem1.Text = "Вкладка";
            // 
            // DateReport
            // 
            this.DateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateReport.FormattingEnabled = true;
            this.DateReport.ItemHeight = 23;
            this.DateReport.Location = new System.Drawing.Point(32, 126);
            this.DateReport.MaximumSize = new System.Drawing.Size(164, 0);
            this.DateReport.Name = "DateReport";
            this.DateReport.Size = new System.Drawing.Size(149, 29);
            this.DateReport.TabIndex = 1;
            this.DateReport.SelectedIndexChanged += new System.EventHandler(this.DateReport_SelectedIndexChanged);
            this.DateReport.SelectionChangeCommitted += new System.EventHandler(this.DateReport_SelectionChangeCommitted);
            // 
            // labelPeroid1
            // 
            this.labelPeroid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeroid1.AutoSize = true;
            this.labelPeroid1.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeroid1.Location = new System.Drawing.Point(264, 123);
            this.labelPeroid1.Name = "labelPeroid1";
            this.labelPeroid1.Size = new System.Drawing.Size(68, 20);
            this.labelPeroid1.TabIndex = 11;
            this.labelPeroid1.Text = "Период 1";
            // 
            // DatePeriod1
            // 
            this.DatePeriod1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePeriod1.AutoSize = true;
            this.DatePeriod1.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePeriod1.ForeColor = System.Drawing.Color.DarkBlue;
            this.DatePeriod1.Location = new System.Drawing.Point(264, 150);
            this.DatePeriod1.Name = "DatePeriod1";
            this.DatePeriod1.Size = new System.Drawing.Size(143, 20);
            this.DatePeriod1.TabIndex = 13;
            this.DatePeriod1.Text = "с 31.01.23 по 01.02.23";
            // 
            // labelParameter
            // 
            this.labelParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParameter.AutoSize = true;
            this.labelParameter.BackColor = System.Drawing.Color.Transparent;
            this.labelParameter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParameter.Location = new System.Drawing.Point(264, 94);
            this.labelParameter.Name = "labelParameter";
            this.labelParameter.Size = new System.Drawing.Size(144, 21);
            this.labelParameter.TabIndex = 14;
            this.labelParameter.Text = "Параметры отчета";
            // 
            // labelReport
            // 
            this.labelReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReport.AutoSize = true;
            this.labelReport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReport.Location = new System.Drawing.Point(27, 94);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(178, 21);
            this.labelReport.TabIndex = 15;
            this.labelReport.Text = "Дата отчета СуперСтар";
            // 
            // DatePeriod2
            // 
            this.DatePeriod2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePeriod2.AutoSize = true;
            this.DatePeriod2.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePeriod2.ForeColor = System.Drawing.Color.DarkBlue;
            this.DatePeriod2.Location = new System.Drawing.Point(518, 150);
            this.DatePeriod2.Name = "DatePeriod2";
            this.DatePeriod2.Size = new System.Drawing.Size(143, 20);
            this.DatePeriod2.TabIndex = 18;
            this.DatePeriod2.Text = "с 31.01.23 по 01.02.23";
            // 
            // labelPeroid2
            // 
            this.labelPeroid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeroid2.AutoSize = true;
            this.labelPeroid2.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeroid2.Location = new System.Drawing.Point(518, 123);
            this.labelPeroid2.Name = "labelPeroid2";
            this.labelPeroid2.Size = new System.Drawing.Size(71, 20);
            this.labelPeroid2.TabIndex = 17;
            this.labelPeroid2.Text = "Период 2";
            // 
            // DatePeriod3
            // 
            this.DatePeriod3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePeriod3.AutoSize = true;
            this.DatePeriod3.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePeriod3.ForeColor = System.Drawing.Color.DarkBlue;
            this.DatePeriod3.Location = new System.Drawing.Point(771, 150);
            this.DatePeriod3.Name = "DatePeriod3";
            this.DatePeriod3.Size = new System.Drawing.Size(143, 20);
            this.DatePeriod3.TabIndex = 20;
            this.DatePeriod3.Text = "с 31.01.23 по 01.02.23";
            // 
            // labelPeroid3
            // 
            this.labelPeroid3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeroid3.AutoSize = true;
            this.labelPeroid3.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeroid3.Location = new System.Drawing.Point(771, 123);
            this.labelPeroid3.Name = "labelPeroid3";
            this.labelPeroid3.Size = new System.Drawing.Size(71, 20);
            this.labelPeroid3.TabIndex = 19;
            this.labelPeroid3.Text = "Период 3";
            // 
            // labelPeroidPrice
            // 
            this.labelPeroidPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeroidPrice.AutoSize = true;
            this.labelPeroidPrice.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeroidPrice.Location = new System.Drawing.Point(1025, 123);
            this.labelPeroidPrice.Name = "labelPeroidPrice";
            this.labelPeroidPrice.Size = new System.Drawing.Size(173, 20);
            this.labelPeroidPrice.TabIndex = 21;
            this.labelPeroidPrice.Text = "Период цен конкурентов";
            // 
            // DatePeriodPrice
            // 
            this.DatePeriodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePeriodPrice.AutoSize = true;
            this.DatePeriodPrice.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePeriodPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.DatePeriodPrice.Location = new System.Drawing.Point(1025, 150);
            this.DatePeriodPrice.Name = "DatePeriodPrice";
            this.DatePeriodPrice.Size = new System.Drawing.Size(143, 20);
            this.DatePeriodPrice.TabIndex = 22;
            this.DatePeriodPrice.Text = "с 31.01.23 по 01.02.23";
            // 
            // labelProcent
            // 
            this.labelProcent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcent.AutoSize = true;
            this.labelProcent.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcent.Location = new System.Drawing.Point(1294, 123);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(119, 20);
            this.labelProcent.TabIndex = 23;
            this.labelProcent.Text = "Процент премии";
            // 
            // ProcentPrize
            // 
            this.ProcentPrize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcentPrize.AutoSize = true;
            this.ProcentPrize.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcentPrize.ForeColor = System.Drawing.Color.DarkBlue;
            this.ProcentPrize.Location = new System.Drawing.Point(1292, 150);
            this.ProcentPrize.Name = "ProcentPrize";
            this.ProcentPrize.Size = new System.Drawing.Size(25, 20);
            this.ProcentPrize.TabIndex = 24;
            this.ProcentPrize.Text = "25";
            // 
            // CoeffTax
            // 
            this.CoeffTax.AutoSize = true;
            this.CoeffTax.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoeffTax.ForeColor = System.Drawing.Color.DarkBlue;
            this.CoeffTax.Location = new System.Drawing.Point(1509, 150);
            this.CoeffTax.Name = "CoeffTax";
            this.CoeffTax.Size = new System.Drawing.Size(28, 20);
            this.CoeffTax.TabIndex = 25;
            this.CoeffTax.Text = "0.9";
            // 
            // labelCoeff
            // 
            this.labelCoeff.AutoSize = true;
            this.labelCoeff.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoeff.Location = new System.Drawing.Point(1509, 126);
            this.labelCoeff.Name = "labelCoeff";
            this.labelCoeff.Size = new System.Drawing.Size(145, 20);
            this.labelCoeff.TabIndex = 26;
            this.labelCoeff.Text = "Коэффициент налога";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Фильтры  v";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1624, 560);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.AutomaticDelay = 10;
            this.guna2HtmlToolTip1.AutoPopDelay = 10;
            this.guna2HtmlToolTip1.InitialDelay = 10;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.ReshowDelay = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "Экспорт Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 825);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelParameter);
            this.Controls.Add(this.labelCoeff);
            this.Controls.Add(this.CoeffTax);
            this.Controls.Add(this.ProcentPrize);
            this.Controls.Add(this.labelProcent);
            this.Controls.Add(this.DatePeriodPrice);
            this.Controls.Add(this.labelPeroidPrice);
            this.Controls.Add(this.DatePeriod3);
            this.Controls.Add(this.labelPeroid3);
            this.Controls.Add(this.DatePeriod2);
            this.Controls.Add(this.labelPeroid2);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.DatePeriod1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelPeroid1);
            this.Controls.Add(this.DateReport);
            this.MinimumSize = new System.Drawing.Size(1670, 771);
            this.Name = "Form1";
            this.Text = "Анализ категорий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вкладкаToolStripMenuItem;
        private ToolStripMenuItem вкладкаToolStripMenuItem1;
        private Label labelPeroid1;
        private Label DatePeriod1;
        private Label labelParameter;
        private Label DatePeriod2;
        private Label labelPeroid2;
        private Label DatePeriod3;
        private Label labelPeroid3;
        private Label labelPeroidPrice;
        private Label DatePeriodPrice;
        private Label labelProcent;
        private Label ProcentPrize;
        private Label CoeffTax;
        private Label labelCoeff;
        public MetroFramework.Controls.MetroComboBox DateReport;
        private Label label1;
        public DataGridView dataGridView1;
        public Label labelReport;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Button button1;
    }
}