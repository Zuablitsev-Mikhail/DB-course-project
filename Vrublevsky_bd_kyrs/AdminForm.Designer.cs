﻿namespace Vrublevsky_bd_kyrs
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPanelToll = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Button();
            this.ugroup = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.table_name = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.UserResult = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GroupResultsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AdminPanelToll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 576);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(332, 211);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(302, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(332, 171);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(302, 20);
            this.LoginBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // AdminPanelToll
            // 
            this.AdminPanelToll.Controls.Add(this.dataGridView1);
            this.AdminPanelToll.Controls.Add(this.panel3);
            this.AdminPanelToll.Controls.Add(this.panel2);
            this.AdminPanelToll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanelToll.Location = new System.Drawing.Point(0, 0);
            this.AdminPanelToll.Name = "AdminPanelToll";
            this.AdminPanelToll.Size = new System.Drawing.Size(874, 576);
            this.AdminPanelToll.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(200, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 511);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.remove);
            this.panel3.Controls.Add(this.reload);
            this.panel3.Controls.Add(this.add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 65);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GroupResultsBtn);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.result);
            this.panel2.Controls.Add(this.UserResult);
            this.panel2.Controls.Add(this.table_name);
            this.panel2.Controls.Add(this.answer);
            this.panel2.Controls.Add(this.question);
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.ugroup);
            this.panel2.Controls.Add(this.user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 576);
            this.panel2.TabIndex = 0;
            // 
            // category
            // 
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Location = new System.Drawing.Point(12, 91);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(154, 23);
            this.category.TabIndex = 3;
            this.category.Text = "Темы";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.button_bd);
            // 
            // ugroup
            // 
            this.ugroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ugroup.Location = new System.Drawing.Point(12, 50);
            this.ugroup.Name = "ugroup";
            this.ugroup.Size = new System.Drawing.Size(154, 23);
            this.ugroup.TabIndex = 2;
            this.ugroup.Text = "Группы";
            this.ugroup.UseVisualStyleBackColor = true;
            this.ugroup.Click += new System.EventHandler(this.button_bd);
            // 
            // user
            // 
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Location = new System.Drawing.Point(12, 12);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(154, 23);
            this.user.TabIndex = 1;
            this.user.Text = "Студенты";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.button_bd);
            // 
            // question
            // 
            this.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question.Location = new System.Drawing.Point(12, 129);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(154, 23);
            this.question.TabIndex = 4;
            this.question.Text = "Вопросы";
            this.question.UseVisualStyleBackColor = true;
            this.question.Click += new System.EventHandler(this.button_bd);
            // 
            // answer
            // 
            this.answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer.Location = new System.Drawing.Point(12, 169);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(154, 23);
            this.answer.TabIndex = 5;
            this.answer.Text = "Ответы";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.button_bd);
            // 
            // table_name
            // 
            this.table_name.AutoSize = true;
            this.table_name.Location = new System.Drawing.Point(4, 560);
            this.table_name.Name = "table_name";
            this.table_name.Size = new System.Drawing.Size(0, 13);
            this.table_name.TabIndex = 6;
            this.table_name.Visible = false;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(21, 16);
            this.add.MaximumSize = new System.Drawing.Size(117, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 37);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // reload
            // 
            this.reload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(266, 16);
            this.reload.MaximumSize = new System.Drawing.Size(117, 37);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(117, 37);
            this.reload.TabIndex = 3;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove.Location = new System.Drawing.Point(513, 16);
            this.remove.MaximumSize = new System.Drawing.Size(117, 37);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(117, 37);
            this.remove.TabIndex = 4;
            this.remove.Text = "Удалить";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // UserResult
            // 
            this.UserResult.Enabled = false;
            this.UserResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserResult.Location = new System.Drawing.Point(7, 340);
            this.UserResult.Name = "UserResult";
            this.UserResult.Size = new System.Drawing.Size(182, 23);
            this.UserResult.TabIndex = 7;
            this.UserResult.Text = "Отчёт по результатам человека";
            this.UserResult.UseVisualStyleBackColor = true;
            this.UserResult.Click += new System.EventHandler(this.UserResult_Click);
            // 
            // result
            // 
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Location = new System.Drawing.Point(12, 211);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(154, 23);
            this.result.TabIndex = 8;
            this.result.Text = "Результаты";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 284);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GroupResultsBtn
            // 
            this.GroupResultsBtn.Enabled = false;
            this.GroupResultsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupResultsBtn.Location = new System.Drawing.Point(7, 311);
            this.GroupResultsBtn.Name = "GroupResultsBtn";
            this.GroupResultsBtn.Size = new System.Drawing.Size(182, 23);
            this.GroupResultsBtn.TabIndex = 11;
            this.GroupResultsBtn.Text = "Отчёт по результатам группы";
            this.GroupResultsBtn.UseVisualStyleBackColor = true;
            this.GroupResultsBtn.Click += new System.EventHandler(this.GroupResultsBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 576);
            this.Controls.Add(this.AdminPanelToll);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AdminPanelToll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Panel AdminPanelToll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button ugroup;
        private System.Windows.Forms.Label table_name;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.Button question;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button UserResult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GroupResultsBtn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}