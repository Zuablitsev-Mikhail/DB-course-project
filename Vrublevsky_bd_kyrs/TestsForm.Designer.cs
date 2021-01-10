namespace Vrublevsky_bd_kyrs
{
    partial class TestsForm
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
            this.ThemeIndex = new System.Windows.Forms.Label();
            this.UserIndex = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NextQuest = new System.Windows.Forms.Button();
            this.PrewQuest = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.QuestNumb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeIndex
            // 
            this.ThemeIndex.AutoSize = true;
            this.ThemeIndex.Location = new System.Drawing.Point(13, 13);
            this.ThemeIndex.Name = "ThemeIndex";
            this.ThemeIndex.Size = new System.Drawing.Size(0, 13);
            this.ThemeIndex.TabIndex = 0;
            this.ThemeIndex.Visible = false;
            // 
            // UserIndex
            // 
            this.UserIndex.AutoSize = true;
            this.UserIndex.Location = new System.Drawing.Point(13, 36);
            this.UserIndex.Name = "UserIndex";
            this.UserIndex.Size = new System.Drawing.Size(0, 13);
            this.UserIndex.TabIndex = 1;
            this.UserIndex.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 424);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NextQuest
            // 
            this.NextQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuest.Location = new System.Drawing.Point(685, 479);
            this.NextQuest.Name = "NextQuest";
            this.NextQuest.Size = new System.Drawing.Size(44, 23);
            this.NextQuest.TabIndex = 4;
            this.NextQuest.Text = ">";
            this.NextQuest.UseVisualStyleBackColor = true;
            this.NextQuest.Click += new System.EventHandler(this.NextQuest_Click);
            // 
            // PrewQuest
            // 
            this.PrewQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrewQuest.Location = new System.Drawing.Point(337, 479);
            this.PrewQuest.Name = "PrewQuest";
            this.PrewQuest.Size = new System.Drawing.Size(44, 23);
            this.PrewQuest.TabIndex = 5;
            this.PrewQuest.Text = "<";
            this.PrewQuest.UseVisualStyleBackColor = true;
            this.PrewQuest.Click += new System.EventHandler(this.PrewQuest_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndBtn.Location = new System.Drawing.Point(478, 543);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(120, 23);
            this.EndBtn.TabIndex = 6;
            this.EndBtn.Text = "Завершить";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestNumb
            // 
            this.QuestNumb.AutoSize = true;
            this.QuestNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestNumb.Location = new System.Drawing.Point(495, 13);
            this.QuestNumb.Name = "QuestNumb";
            this.QuestNumb.Size = new System.Drawing.Size(0, 20);
            this.QuestNumb.TabIndex = 7;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 612);
            this.Controls.Add(this.QuestNumb);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.PrewQuest);
            this.Controls.Add(this.NextQuest);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserIndex);
            this.Controls.Add(this.ThemeIndex);
            this.Name = "TestsForm";
            this.Text = "TestsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestsForm_FormClosing);
            this.Load += new System.EventHandler(this.TestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ThemeIndex;
        public System.Windows.Forms.Label UserIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NextQuest;
        private System.Windows.Forms.Button PrewQuest;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Label QuestNumb;
    }
}