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


    }
}
