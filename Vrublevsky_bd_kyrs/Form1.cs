using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCategory;
using AppUser;
using AppUgroup;
using AppQuestion;
using AppAnswer;
using AppResult;

namespace Vrublevsky_bd_kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Category categoryes = new Category();
            //categoryes.insert("Тема 1");
            User user = new User();
            /*user.insert("Врублевский", "Дмитрий","Батькович",1);*/
            Ugroup group = new Ugroup();
            /*group.insert("ПЗТ-30");*/
            Question quest = new Question();
            /*quest.insert("/img/1.png",1);*/
            Answer answer = new Answer();
            /*answer.insert(1, "Метла", false);*/
            Result result = new Result();
            DateTime date = new DateTime();
            date = DateTime.Now;
           /* result.insert(1,1,3, date);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ugroup group = new Ugroup();

            for(int i = 1; i <= group.Count; i++)
            {
                Ugroup groupItem = new Ugroup(i);
                GroupBox.Items.Add(groupItem.Title);
            }
            Category category = new Category();

            for (int i = 1; i <= category.Count; i++)
            {
                Category categoryItem = new Category(i);
                ThemComboBox.Items.Add(categoryItem.Title);
            }
        }

        private void GroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ugroup group = new Ugroup(GroupBox.SelectedIndex+1);

            for (int i = 1; i <= group.Users.Count; i++)
            {
                FIOComboBox.Items.Add($"{group.Users[i-1].Surname} {group.Users[i-1].Name[0]}. {group.Users[i-1].PatronymicName[0]}.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(GroupBox.Text != "" && FIOComboBox.Text != "" && ThemComboBox.Text != "")
            {
                Ugroup group = new Ugroup(GroupBox.SelectedIndex + 1);
                TestsForm testsForm = new TestsForm();
                testsForm.ThemeIndex.Text = (ThemComboBox.SelectedIndex+1).ToString();
                testsForm.UserIndex.Text = (group.Users[FIOComboBox.SelectedIndex].Id).ToString();
                testsForm.Show();
                this.Hide();
            }
        }
    }
}
