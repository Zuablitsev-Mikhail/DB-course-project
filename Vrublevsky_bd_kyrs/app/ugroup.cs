using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUser;

namespace AppUgroup
{
    class Ugroup
    {
        private int id;
        private string title;
        private List<User> users;
        private int count;
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Count { get => count;}
        internal List<User> Users { get => users; set => users = value; }

        public Ugroup() {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT count(*) FROM `ugroup`";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.count = int.Parse(rdr[0].ToString());
            }
            rdr.Close();
            conn.Close();
        }
        public Ugroup(int id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `ugroup` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.title = rdr[1].ToString();
            }
            rdr.Close();
            sql = $"SELECT * FROM `user` where group_id = {id}";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            this.Users = new List<User>();
            while (rdr.Read())
            {
                User user = new User(int.Parse(rdr[0].ToString()));
                this.Users.Add(user);
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
            string sql = $"INSERT INTO `ugroup`(`id`, `title`) VALUES ('', '{title}')";
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
            string sql = $"DELETE FROM `ugroup` WHERE `id` = {id}";
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
            string sql = $"UPDATE `ugroup` SET `title`='{title}' WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
