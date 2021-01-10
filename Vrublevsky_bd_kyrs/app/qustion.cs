using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppAnswer;
namespace AppQuestion
{
    class Question
    {
        private int id;
        private string quest_path;
        private int categoty_id;
        private List<Answer> answers;
        private List<Answer> correctAnswers;
        public int Id { get => id; set => id = value; }
        public string Quest_path { get => quest_path; set => quest_path = value; }
        public int Categoty_id { get => categoty_id; set => categoty_id = value; }
        public List<Answer> Answers { get => answers; set => answers = value; }
        internal List<Answer> CorrectAnswers { get => correctAnswers; set => correctAnswers = value; }

        public Question() { }
        public Question(int id) 
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `question` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.quest_path = rdr[1].ToString();
                this.categoty_id = int.Parse(rdr[2].ToString());
            }
            rdr.Close();

            sql = $"SELECT * FROM `answer` where question_id = {id}";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            this.answers = new List<Answer>();
            this.correctAnswers = new List<Answer>();
            while (rdr.Read())
            {
                Answer answer = new Answer(int.Parse(rdr[0].ToString()));
                this.answers.Add(answer);
                if (answer.IsCorrect) this.correctAnswers.Add(answer);
            }
            rdr.Close();
            conn.Close();
        }
        public void insert(string quest_path, int categoty_id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"INSERT INTO `question`(`id`, `quest_path`, `categoty_id`) VALUES ('', '{quest_path}', '{categoty_id}')";
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
            string sql = $"DELETE FROM `question` WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(int id, string quest_path, int categoty_id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"UPDATE `question` SET `quest_path`='{quest_path}',`categoty_id`='{categoty_id}' WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
