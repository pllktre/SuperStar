using MetroFramework.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Анализ_категорий
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int id_ndok = 0;
        public Form1()
        {
            Program.f1 = this; // теперь f1 будет ссылкой на форму Form1
            InitializeComponent();
            DateReport.SelectedIndex = -1;
            //MessageBox.Show(DateReport.SelectedValue.ToString());
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCombobox();
            Filter.setFilterMolecule("");
            Filter.setFilterPrim("");
            Filter.setFilterNazn("");
            Filter.setFilterProd("");
            Filter.setFilterProdMark("");
        }

        public void updateCombobox()
        {

            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                string sqlQuery = $@"select id, dd from SprTovar.dbo.SuperStarHeader order by dd desc";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "DateReport");
                DateReport.DisplayMember = "dd"; //свойство объекта, которое будет использоваться для отображения
                DateReport.ValueMember = "id"; //свойство объекта, которое будет использоваться в качестве его значения
                DateReport.DataSource = dataSet.Tables["DateReport"]; //источник данных - массив или коллекция объектов (dataSet)

                conn.Close(); //Закрываем подключение

            }
        }
        public void updateReport(int id_ndok)
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection())
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = $@"select 'с '+convert(varchar,dd_prod1_1,104)+' по '+convert(varchar,dd_prod1_2,104), 
                                                 'с '+convert(varchar,dd_prod2_1,104)+' по '+convert(varchar,dd_prod2_2,104),
                                                 'с '+convert(varchar,dd_prod3_1,104)+' по '+convert(varchar,dd_prod3_2,104),
                                                 'с '+convert(varchar,dd_comp1,104)+' по '+convert(varchar,dd_comp2,104),
                                                 koef_prem, koef_nalog from SprTovar.dbo.SuperStarHeader where id = {id_ndok}";
                    comm.Connection = conn;
                    SqlDataReader DR = comm.ExecuteReader(); // объект, который используется для чтения данны
                    while (DR.Read())
                    {
                        DatePeriod1.Text = DR[0].ToString();
                        DatePeriod2.Text = DR[1].ToString();
                        DatePeriod3.Text = DR[2].ToString();
                        DatePeriodPrice.Text = DR[3].ToString();
                        ProcentPrize.Text = DR[4].ToString();
                        CoeffTax.Text = DR[5].ToString();
                    }

                }
                conn.Close();

            }
            // panelTable.Controls.Clear();
            // panelTable.Controls.Add(mainGrid);

        }

        private void DateReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mainGrid.update_dgv(id_ndok); //Обновление самого отчета (таблицы)
            id_ndok = Convert.ToInt32(DateReport.SelectedValue);
            Thread.Sleep(100);
            DateReport.DroppedDown = false; // Закрытие выпадающего списка
            updateReport(id_ndok); //Обновление параметров отчета
        }

        private void DateReport_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_ndok = Convert.ToInt32(DateReport.SelectedValue);
            Thread.Sleep(100);
            DateReport.DroppedDown = false; // Закрытие выпадающего списка
            updateReport(id_ndok); //Обновление параметров отчета
            if (Program.fm is null)
            {
                guna2HtmlToolTip1.BackColor = Color.FromArgb(240, 240, 240);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", DateReport);
            }
            else
            {
                Program.fm.button_Molecula_Click(sender, e);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormFilter filterMolecule = new FormFilter();
            filterMolecule.Show();
        }

        //public void FilterShortName()
        //{

        //    using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
        //    {
        //        int id_ndok = Convert.ToInt32(DateReport.SelectedValue);
        //        string sqlQuery = $@"exec[apteka-server].SprTovar.dbo.sp_SuperStar_AnalysisCategory {0}";
        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
        //        conn.Open();
        //        DataSet dataSet = new DataSet();
        //        adapter.Fill(dataSet, "DateReport");
        //        DateReport.DisplayMember = "dd"; //свойство объекта, которое будет использоваться для отображения
        //        DateReport.ValueMember = "id"; //свойство объекта, которое будет использоваться в качестве его значения
        //        DateReport.DataSource = dataSet.Tables["DateReport"]; //источник данных - массив или коллекция объектов (dataSet)

        //        conn.Close(); //Закрываем подключение

        //    }
        //}


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Метод закрашивает строки, у которых маржа ПЗ меньше 35%
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Contains("Маржа ПЗ") && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    string colName = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Replace(Environment.NewLine, "");
            //    dataGridView1.Columns[e.ColumnIndex].HeaderText = colName;
            //    dataGridView1.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    dataGridView1.Columns[e.ColumnIndex].Width = 100;
            //    if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[colName].Value) < 35.0)
            //    {
            //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 250, 221);
            //    }
            //}
            //if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Contains("Маржа ПЗ") && e.Value != null)
            //{
            //    string colName = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Replace(Environment.NewLine, "");
            //    dataGridView1.Columns[e.ColumnIndex].HeaderText = colName;
            //    dataGridView1.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    dataGridView1.Columns[e.ColumnIndex].Width = 100;

            //    if (Convert.ToDouble(e.Value) < 35.0)
            //    {
            //       //MessageBox.Show(e.RowIndex.ToString());
            //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 250, 221);
            //        if (!highlightedRows.Contains(e.RowIndex)) // добавляем строку в массив, если ее еще нет
            //        {
            //            highlightedRows.Add(e.RowIndex);
            //        }
            //    }
            //    else
            //    {
            //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window; // восстанавливаем цвет фона строки
            //        if (highlightedRows.Contains(e.RowIndex)) // удаляем строку из массива, если она была закрашена
            //        {
            //            highlightedRows.Remove(e.RowIndex);
            //        }
            //    }
            //}
            // Метод закрашивает строки, у которых маржа ПЗ меньше 35 %
            //if (e.RowIndex < 0) { return; }
            //if (e.ColumnIndex < 0) { return; }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //автоматическая ширина всех столбцов
            //if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Contains("Маржа ПЗ") && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    string colName = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString().Replace(Environment.NewLine, "");
            //    dataGridView1.Columns[e.ColumnIndex].HeaderText = colName;
            //    dataGridView1.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    dataGridView1.Columns[e.ColumnIndex].Width = 100;
            //    if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[colName].Value) < 35.0)
            //    {
            //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 250, 221);
            //    }
            //}
        }


        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //автоматическая ширина строк

            foreach (DataGridViewRow row in dataGridView1.Rows) //закрашиваем строки по условию
            {
                if (Convert.ToDouble(row.Cells["Маржа ПЗ П"].Value) < 35.0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(212, 250, 221);
                }
            }

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            FormFilter filterMolecule = new FormFilter();
            filterMolecule.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormFilter filterMolecule = new FormFilter();
            filterMolecule.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Column column = new Column();
            column.ShowDialog();
            ExportToExcel(dataGridView1);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            //Приложение
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            //Названия столбцов
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                ExcelApp.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                ExcelApp.Cells[1, i + 1].Font.Bold = true; //жирность
                //обводка границ
                ExcelWorkSheet.Cells[1, i + 1].Select();
                ExcelWorkSheet.Cells[1, i + 1].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                ExcelWorkSheet.Cells[1, i + 1].Borders.Weight = 2d;

            }
            //автофильтр по всем столбцам
            int lastRow = ExcelWorkSheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
            int lastColumn = ExcelWorkSheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Column;
            Microsoft.Office.Interop.Excel.Range range = ExcelWorkSheet.Range["A1", ExcelWorkSheet.Cells[lastRow, lastColumn]];
            range.AutoFilter(1, Type.Missing, Microsoft.Office.Interop.Excel.XlAutoFilterOperator.xlAnd, Type.Missing, true);


            //Сами строки
            for (int i = 1; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    //обводка границ
                    ExcelWorkSheet.Cells[i + 1, j + 1].Select();
                    ExcelWorkSheet.Cells[i + 1, j + 1].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    ExcelWorkSheet.Cells[i + 1, j + 1].Borders.Weight = 2d;

                    // Если строка закрашена зеленым цветом, то сохраняем этот цвет в Excel
                    if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.FromArgb(212, 250, 221))
                    {
                       //ExcelWorkSheet.Cells[i + 1, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ExcelWorkSheet.Cells[i + 1, j + 1].Interior.Color = Color.FromArgb(212, 250, 221);
                    }
                }
            }
            ExcelWorkSheet.Columns.AutoFit(); //автоматическая ширина
            //Вызываем нашу созданную эксельку
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}