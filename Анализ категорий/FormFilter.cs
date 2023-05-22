using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анализ_категорий
{
    public partial class FormFilter : MetroFramework.Forms.MetroForm
    {
        public List<string> checkedItemsMolecule = new List<string>(); //список для отмеченных чекбоксов фильтра молекулы
        public List<string> checkedItemsPrim = new List<string>(); //список для отмеченных чекбоксов фильтра молекулы
        public List<string> checkedItemsNazn = new List<string>(); //список для отмеченных чекбоксов фильтра назначения
        public List<string> checkedItemsProd = new List<string>(); //список для отмеченных чекбоксов фильтра производителя
        public List<string> checkedItemsProdMark = new List<string>(); //список для отмеченных чекбоксов фильтра производителя из маркетинга


        public FormFilter()
        {
            Program.fm = this; // теперь f1 будет ссылкой на форму Form1
            InitializeComponent();
        }
        private void FormFilter_Load(object sender, EventArgs e)
        {
            loadListBoxMolecule(); // заполняем список молекулы
            LoadSettingsMolecule(); // загружаем настройки сохранненых чекбоксов для молекулы

            loadListBoxPrim(); // заполняем список по применению
            LoadSettingsPrim(); // загружаем настройки сохранненых чекбоксов для применения

            loadListBoxNazn(); // заполняем список по незначению
            LoadSettingsNazn(); // загружаем настройки сохранненых чекбоксов для назначения

            loadListBoxProd(); // заполняем список по производителю
            LoadSettingsProd(); // загружаем настройки сохранненых чекбоксов для производителя

            loadListBoxProdMark(); // заполняем список по производителю из маркетинга
            LoadSettingsProdMark(); // загружаем настройки сохранненых чекбоксов для производителя из маркетинга
        }
        public void ConnectionListBoxMolecule(string queryString)
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryString, conn); // Создание объекта команды для выполнения запроса  
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и получение данных в виде DataReader
                while (reader.Read()) //Загрузка данных в CheckedListBox 
                {
                    listBox_Molecule.Items.Add(reader["name"].ToString()); //в reader'е указывается поле, которое будет добавлено в список
                }
                conn.Close();
            }
        }
        void loadListBoxMolecule() //Загрузка молекулы
        {
            string queryString = $@"select id, name from SprTovar.dbo.Molecule order by name"; // Запрос для получения данных из базы
            ConnectionListBoxMolecule(queryString);
        }
        public void UpdateListBoxMolecule(string text) //Метод обновления списка
        {
            listBox_Molecule.Items.Clear(); // Очистка содержимого CheckedListBox 
            string queryString = "select id, name from SprTovar.dbo.Molecule where name like '%" + text + "%' order by name";
            ConnectionListBoxMolecule(queryString);
        }

        private void SaveSettingsMolecule() //метод для сохранения какие флажки были выбраны
        {
            string settings = "";
            for (int i = 0; i < listBox_Molecule.Items.Count; i++) //проходимся по всем элементам списка
            {
                if (listBox_Molecule.GetItemChecked(i))// если элемент отмечен
                {
                    settings += listBox_Molecule.Items[i] + ";"; // добавляем его в строку и разделяем точкой с запятой
                }
            }
            Filter.setFilterMolecule(settings); //сохраняем строку в поле класса Filter
        }
        private void LoadSettingsMolecule() // метод для загрузки настроек
        {
            string settings = Filter.getFilterMolecule(); // получаем данные из поля класса Filter
            // если данные не найдены выходим
            if (settings == "" || settings == null)
            {
                return;
            }
            string[] settingsArray = settings.Split(';'); // разбиваем данные на строки и заносим в массив

            foreach (string s in settingsArray) // проходимся по строкам
            {
                for (int i = 0; i < listBox_Molecule.Items.Count; i++) // проходимся по всем элементам списка
                {
                    if (listBox_Molecule.Items[i].ToString() == s) // если элемент равен текущему из строки
                    {
                        listBox_Molecule.SetItemChecked(i, true); // отмечаем этот элемент
                    }
                }
            }
        }

        private void textBox_Molecula_TextChanged(object sender, EventArgs e) //изменение текста в чекбоксе
        {
            string text = textBox_Molecula.Text;
            UpdateListBoxMolecule(text);
            SaveSettingsMolecule();

            for (int i = 0; i < listBox_Molecule.Items.Count; i++) //проходимся по всем элементам списка 
            {
                if (!listBox_Molecule.Items[i].ToString().Contains(text)) //если элемент строки не содержит значение в text
                {
                    listBox_Molecule.SetItemChecked(i, false); //то не отмечаем элемент
                    listBox_Molecule.Items.RemoveAt(i); //удаляем это значение из списка 
                    i--;
                }
                else
                {
                    if (checkedItemsMolecule.Contains(listBox_Molecule.Items[i])) //если в списке отмеченных содержится значение из списка
                    {
                        listBox_Molecule.SetItemChecked(i, true); //то отмечаем его
                    }
                }
            }
        }

        private void FormFilter_FormClosed(object sender, FormClosedEventArgs e) //Когда форма закроется, то отмеченные состояния должны сохраниться
        {
            SaveSettingsMolecule();
            SaveSettingsPrim();
            SaveSettingsNazn();
            SaveSettingsProd();
            SaveSettingsProdMark();
        }

        private void listBox_Molecule_ItemCheck(object sender, ItemCheckEventArgs e) //выбор элемента в чекбоксе
        {
            CheckedListBox checkList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                checkedItemsMolecule.Add(checkList.Items[e.Index].ToString()); //добавляет в список индекс элемента
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedItemsMolecule.Remove(checkList.Items[e.Index].ToString()); //удалят из списка индекс элемента
            }
        }

        private void button_Reset_Molecula_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_Molecule.Items.Count; i++)
            {
                listBox_Molecule.SetItemChecked(i, false);
            }
        }


        public void ConnectionListBoxPrim(string queryString)
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryString, conn); // Создание объекта команды для выполнения запроса  
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и получение данных в виде DataReader
                while (reader.Read()) //Загрузка данных в CheckedListBox 
                {
                    listBox_Prim.Items.Add(reader["name"].ToString().ToLower()); //в reader'е указывается поле, которое будет добавлено в список
                }
                conn.Close();
            }
        }
        void loadListBoxPrim() //Загрузка молекулы
        {
            string queryString = $@"select id, name from SprTovar.dbo.Applications order by name"; // Запрос для получения данных из базы
            ConnectionListBoxPrim(queryString);
        }
        public void UpdateListBoxPrim(string text) //Метод обновления списка    
        {
            listBox_Prim.Items.Clear(); // Очистка содержимого CheckedListBox
            string queryString = "select id, name from SprTovar.dbo.Applications where name like '%" + text + "%' order by name";
            ConnectionListBoxPrim(queryString);
        }

        private void SaveSettingsPrim() //метод для сохранения какие флажки были выбраны
        {
            string settings = "";
            for (int i = 0; i < listBox_Prim.Items.Count; i++) //проходимся по всем элементам списка
            {
                if (listBox_Prim.GetItemChecked(i))// если элемент отмечен
                {
                    settings += listBox_Prim.Items[i] + ";"; // добавляем его в строку и разделяем точкой с запятой
                }
            }
            Filter.setFilterPrim(settings); //сохраняем строку в поле класса Filter
        }
        private void LoadSettingsPrim() // метод для загрузки настроек
        {
            string settings = Filter.getFilterPrim(); // получаем данные из поля класса Filter
                                                      // если данные не найдены выходим
            if (settings == "" || settings == null)
            {
                return;
            }
            string[] settingsArray = settings.Split(';'); // разбиваем данные на строки и заносим в массив

            foreach (string s in settingsArray) // проходимся по строкам
            {
                for (int i = 0; i < listBox_Prim.Items.Count; i++) // проходимся по всем элементам списка
                {
                    if (listBox_Prim.Items[i].ToString() == s) // если элемент равен текущему из строки
                    {
                        listBox_Prim.SetItemChecked(i, true); // отмечаем этот элемент
                    }
                }
            }
        }

        private void textBox_Prim_TextChanged(object sender, EventArgs e)
        {
            string text = textBox_Prim.Text;
            UpdateListBoxPrim(text);
            SaveSettingsPrim();

            for (int i = 0; i < listBox_Prim.Items.Count; i++) //проходимся по всем элементам списка 
            {
                if (!listBox_Prim.Items[i].ToString().Contains(text)) //если элемент строки не содержит значение в text
                {
                    listBox_Prim.SetItemChecked(i, false); //то не отмечаем элемент
                    listBox_Prim.Items.RemoveAt(i); //удаляем это значение из списка 
                    i--;
                }
                else
                {
                    if (checkedItemsPrim.Contains(listBox_Prim.Items[i])) //если в списке отмеченных содержится значение из списка
                    {
                        listBox_Prim.SetItemChecked(i, true); //то отмечаем его
                    }
                }
            }
        }

        private void listBox_Prim_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                checkedItemsPrim.Add(checkList.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedItemsPrim.Remove(checkList.Items[e.Index].ToString());
            }
        }

        private void button_Reset_Prim_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_Prim.Items.Count; i++)
            {
                listBox_Prim.SetItemChecked(i, false);
            }
        }
        public void ConnectionListBoxNazn(string queryString) //по назначению
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryString, conn); // Создание объекта команды для выполнения запроса  
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и получение данных в виде DataReader
                while (reader.Read()) //Загрузка данных в CheckedListBox 
                {
                    listBox_Nazn.Items.Add(reader["name"].ToString()); //в reader'е указывается поле, которое будет добавлено в список
                }
                conn.Close();
            }
        }
        void loadListBoxNazn() //Загрузка
        {
            string queryString = $@"select id, name from SprTovar.dbo.ApplicationsForQwerty order by name"; // Запрос для получения данных из базы
            ConnectionListBoxNazn(queryString);
        }
        public void UpdateListBoxNazn(string text) //Метод обновления списка    
        {
            listBox_Nazn.Items.Clear(); // Очистка содержимого CheckedListBox
            string queryString = "select id, name from SprTovar.dbo.ApplicationsForQwerty where name like '%" + text + "%' order by name";
            ConnectionListBoxNazn(queryString);
        }

        private void SaveSettingsNazn() //метод для сохранения какие флажки были выбраны
        {
            string settings = "";
            for (int i = 0; i < listBox_Nazn.Items.Count; i++) //проходимся по всем элементам списка
            {
                if (listBox_Nazn.GetItemChecked(i))// если элемент отмечен
                {
                    settings += listBox_Nazn.Items[i] + ";"; // добавляем его в строку и разделяем точкой с запятой
                }
            }
            Filter.setFilterNazn(settings); //сохраняем строку в поле класса Filter
        }
        private void LoadSettingsNazn() // метод для загрузки настроек
        {
            string settings = Filter.getFilterNazn(); // получаем данные из поля класса Filter
                                                      // если данные не найдены выходим
            if (settings == "" || settings == null)
            {
                return;
            }
            string[] settingsArray = settings.Split(';'); // разбиваем данные на строки и заносим в массив

            foreach (string s in settingsArray) // проходимся по строкам
            {
                for (int i = 0; i < listBox_Nazn.Items.Count; i++) // проходимся по всем элементам списка
                {
                    if (listBox_Nazn.Items[i].ToString() == s) // если элемент равен текущему из строки
                    {
                        listBox_Nazn.SetItemChecked(i, true); // отмечаем этот элемент
                    }
                }
            }
        }

        private void textBox_Nazn_TextChanged(object sender, EventArgs e) //изменение текста в чекбоксе
        {
            string text = textBox_Nazn.Text;
            UpdateListBoxNazn(text);
            SaveSettingsNazn();

            for (int i = 0; i < listBox_Nazn.Items.Count; i++) //проходимся по всем элементам списка 
            {
                if (!listBox_Nazn.Items[i].ToString().Contains(text)) //если элемент строки не содержит значение в text
                {
                    listBox_Nazn.SetItemChecked(i, false); //то не отмечаем элемент
                    listBox_Nazn.Items.RemoveAt(i); //удаляем это значение из списка 
                    i--;
                }
                else
                {
                    if (checkedItemsNazn.Contains(listBox_Nazn.Items[i])) //если в списке отмеченных содержится значение из списка
                    {
                        listBox_Nazn.SetItemChecked(i, true); //то отмечаем его
                    }
                }
            }
        }

        private void listBox_Nazn_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                checkedItemsNazn.Add(checkList.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedItemsNazn.Remove(checkList.Items[e.Index].ToString());
            }
        }

        private void button_Reset_Nazn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_Nazn.Items.Count; i++)
            {
                listBox_Nazn.SetItemChecked(i, false);
            }
        }

        public void ConnectionListBoxProd(string queryString) //по производителю
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryString, conn); // Создание объекта команды для выполнения запроса  
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и получение данных в виде DataReader
                while (reader.Read()) //Загрузка данных в CheckedListBox 
                {
                    listBox_Prod.Items.Add(reader["name"].ToString().ToLower()); //в reader'е указывается поле, которое будет добавлено в список
                }
                conn.Close();
            }
        }

        void loadListBoxProd() //Загрузка молекулы
        {
            string queryString = $@"select id, f.name from SprTovar.dbo.Firms f 
                                   inner join SprTovar.dbo.FirmsMarket fm on fm.id=f.id_firmMarket order by f.name"; // Запрос для получения данных из базы
            ConnectionListBoxProd(queryString);
        }
        public void UpdateListBoxProd(string text) //Метод обновления списка    
        {
            listBox_Prod.Items.Clear(); // Очистка содержимого CheckedListBox
            string queryString = "select id, f.name from SprTovar.dbo.Firms f inner join SprTovar.dbo.FirmsMarket fm on fm.id = f.id_firmMarket " +
                                 "where f.name like '%" + text + "%' order by f.name";
            ConnectionListBoxProd(queryString);
        }

        private void SaveSettingsProd() //метод для сохранения какие флажки были выбраны
        {
            string settings = "";
            for (int i = 0; i < listBox_Prod.Items.Count; i++) //проходимся по всем элементам списка
            {
                if (listBox_Prod.GetItemChecked(i))// если элемент отмечен
                {
                    settings += listBox_Prod.Items[i] + ";"; // добавляем его в строку и разделяем точкой с запятой
                }
            }
            Filter.setFilterProd(settings); //сохраняем строку в поле класса Filter
        }
        private void LoadSettingsProd() // метод для загрузки настроек
        {
            string settings = Filter.getFilterProd(); // получаем данные из поля класса Filter
                                                      // если данные не найдены выходим
            if (settings == "" || settings == null)
            {
                return;
            }
            string[] settingsArray = settings.Split(';'); // разбиваем данные на строки и заносим в массив

            foreach (string s in settingsArray) // проходимся по строкам
            {
                for (int i = 0; i < listBox_Prod.Items.Count; i++) // проходимся по всем элементам списка
                {
                    if (listBox_Prod.Items[i].ToString() == s) // если элемент равен текущему из строки
                    {
                        listBox_Prod.SetItemChecked(i, true); // отмечаем этот элемент
                    }
                }
            }
        }

        private void textBox_Prod_TextChanged(object sender, EventArgs e)
        {
            string text = textBox_Prod.Text;
            UpdateListBoxProd(text);
            SaveSettingsProd();

            for (int i = 0; i < listBox_Prod.Items.Count; i++) //проходимся по всем элементам списка 
            {
                if (!listBox_Prod.Items[i].ToString().Contains(text)) //если элемент строки не содержит значение в text
                {
                    listBox_Prod.SetItemChecked(i, false); //то не отмечаем элемент
                    listBox_Prod.Items.RemoveAt(i); //удаляем это значение из списка 
                    i--;
                }
                else
                {
                    if (checkedItemsProd.Contains(listBox_Prod.Items[i])) //если в списке отмеченных содержится значение из списка
                    {
                        listBox_Prod.SetItemChecked(i, true); //то отмечаем его
                    }
                }
            }
        }

        private void listBox_Prod_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                checkedItemsProd.Add(checkList.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedItemsProd.Remove(checkList.Items[e.Index].ToString());
            }
        }

        private void button_Reset_Prod_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_Prod.Items.Count; i++)
            {
                listBox_Prod.SetItemChecked(i, false);
            }
        }

        public void ConnectionListBoxProdMark(string queryString) //по производителю из маркетинга
        {
            using (SqlConnection conn = ConnectionBD.GetDBConnection()) //Создание подключения к БД
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryString, conn); // Создание объекта команды для выполнения запроса  
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и получение данных в виде DataReader
                while (reader.Read()) //Загрузка данных в CheckedListBox 
                {
                    listBox_ProdMark.Items.Add(reader["name"].ToString().ToLower().Trim()); //в reader'е указывается поле, которое будет добавлено в список
                }
                conn.Close();
            }
        }

        void loadListBoxProdMark() //Загрузка молекулы
        {
            string queryString = $@"select id, name from SprTovar.dbo.FirmsMarket order by name"; // Запрос для получения данных из базы
            ConnectionListBoxProdMark(queryString);
        }

        public void UpdateListBoxProdMark(string text) //Метод обновления списка    
        {
            listBox_ProdMark.Items.Clear(); // Очистка содержимого CheckedListBox
            string queryString = "select id, name from SprTovar.dbo.FirmsMarket where name like '%" + text + "%' order by name";
            ConnectionListBoxProdMark(queryString);
        }

        private void SaveSettingsProdMark() //метод для сохранения какие флажки были выбраны
        {
            string settings = "";
            for (int i = 0; i < listBox_ProdMark.Items.Count; i++) //проходимся по всем элементам списка
            {
                if (listBox_ProdMark.GetItemChecked(i))// если элемент отмечен
                {
                    settings += listBox_ProdMark.Items[i] + ";"; // добавляем его в строку и разделяем точкой с запятой
                }
            }
            Filter.setFilterProdMark(settings); //сохраняем строку в поле класса Filter
        }

        private void LoadSettingsProdMark() // метод для загрузки настроек
        {
            string settings = Filter.getFilterProdMark(); // получаем данные из поля класса Filter
                                                          // если данные не найдены выходим
            if (settings == "" || settings == null)
            {
                return;
            }
            string[] settingsArray = settings.Split(';'); // разбиваем данные на строки и заносим в массив

            foreach (string s in settingsArray) // проходимся по строкам
            {
                for (int i = 0; i < listBox_ProdMark.Items.Count; i++) // проходимся по всем элементам списка
                {
                    if (listBox_ProdMark.Items[i].ToString() == s) // если элемент равен текущему из строки
                    {
                        listBox_ProdMark.SetItemChecked(i, true); // отмечаем этот элемент
                    }
                }
            }
        }

        private void textBox_ProdMark_TextChanged(object sender, EventArgs e)
        {
            string text = textBox_ProdMark.Text;
            UpdateListBoxProdMark(text);
            SaveSettingsProdMark();

            for (int i = 0; i < listBox_ProdMark.Items.Count; i++) //проходимся по всем элементам списка 
            {
                if (!listBox_ProdMark.Items[i].ToString().Contains(text)) //если элемент строки не содержит значение в text
                {
                    listBox_ProdMark.SetItemChecked(i, false); //то не отмечаем элемент
                    listBox_ProdMark.Items.RemoveAt(i); //удаляем это значение из списка 
                    i--;
                }
                else
                {
                    if (checkedItemsProdMark.Contains(listBox_ProdMark.Items[i])) //если в списке отмеченных содержится значение из списка
                    {
                        listBox_ProdMark.SetItemChecked(i, true); //то отмечаем его
                    }
                }
            }
        }

        private void listBox_ProdMark_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                checkedItemsProdMark.Add(checkList.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkedItemsProdMark.Remove(checkList.Items[e.Index].ToString());
            }
        }

        private void button_Reset_ProdMark_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_ProdMark.Items.Count; i++)
            {
                listBox_ProdMark.SetItemChecked(i, false);
            }
        }

        public void button_Molecula_Click(object sender, EventArgs e)
        {
            //Очистка содержимого DataGridView
            BindingSource bindSource = new BindingSource();
            DataTable result = new DataTable();
            if ((Program.fm.checkedItemsMolecule.Count + Program.fm.checkedItemsPrim.Count + Program.fm.checkedItemsNazn.Count
                + Program.fm.checkedItemsProd.Count + Program.fm.checkedItemsProdMark.Count) != 0)
            {
                // Подключение к базе данных 
                using (SqlConnection conn = ConnectionBD.GetDBConnection())
                {
                    // Открытие соединения 
                    conn.Open();

                    // Формирование строки для запроса 
                    string queryString = "exec SprTovar.dbo.sp_SuperStar_AnalysisCategory " + Convert.ToInt32(Program.f1.id_ndok) + ", '";
                    for (int i = 0; i < checkedItemsMolecule.Count; i++)
                    {
                        if (i == 0)
                            queryString += "''" + checkedItemsMolecule[i] + "''";
                        else
                            queryString += ", ''" + checkedItemsMolecule[i] + "''";
                    }
                    queryString += "','";

                    for (int i = 0; i < checkedItemsPrim.Count; i++)
                    {
                        if (i == 0)
                            queryString += "''" + checkedItemsPrim[i] + "''";
                        else
                            queryString += "; ''" + checkedItemsPrim[i] + "''";
                    }
                    queryString += "','";

                    for (int i = 0; i < checkedItemsNazn.Count; i++)
                    {
                        if (i == 0)
                            queryString += "''" + checkedItemsNazn[i] + "''";
                        else
                            queryString += ", ''" + checkedItemsNazn[i] + "''";
                    }
                    queryString += "','";

                    for (int i = 0; i < checkedItemsProd.Count; i++)
                    {
                        if (i == 0)
                            queryString += "''" + checkedItemsProd[i] + "''";
                        else
                            queryString += ", ''" + checkedItemsProd[i] + "''";
                    }
                    queryString += "','";
                    for (int i = 0; i < checkedItemsProdMark.Count; i++)
                    {
                        if (i == 0)
                            queryString += "''" + checkedItemsProdMark[i] + "''";
                        else
                            queryString += ", ''" + checkedItemsProdMark[i] + "''";
                    }
                    queryString += "'";

                    MessageBox.Show(queryString);
                    // Создание объекта команды для выполнения запроса 
                    SqlCommand command = new SqlCommand(queryString, conn);
                    command.Connection = conn;
                    result.Load(command.ExecuteReader());
                    bindSource.DataSource = result;
                    conn.Close();
                }
                Program.f1.dataGridView1.DataSource = result;
                Program.f1.dataGridView1.Update();
                this.Close(); 
            }
            else
            {
                guna2HtmlToolTip1.BackColor = Color.FromArgb(240, 240, 240);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", button_Column);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", button_Prim);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", button_Nazn);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", button_Prod);
                guna2HtmlToolTip1.Show("Выберите фильтры для формирования отчета", buttonProdMark);
            }
        } //применение фильтров

        private void button_Prim_Click(object sender, EventArgs e)
        {
            button_Molecula_Click(sender, e);
        }

        private void button_Nazn_Click(object sender, EventArgs e)
        {
            button_Molecula_Click(sender, e);
        }

        private void button_Prod_Click(object sender, EventArgs e)
        {
            button_Molecula_Click(sender, e);
        }

        private void buttonProdMark_Click(object sender, EventArgs e)
        {
            button_Molecula_Click(sender, e);
        }
    }
}

