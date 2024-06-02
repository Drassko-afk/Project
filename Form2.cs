using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Показ формы Form8 для ввода названия таблицы
            using (Form8 form8 = new Form8())
            {
                if (form8.ShowDialog() == DialogResult.OK)
                {
                    string tableName = form8.TableName;

                    // Создание новой таблицы в базе данных
                    string connectionString = "Data Source=yourdatabase.db;Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string createTableQuery = $"CREATE TABLE IF NOT EXISTS [{tableName}] (" +
                                                  "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                  "Question TEXT," +
                                                  "OptionA TEXT," +
                                                  "OptionB TEXT," +
                                                  "OptionC TEXT," +
                                                  "OptionD TEXT," +
                                                  "CorrectOption TEXT)";

                        using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    // Открытие Form3 с именем таблицы
                    Form3 form3 = new Form3(tableName);
                    form3.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("defaultTableName"); // замените "defaultTableName" на реальное имя таблицы, если необходимо
            form3.ShowDialog();
        }
    }
}
