using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppResult;
using MySql.Data.MySqlClient;

namespace AppUser
{
    class User
    {
        private int id;
        private string surname;
        private string name;
        private string patronymicName;
        private int group_id;
        private int count;

        private List<Result> results;
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string PatronymicName { get => patronymicName; set => patronymicName = value; }
        public int Group_id { get => group_id; set => group_id = value; }
        public int Id { get => id; set => id = value; }
        internal List<Result> Results { get => results; set => results = value; }
        public int Count { get => count; set => count = value; }

        public User() 
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT count(*) FROM `user`";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                this.count = int.Parse(rdr[0].ToString());
            }
            rdr.Close();
            conn.Close();
        }

        public User(int id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"SELECT * FROM `user` where id = {id}";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                this.id = int.Parse(rdr[0].ToString());
                this.surname = rdr[1].ToString();
                this.name = rdr[2].ToString();
                this.patronymicName = rdr[3].ToString();
                this.group_id = int.Parse(rdr[4].ToString());
            }
            rdr.Close();

            sql = $"SELECT * FROM `result` where user_id = {id}";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            this.Results = new List<Result>();
            while (rdr.Read())
            {
                Result resultItem = new Result(int.Parse(rdr[0].ToString()));
                Results.Add(resultItem);
            }
            rdr.Close();
            conn.Close();
        }
        public void insert(string surname, string name, string patronymicName, int group_id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"INSERT INTO `user`(`id`, `surname`, `name`, `patronymicName`, `group_id`) VALUES ('', '{surname}', '{name}', '{patronymicName}', {group_id})";
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
            string sql = $"DELETE FROM `user` WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(int id,string surname, string name, string patronymicName, int group_id)
        {
            MySqlConnection conn;
            string connectionString = @"server=localhost;userid=root;password=;database=test";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = $"UPDATE `user` SET `surname`='{surname}',`name`='{name}',`patronymicName`='{patronymicName}',`group_id`={group_id} WHERE `id` = {id}";
            var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
