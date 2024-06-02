using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        SQLiteConnection connection;
        string tableName;

        public Form3(string tableName)
        {
            InitializeComponent();
            this.tableName = tableName;

            // Подключение к базе данных
            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "BDSQL.db");
                connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
                connection.Open();

                // Проверка на наличие таблицы с именем tableName
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

                MessageBox.Show("Соединение с базой данных успешно установлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveQuestion();
        }

        private void SaveQuestion()
        {
            // Определение правильного варианта ответа
            string correctOption = "";
            if (radioButton1.Checked)
                correctOption = "A";
            else if (radioButton2.Checked)
                correctOption = "B";
            else if (radioButton3.Checked)
                correctOption = "C";
            else if (radioButton4.Checked)
                correctOption = "D";

            // Вставка данных в таблицу
            string query = $"INSERT INTO [{tableName}] (Question, OptionA, OptionB, OptionC, OptionD, CorrectOption) " +
                           "VALUES (@Question, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectOption)";

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Question", textBox1.Text);
                    command.Parameters.AddWithValue("@OptionA", textBox2.Text);
                    command.Parameters.AddWithValue("@OptionB", textBox3.Text);
                    command.Parameters.AddWithValue("@OptionC", textBox4.Text);
                    command.Parameters.AddWithValue("@OptionD", textBox5.Text);
                    command.Parameters.AddWithValue("@CorrectOption", correctOption);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Вопрос успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить вопрос.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Сохранение в файл
                string filePath = "questions.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Question: {textBox1.Text}");
                    writer.WriteLine($"Option A: {textBox2.Text}");
                    writer.WriteLine($"Option B: {textBox3.Text}");
                    writer.WriteLine($"Option C: {textBox4.Text}");
                    writer.WriteLine($"Option D: {textBox5.Text}");
                    writer.WriteLine($"Correct Option: {correctOption}");
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении вопроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Запрос к базе данных для получения информации о вопросе
            string query = $"SELECT * FROM [{tableName}] ORDER BY ID DESC LIMIT 1"; // Предполагается, что вопросы у вас хранятся в порядке их добавления

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Заполнение текстовых полей и радиокнопок данными о вопросе
                            textBox1.Text = reader["Question"].ToString();
                            textBox2.Text = reader["OptionA"].ToString();
                            textBox3.Text = reader["OptionB"].ToString();
                            textBox4.Text = reader["OptionC"].ToString();
                            textBox5.Text = reader["OptionD"].ToString();

                            string correctOption = reader["CorrectOption"].ToString();
                            if (correctOption == "A")
                                radioButton1.Checked = true;
                            else if (correctOption == "B")
                                radioButton2.Checked = true;
                            else if (correctOption == "C")
                                radioButton3.Checked = true;
                            else if (correctOption == "D")
                                radioButton4.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("Нет доступных вопросов для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке вопроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}