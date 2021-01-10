using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppQuestion;

namespace AppCategory
{
    class Category
    {
        private int id;
        private string title;
        private int count;
        private List<Question> questions;
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Count { get => count; set => count = value; }
        internal List<Question> Questions { get => questions; set => questions = value; }

        public Category() {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT Count(*) FROM `category`";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.count = int.Parse(rdr[0].ToString());
            }
            rdr.Close();
            conn.Close();
        }
        public Category(int id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `category` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.title = rdr[1].ToString();
            }
            rdr.Close();

            sql = $"SELECT id FROM `question` where categoty_id = {id}";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            this.questions = new List<Question>();
            while (rdr.Read())
            {
                Question questionItem = new Question(int.Parse(rdr[0].ToString()));
                this.questions.Add(questionItem);
            }
            rdr.Close();
            conn.Close();
        }
        public void insert(string title)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"INSERT INTO `category`(`id`, `title`) VALUES ('', '{title}')";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"DELETE FROM `category` WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(int id, string title)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"UPDATE `category` SET `title`='{title}' WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
