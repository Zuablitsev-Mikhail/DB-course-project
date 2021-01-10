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
        protected string[] CorrectQuestions;
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
            this.CorrectQuestions[questIndex - 1] = $"{comboBox1.Text}";
        }
        private void TestResult()
        {
            int res = 0;
            Category category = new Category(int.Parse(ThemeIndex.Text));
            for(int i = 0; i < CorrectQuestions.Length; i++)
                if (this.CorrectQuestions[i] == category.Questions[i].CorrectAnswers[0].Title) res++;
            Result result = new Result();
            DateTime date = new DateTime();
            date = DateTime.Now;
            result.insert(int.Parse(UserIndex.Text), int.Parse(ThemeIndex.Text), res, date);
            MessageBox.Show($"Вы ответили правильно на {res} из {category.Questions.Count}", "Ваш результат", MessageBoxButtons.OK);
            Application.Exit();
        }
        private void formUpdateQuest()
        {
            Category category = new Category(int.Parse(ThemeIndex.Text));
            
            comboBox1.Items.Clear();
            pictureBox1.Image = Image.FromFile($"{category.Questions[questIndex-1].Quest_path}");
            QuestNumb.Text = $"Вопрос №{questIndex}";
            foreach(Answer item in category.Questions[questIndex-1].Answers)
            {
                comboBox1.Items.Add(item.Title);
            }
            comboBox1.Text = $"{CorrectQuestions[questIndex-1]}";
        }
        private void TestsForm_Load(object sender, EventArgs e)
        {
            /*pictureBox1.Image = Image.FromFile("img/img1.png");*/
            Category category = new Category(int.Parse(ThemeIndex.Text));
            CorrectQuestions = new string[category.Questions.Count];
            for (int i = 0; i < CorrectQuestions.Length; i++){
                CorrectQuestions[i] = "";
            }
            formUpdateQuest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestResult();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAnswer();
        }
    }
}
