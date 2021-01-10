using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string PatronymicName { get => patronymicName; set => patronymicName = value; }
        public int Group_id { get => group_id; set => group_id = value; }
        public int Id { get => id; set => id = value; }

        public User() { }

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

    }
}
