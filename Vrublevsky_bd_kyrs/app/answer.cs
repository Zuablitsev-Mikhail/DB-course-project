using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnswer
{
    class Answer
    {
        private int id;
        private int question_id;
        private string title;
        private bool isCorrect;

        public int Id { get => id; set => id = value; }
        public int Question_id { get => question_id; set => question_id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsCorrect { get => isCorrect; set => isCorrect = value; }

        public Answer() { }
        public Answer(int id) 
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `answer` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.question_id = int.Parse(rdr[1].ToString());
                this.title = rdr[2].ToString();
                this.isCorrect = bool.Parse(rdr[3].ToString());
            }
            rdr.Close();
            conn.Close();
        }
        public void insert(int question_id, string title, bool isCorrect)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"INSERT INTO `answer`(`id`, `question_id`, `title`, `isCorrect`) VALUES ('', {question_id}, '{title}', {isCorrect})";
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
            string sql = $"DELETE FROM `answer` WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(int id, int question_id, string title, bool isCorrect)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"UPDATE `answer` SET `question_id`={question_id},`title`='{title}',`isCorrect`={isCorrect} WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
