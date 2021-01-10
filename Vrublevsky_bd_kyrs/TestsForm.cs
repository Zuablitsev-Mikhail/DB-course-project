using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuestion;
using AppCategory;
using AppAnswer;
using AppResult;
using AppUser;

namespace Vrublevsky_bd_kyrs
{
    public partial class TestsForm : Form
    {
        protected int questIndex = 1;
        protected int[] CorrectQuestion;
        public TestsForm()
        {
            InitializeComponent();
        }

        private void TestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void checkAnswer()
        {

        }
        private void formUpdateQuest()
        {
            Category category = new Category(int.Parse(ThemeIndex.Text));
            checkAnswer();

            pictureBox1.Image = Image.FromFile($"{category.Questions[questIndex-1].Quest_path}");
            QuestNumb.Text = $"Вопрос №{questIndex}";
        }
        private void TestsForm_Load(object sender, EventArgs e)
        {
            /*pictureBox1.Image = Image.FromFile("img/img1.png");*/
            formUpdateQuest();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NextQuest_Click(object sender, EventArgs e)
        {
            Category category = new Category(int.Parse(ThemeIndex.Text));
            if (questIndex < category.Questions.Count)
                questIndex++;
            else questIndex = 1;
            formUpdateQuest();
        }

        private void PrewQuest_Click(object sender, EventArgs e)
        {
            Category category = new Category(int.Parse(ThemeIndex.Text));
            if (questIndex > 1)
                questIndex--;
            else questIndex = category.Questions.Count;
            formUpdateQuest();
        }
    }
}
