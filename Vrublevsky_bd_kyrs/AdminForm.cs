using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppAnswer;
using AppCategory;
using AppQuestion;
using AppUgroup;
using AppResult;
using AppUser;
using System.IO;
using System.Diagnostics;

namespace Vrublevsky_bd_kyrs
{
    public partial class AdminForm : Form
    {
        public const string LOGIN = "admin";
        public const string PASSWORD = "admin";
        public AdminForm()
        {
            InitializeComponent();
            AdminPanelToll.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginBox.Text == LOGIN && PasswordBox.Text == PASSWORD)
            {
                panel1.Hide();
                AdminPanelToll.Show();
            }
        }
        private void button_bd(object sender, EventArgs e)
        {
            string ConnectionString = @"server=localhost;userid=root;password=;database=test";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Button btn = sender as Button;
            var con = new MySqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT* FROM `" + btn.Name + "`";
            var cmd = new MySqlCommand(query, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int v = rdr.FieldCount;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < v; i++)
            {
                dataGridView1.Columns.Add(rdr.GetName(i).ToString(), rdr.GetName(i).ToString());
            }
            while (rdr.Read())
            {
                data.Add(new string[v]);
                for (int i = 0; i < v; i++)
                {
                    data[data.Count - 1][i] = rdr[i].ToString();
                }
            }
            rdr.Close();
            con.Close();
            foreach (string[] str in data)
            {
                dataGridView1.Rows.Add(str);
            }
            data.Clear();
            table_name.Text = btn.Name;
        }
        private void tableUpdate()
        {
            string ConnectionString = @"server=localhost;userid=root;password=;database=test";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var con = new MySqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT* FROM `" + table_name.Text + "`";
            var cmd = new MySqlCommand(query, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int v = rdr.FieldCount;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < v; i++)
            {
                dataGridView1.Columns.Add(rdr.GetName(i).ToString(), rdr.GetName(i).ToString());
            }
            while (rdr.Read())
            {
                data.Add(new string[v]);
                for (int i = 0; i < v; i++)
                {
                    data[data.Count - 1][i] = rdr[i].ToString();
                }
            }
            rdr.Close();
            con.Close();
            foreach (string[] str in data)
            {
                dataGridView1.Rows.Add(str);
            }
            data.Clear();
        }
        private void add_Click(object sender, EventArgs e)
        {
            switch (table_name.Text)
            {
                case "user":
                    try
                    {
                        User user = new User();
                        string surname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string patronymicName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        int groupId = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null && dataGridView1.SelectedRows[0].Cells[4].Value != null)
                            user.insert(surname, name, patronymicName, groupId);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "ugroup":
                    try { 
                    Ugroup ugroup = new Ugroup();
                        string title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                            ugroup.insert(title);
                        else MessageBox.Show("Вы не заполнили все поля","Внимание",MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "category":
                    try { 
                        Category category = new Category();
                        string catTitle = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                            category.insert(catTitle);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "question":
                    try { 
                        Question question = new Question();
                        string path = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        int categoryId = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null)
                            question.insert(path,categoryId);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "answer":
                    try
                    {
                        Answer answer = new Answer();
                        int questionId = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        string ansTitle = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        bool isCorrect = bool.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
                            answer.insert(questionId, ansTitle, isCorrect);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }catch (System.FormatException){
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            string[] date;
            User user = new User();
            StreamWriter streamwriter = new StreamWriter(@"index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>таблица результатов</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine(" <style>table,tr,td,th{border: 1px solid black; text-align: center;} table{border-collapse: collapse; margin: 0 auto;} td,th{padding: 5px;}  h1{text-align: center;}</style>");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("<h1>Результаты тестрования всех групп</h1>");
            streamwriter.WriteLine("<table>");
            streamwriter.WriteLine("<tr><th>Группа</th><th>ФИО</th><th>Тест</th><th>правильных ответов</th><th>Дата прохождения</th></tr>");
            for(int i = 1; i <= user.Count; i++)
            {
                User userItem = new User(i);
                for(int j = 1; j <= userItem.Results.Count; j++)
                {
                    date = (userItem.Results[j - 1].Date.ToString()).Split();
                    Category category = new Category(userItem.Results[j - 1].Categoty_id);
                    Ugroup ugroup = new Ugroup(userItem.Group_id);
                    streamwriter.WriteLine("<tr>");
                    streamwriter.WriteLine($"<td>{ugroup.Title}.</td>");
                    streamwriter.WriteLine($"<td>{userItem.Surname} {userItem.Name[0]}. {userItem.PatronymicName[0]}.</td>");
                    streamwriter.WriteLine($"<td>{category.Title}.</td>");
                    streamwriter.WriteLine($"<td>{userItem.Results[j-1].CorrectCount}</td>");
                    streamwriter.WriteLine($"<td>{date[0]}</td>");
                    streamwriter.WriteLine("</tr>");
                }
            }
            streamwriter.WriteLine("</table>");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
            Process.Start("index.html");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupResultsBtn.Enabled = true;
            comboBox2.Items.Clear();
            Ugroup group = new Ugroup(comboBox1.SelectedIndex+1);
            for (int i = 1; i <= group.Users.Count; i++)
            {
                comboBox2.Items.Add($"{group.Users[i - 1].Surname} {group.Users[i - 1].Name[0]}. {group.Users[i - 1].PatronymicName[0]}.");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            Ugroup ugroup = new Ugroup();
            for (int i = 1; i <= ugroup.Count; i++)
            {
                Ugroup ugroupItem = new Ugroup(i);
                comboBox1.Items.Add($"{ugroupItem.Title}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserResult.Enabled = true;
        }

        private void GroupResultsBtn_Click(object sender, EventArgs e)
        {
            string[] date;
            User user = new User();
            StreamWriter streamwriter = new StreamWriter(@"index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>таблица результатов</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine(" <style>table,tr,td,th{border: 1px solid black; text-align: center;} table{border-collapse: collapse; margin: 0 auto;} td,th{padding: 5px;}  h1{text-align: center;}</style>");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("<h1>Результаты тестрования всех групп</h1>");
            streamwriter.WriteLine("<table>");
            streamwriter.WriteLine("<tr><th>Группа</th><th>ФИО</th><th>Тест</th><th>правильных ответов</th><th>Дата прохождения</th></tr>");
            for (int i = 1; i <= user.Count; i++)
            {
                User userItem = new User(i);
                if(userItem.Group_id == comboBox1.SelectedIndex+1)
                for (int j = 1; j <= userItem.Results.Count; j++)
                {
                    date = (userItem.Results[j - 1].Date.ToString()).Split();
                    Category category = new Category(userItem.Results[j - 1].Categoty_id);
                    Ugroup ugroup = new Ugroup(userItem.Group_id);
                    streamwriter.WriteLine("<tr>");
                    streamwriter.WriteLine($"<td>{ugroup.Title}.</td>");
                    streamwriter.WriteLine($"<td>{userItem.Surname} {userItem.Name[0]}. {userItem.PatronymicName[0]}.</td>");
                    streamwriter.WriteLine($"<td>{category.Title}.</td>");
                    streamwriter.WriteLine($"<td>{userItem.Results[j - 1].CorrectCount}</td>");
                    streamwriter.WriteLine($"<td>{date[0]}</td>");
                    streamwriter.WriteLine("</tr>");
                }
            }
            streamwriter.WriteLine("</table>");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
            Process.Start("index.html");
        }

        private void UserResult_Click(object sender, EventArgs e)
        {
            string[] date;
            User user = new User();
            StreamWriter streamwriter = new StreamWriter(@"index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>таблица результатов</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine(" <style>table,tr,td,th{border: 1px solid black; text-align: center;} table{border-collapse: collapse; margin: 0 auto;} td,th{padding: 5px;}  h1{text-align: center;}</style>");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("<h1>Результаты тестрования всех групп</h1>");
            streamwriter.WriteLine("<table>");
            streamwriter.WriteLine("<tr><th>Группа</th><th>ФИО</th><th>Тест</th><th>правильных ответов</th><th>Дата прохождения</th></tr>");
            for (int i = 1; i <= user.Count; i++)
            {
                User userItem = new User(i);
                Ugroup ugroup = new Ugroup(comboBox1.SelectedIndex+1);
                if (userItem.Id == ugroup.Users[comboBox2.SelectedIndex].Id)
                    for (int j = 1; j <= userItem.Results.Count; j++)
                    {
                        date = (userItem.Results[j - 1].Date.ToString()).Split();
                        Category category = new Category(userItem.Results[j - 1].Categoty_id);
                        streamwriter.WriteLine("<tr>");
                        streamwriter.WriteLine($"<td>{ugroup.Title}.</td>");
                        streamwriter.WriteLine($"<td>{userItem.Surname} {userItem.Name[0]}. {userItem.PatronymicName[0]}.</td>");
                        streamwriter.WriteLine($"<td>{category.Title}.</td>");
                        streamwriter.WriteLine($"<td>{userItem.Results[j - 1].CorrectCount}</td>");
                        streamwriter.WriteLine($"<td>{date[0]}</td>");
                        streamwriter.WriteLine("</tr>");
                    }
            }
            streamwriter.WriteLine("</table>");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
            Process.Start("index.html");
        }

        private void remove_Click(object sender, EventArgs e)
        {
            switch (table_name.Text)
            {
                case "user":
                    User user = new User();
                    user.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;

                case "ugroup":
                    Ugroup ugroup = new Ugroup();
                    ugroup.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;

                case "category":
                    Category category = new Category();
                    category.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;

                case "question":
                    Question question = new Question();
                    question.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;

                case "answer":
                    Answer answer = new Answer();
                    answer.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;

                case "result":
                    Result result = new Result();
                    result.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    tableUpdate();
                    break;
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            switch (table_name.Text)
            {
                case "user":
                    try
                    {
                        User user = new User();
                        string surname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string patronymicName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        int groupId = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null && dataGridView1.SelectedRows[0].Cells[4].Value != null)
                            user.Update(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), surname, name, patronymicName, groupId);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "ugroup":
                    try
                    {
                        Ugroup ugroup = new Ugroup();
                        string title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                            ugroup.Update(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), title);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "category":
                    try
                    {
                        Category category = new Category();
                        string catTitle = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                            category.Update(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), catTitle);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "question":
                    try
                    {
                        Question question = new Question();
                        string path = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        int categoryId = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null)
                            question.Update(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), path, categoryId);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
                case "answer":
                    try
                    {
                        Answer answer = new Answer();
                        int questionId = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        string ansTitle = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        bool isCorrect = bool.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
                            answer.Update(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),questionId, ansTitle, isCorrect);
                        else MessageBox.Show("Вы не заполнили все поля", "Внимание", MessageBoxButtons.OK);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Некорректно заполнены поля", "Внимание", MessageBoxButtons.OK);
                    }
                    tableUpdate();
                    break;
            }
        }
    }
}
