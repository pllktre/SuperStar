namespace Анализ_категорий
{
    partial class FormFilter
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
            this.button_Reset_Column = new System.Windows.Forms.Button();
            this.button_Column = new System.Windows.Forms.Button();
            this.textBox_Molecula = new System.Windows.Forms.TextBox();
            this.labelPeroid1 = new System.Windows.Forms.Label();
            this.listBox_Molecule = new System.Windows.Forms.CheckedListBox();
            this.GTabControlFilter = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Prim = new System.Windows.Forms.Button();
            this.button_Reset_Prim = new System.Windows.Forms.Button();
            this.textBox_Prim = new System.Windows.Forms.TextBox();
            this.listBox_Prim = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_Nazn = new System.Windows.Forms.Button();
            this.button_Reset_Nazn = new System.Windows.Forms.Button();
            this.textBox_Nazn = new System.Windows.Forms.TextBox();
            this.listBox_Nazn = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_Prod = new System.Windows.Forms.Button();
            this.button_Reset_Prod = new System.Windows.Forms.Button();
            this.textBox_Prod = new System.Windows.Forms.TextBox();
            this.listBox_Prod = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonProdMark = new System.Windows.Forms.Button();
            this.button_Reset_ProdMark = new System.Windows.Forms.Button();
            this.textBox_ProdMark = new System.Windows.Forms.TextBox();
            this.listBox_ProdMark = new System.Windows.Forms.CheckedListBox();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.GTabControlFilter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Reset_Column
            // 
            this.button_Reset_Column.Location = new System.Drawing.Point(497, 455);
            this.button_Reset_Column.Name = "button_Reset_Column";
            this.button_Reset_Column.Size = new System.Drawing.Size(144, 32);
            this.button_Reset_Column.TabIndex = 14;
            this.button_Reset_Column.Text = "Сбросить";
            this.button_Reset_Column.UseVisualStyleBackColor = true;
            this.button_Reset_Column.Click += new System.EventHandler(this.button_Reset_Molecula_Click);
            // 
            // button_Column
            // 
            this.button_Column.Location = new System.Drawing.Point(337, 455);
            this.button_Column.Name = "button_Column";
            this.button_Column.Size = new System.Drawing.Size(144, 32);
            this.button_Column.TabIndex = 17;
            this.button_Column.Text = "Применить";
            this.button_Column.UseVisualStyleBackColor = true;
            this.button_Column.Click += new System.EventHandler(this.button_Molecula_Click);
            // 
            // textBox_Molecula
            // 
            this.textBox_Molecula.Location = new System.Drawing.Point(0, 3);
            this.textBox_Molecula.Name = "textBox_Molecula";
            this.textBox_Molecula.Size = new System.Drawing.Size(641, 25);
            this.textBox_Molecula.TabIndex = 15;
            this.textBox_Molecula.TextChanged += new System.EventHandler(this.textBox_Molecula_TextChanged);
            // 
            // labelPeroid1
            // 
            this.labelPeroid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeroid1.AutoSize = true;
            this.labelPeroid1.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeroid1.Location = new System.Drawing.Point(184, 71);
            this.labelPeroid1.Name = "labelPeroid1";
            this.labelPeroid1.Size = new System.Drawing.Size(49, 20);
            this.labelPeroid1.TabIndex = 16;
            this.labelPeroid1.Text = "Поиск";
            // 
            // listBox_Molecule
            // 
            this.listBox_Molecule.CheckOnClick = true;
            this.listBox_Molecule.FormattingEnabled = true;
            this.listBox_Molecule.Location = new System.Drawing.Point(0, 51);
            this.listBox_Molecule.Name = "listBox_Molecule";
            this.listBox_Molecule.Size = new System.Drawing.Size(641, 384);
            this.listBox_Molecule.TabIndex = 13;
            this.listBox_Molecule.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_Molecule_ItemCheck);
            // 
            // GTabControlFilter
            // 
            this.GTabControlFilter.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.GTabControlFilter.Controls.Add(this.tabPage1);
            this.GTabControlFilter.Controls.Add(this.tabPage2);
            this.GTabControlFilter.Controls.Add(this.tabPage3);
            this.GTabControlFilter.Controls.Add(this.tabPage4);
            this.GTabControlFilter.Controls.Add(this.tabPage5);
            this.GTabControlFilter.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTabControlFilter.ItemSize = new System.Drawing.Size(180, 40);
            this.GTabControlFilter.Location = new System.Drawing.Point(0, 94);
            this.GTabControlFilter.Name = "GTabControlFilter";
            this.GTabControlFilter.SelectedIndex = 0;
            this.GTabControlFilter.Size = new System.Drawing.Size(851, 513);
            this.GTabControlFilter.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.GTabControlFilter.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.GTabControlFilter.TabButtonHoverState.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTabControlFilter.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.GTabControlFilter.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.GTabControlFilter.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.GTabControlFilter.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.GTabControlFilter.TabButtonIdleState.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTabControlFilter.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.GTabControlFilter.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.GTabControlFilter.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GTabControlFilter.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.GTabControlFilter.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.GTabControlFilter.TabButtonSelectedState.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTabControlFilter.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.GTabControlFilter.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.GTabControlFilter.TabButtonSize = new System.Drawing.Size(180, 40);
            this.GTabControlFilter.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GTabControlFilter.TabButtonTextOffset = new System.Drawing.Point(18, 0);
            this.GTabControlFilter.TabIndex = 18;
            this.GTabControlFilter.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button_Column);
            this.tabPage1.Controls.Add(this.button_Reset_Column);
            this.tabPage1.Controls.Add(this.textBox_Molecula);
            this.tabPage1.Controls.Add(this.listBox_Molecule);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(663, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "По молекуле";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button_Prim);
            this.tabPage2.Controls.Add(this.button_Reset_Prim);
            this.tabPage2.Controls.Add(this.textBox_Prim);
            this.tabPage2.Controls.Add(this.listBox_Prim);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "По применению";
            // 
            // button_Prim
            // 
            this.button_Prim.Location = new System.Drawing.Point(337, 455);
            this.button_Prim.Name = "button_Prim";
            this.button_Prim.Size = new System.Drawing.Size(144, 32);
            this.button_Prim.TabIndex = 21;
            this.button_Prim.Text = "Применить";
            this.button_Prim.UseVisualStyleBackColor = true;
            this.button_Prim.Click += new System.EventHandler(this.button_Prim_Click);
            // 
            // button_Reset_Prim
            // 
            this.button_Reset_Prim.Location = new System.Drawing.Point(497, 455);
            this.button_Reset_Prim.Name = "button_Reset_Prim";
            this.button_Reset_Prim.Size = new System.Drawing.Size(144, 32);
            this.button_Reset_Prim.TabIndex = 19;
            this.button_Reset_Prim.Text = "Сбросить";
            this.button_Reset_Prim.UseVisualStyleBackColor = true;
            this.button_Reset_Prim.Click += new System.EventHandler(this.button_Reset_Prim_Click);
            // 
            // textBox_Prim
            // 
            this.textBox_Prim.Location = new System.Drawing.Point(0, 3);
            this.textBox_Prim.Name = "textBox_Prim";
            this.textBox_Prim.Size = new System.Drawing.Size(641, 25);
            this.textBox_Prim.TabIndex = 20;
            this.textBox_Prim.TextChanged += new System.EventHandler(this.textBox_Prim_TextChanged);
            // 
            // listBox_Prim
            // 
            this.listBox_Prim.CheckOnClick = true;
            this.listBox_Prim.FormattingEnabled = true;
            this.listBox_Prim.Location = new System.Drawing.Point(0, 51);
            this.listBox_Prim.Name = "listBox_Prim";
            this.listBox_Prim.Size = new System.Drawing.Size(641, 384);
            this.listBox_Prim.TabIndex = 18;
            this.listBox_Prim.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_Prim_ItemCheck);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_Nazn);
            this.tabPage3.Controls.Add(this.button_Reset_Nazn);
            this.tabPage3.Controls.Add(this.textBox_Nazn);
            this.tabPage3.Controls.Add(this.listBox_Nazn);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(663, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "По назначению";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_Nazn
            // 
            this.button_Nazn.Location = new System.Drawing.Point(337, 455);
            this.button_Nazn.Name = "button_Nazn";
            this.button_Nazn.Size = new System.Drawing.Size(144, 32);
            this.button_Nazn.TabIndex = 24;
            this.button_Nazn.Text = "Применить";
            this.button_Nazn.UseVisualStyleBackColor = true;
            this.button_Nazn.Click += new System.EventHandler(this.button_Nazn_Click);
            // 
            // button_Reset_Nazn
            // 
            this.button_Reset_Nazn.Location = new System.Drawing.Point(497, 455);
            this.button_Reset_Nazn.Name = "button_Reset_Nazn";
            this.button_Reset_Nazn.Size = new System.Drawing.Size(144, 32);
            this.button_Reset_Nazn.TabIndex = 23;
            this.button_Reset_Nazn.Text = "Сбросить";
            this.button_Reset_Nazn.UseVisualStyleBackColor = true;
            this.button_Reset_Nazn.Click += new System.EventHandler(this.button_Reset_Nazn_Click);
            // 
            // textBox_Nazn
            // 
            this.textBox_Nazn.Location = new System.Drawing.Point(0, 3);
            this.textBox_Nazn.Name = "textBox_Nazn";
            this.textBox_Nazn.Size = new System.Drawing.Size(641, 25);
            this.textBox_Nazn.TabIndex = 22;
            this.textBox_Nazn.TextChanged += new System.EventHandler(this.textBox_Nazn_TextChanged);
            // 
            // listBox_Nazn
            // 
            this.listBox_Nazn.CheckOnClick = true;
            this.listBox_Nazn.FormattingEnabled = true;
            this.listBox_Nazn.Location = new System.Drawing.Point(0, 51);
            this.listBox_Nazn.Name = "listBox_Nazn";
            this.listBox_Nazn.Size = new System.Drawing.Size(641, 384);
            this.listBox_Nazn.TabIndex = 21;
            this.listBox_Nazn.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_Nazn_ItemCheck);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_Prod);
            this.tabPage4.Controls.Add(this.button_Reset_Prod);
            this.tabPage4.Controls.Add(this.textBox_Prod);
            this.tabPage4.Controls.Add(this.listBox_Prod);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(663, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "По производителю";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_Prod
            // 
            this.button_Prod.Location = new System.Drawing.Point(337, 455);
            this.button_Prod.Name = "button_Prod";
            this.button_Prod.Size = new System.Drawing.Size(144, 32);
            this.button_Prod.TabIndex = 26;
            this.button_Prod.Text = "Применить";
            this.button_Prod.UseVisualStyleBackColor = true;
            this.button_Prod.Click += new System.EventHandler(this.button_Prod_Click);
            // 
            // button_Reset_Prod
            // 
            this.button_Reset_Prod.Location = new System.Drawing.Point(497, 455);
            this.button_Reset_Prod.Name = "button_Reset_Prod";
            this.button_Reset_Prod.Size = new System.Drawing.Size(144, 32);
            this.button_Reset_Prod.TabIndex = 25;
            this.button_Reset_Prod.Text = "Сбросить";
            this.button_Reset_Prod.UseVisualStyleBackColor = true;
            this.button_Reset_Prod.Click += new System.EventHandler(this.button_Reset_Prod_Click);
            // 
            // textBox_Prod
            // 
            this.textBox_Prod.Location = new System.Drawing.Point(0, 3);
            this.textBox_Prod.Name = "textBox_Prod";
            this.textBox_Prod.Size = new System.Drawing.Size(641, 25);
            this.textBox_Prod.TabIndex = 24;
            this.textBox_Prod.TextChanged += new System.EventHandler(this.textBox_Prod_TextChanged);
            // 
            // listBox_Prod
            // 
            this.listBox_Prod.CheckOnClick = true;
            this.listBox_Prod.FormattingEnabled = true;
            this.listBox_Prod.Location = new System.Drawing.Point(0, 51);
            this.listBox_Prod.Name = "listBox_Prod";
            this.listBox_Prod.Size = new System.Drawing.Size(641, 384);
            this.listBox_Prod.TabIndex = 23;
            this.listBox_Prod.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_Prod_ItemCheck);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonProdMark);
            this.tabPage5.Controls.Add(this.button_Reset_ProdMark);
            this.tabPage5.Controls.Add(this.textBox_ProdMark);
            this.tabPage5.Controls.Add(this.listBox_ProdMark);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(663, 505);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "По производителю из маркетинга";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonProdMark
            // 
            this.buttonProdMark.Location = new System.Drawing.Point(337, 455);
            this.buttonProdMark.Name = "buttonProdMark";
            this.buttonProdMark.Size = new System.Drawing.Size(144, 32);
            this.buttonProdMark.TabIndex = 26;
            this.buttonProdMark.Text = "Применить";
            this.buttonProdMark.UseVisualStyleBackColor = true;
            this.buttonProdMark.Click += new System.EventHandler(this.buttonProdMark_Click);
            // 
            // button_Reset_ProdMark
            // 
            this.button_Reset_ProdMark.Location = new System.Drawing.Point(497, 455);
            this.button_Reset_ProdMark.Name = "button_Reset_ProdMark";
            this.button_Reset_ProdMark.Size = new System.Drawing.Size(144, 32);
            this.button_Reset_ProdMark.TabIndex = 25;
            this.button_Reset_ProdMark.Text = "Сбросить";
            this.button_Reset_ProdMark.UseVisualStyleBackColor = true;
            this.button_Reset_ProdMark.Click += new System.EventHandler(this.button_Reset_ProdMark_Click);
            // 
            // textBox_ProdMark
            // 
            this.textBox_ProdMark.Location = new System.Drawing.Point(0, 3);
            this.textBox_ProdMark.Name = "textBox_ProdMark";
            this.textBox_ProdMark.Size = new System.Drawing.Size(641, 25);
            this.textBox_ProdMark.TabIndex = 24;
            this.textBox_ProdMark.TextChanged += new System.EventHandler(this.textBox_ProdMark_TextChanged);
            // 
            // listBox_ProdMark
            // 
            this.listBox_ProdMark.CheckOnClick = true;
            this.listBox_ProdMark.FormattingEnabled = true;
            this.listBox_ProdMark.Location = new System.Drawing.Point(0, 51);
            this.listBox_ProdMark.Name = "listBox_ProdMark";
            this.listBox_ProdMark.Size = new System.Drawing.Size(641, 384);
            this.listBox_ProdMark.TabIndex = 23;
            this.listBox_ProdMark.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_ProdMark_ItemCheck);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 601);
            this.Controls.Add(this.labelPeroid1);
            this.Controls.Add(this.GTabControlFilter);
            this.MaximizeBox = false;
            this.Name = "FormFilter";
            this.Padding = new System.Windows.Forms.Padding(40, 60, 20, 20);
            this.Text = "Фильтры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFilter_FormClosed);
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.GTabControlFilter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_Reset_Column;
        private Button button_Column;
        private TextBox textBox_Molecula;
        private CheckedListBox listBox_Molecule;
        private Label labelPeroid1;
        private Guna.UI2.WinForms.Guna2TabControl GTabControlFilter;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_Reset_Prim;
        private TextBox textBox_Prim;
        private CheckedListBox listBox_Prim;
        private TabPage tabPage3;
        private Button button_Nazn;
        private Button button_Reset_Nazn;
        private TextBox textBox_Nazn;
        private CheckedListBox listBox_Nazn;
        private TabPage tabPage4;
        private TextBox textBox_Prod;
        private CheckedListBox listBox_Prod;
        private TabPage tabPage5;
        private TextBox textBox_ProdMark;
        private CheckedListBox listBox_ProdMark;
        private Button button_Prod;
        private Button button_Reset_Prod;
        private Button buttonProdMark;
        private Button button_Reset_ProdMark;
        private Button button_Prim;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}