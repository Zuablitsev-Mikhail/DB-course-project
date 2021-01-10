using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppResult
{
    class Result
    {
        private int id;
        private int user_id;
        private int categoty_id;
        private int correctCount;
        private DateTime date;

        public int Id { get => id; set => id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Categoty_id { get => categoty_id; set => categoty_id = value; }
        public int CorrectCount { get => correctCount; set => correctCount = value; }
        public DateTime Date { get => date; set => date = value; }

        public Result() { }
        public Result(int id) 
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `result` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.user_id = int.Parse(rdr[1].ToString());
                this.categoty_id = int.Parse(rdr[2].ToString());
                this.correctCount = int.Parse(rdr[3].ToString());
                this.date = DateTime.Parse(rdr[4].ToString());
            }
            rdr.Close();
            conn.Close();
        }
        public void insert(int user_id, int categoty_id, int correctCount, DateTime date)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string ndate = date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"INSERT INTO `result`(`id`, `user_id`, `categoty_id`, `correctCount`, `date`) VALUES ('', {user_id}, {categoty_id}, {correctCount}, '{ndate}')";
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
            string sql = $"DELETE FROM `result` WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(int id, int user_id, int categoty_id, int correctCount, DateTime date)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string ndate = date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"UPDATE `result` SET `user_id`={user_id},`categoty_id`={categoty_id},`correctCount`={correctCount},`date`='{ndate}' WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}