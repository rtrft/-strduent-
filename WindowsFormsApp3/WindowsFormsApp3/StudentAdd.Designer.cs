namespace WindowsFormsApp3
{
    partial class StudentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.txtTeacher1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalGrade1 = new System.Windows.Forms.TextBox();
            this.txtRegularGrade1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudents1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudents1ID = new System.Windows.Forms.TextBox();
            this.goodsView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox12);
            this.panel1.Controls.Add(this.txtTeacher1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFinalGrade1);
            this.panel1.Controls.Add(this.txtRegularGrade1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox11);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudents1Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStudents1ID);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 254);
            this.panel1.TabIndex = 2;
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "2019-2020第一学期",
            "2019-2020第二学期",
            "2020-2021第一学期",
            "2020-2021第二学期",
            "2021-2022第一学期",
            "2021-2022第二学期",
            "2020"});
            this.comboBox12.Location = new System.Drawing.Point(330, 51);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(135, 23);
            this.comboBox12.TabIndex = 27;
            // 
            // txtTeacher1
            // 
            this.txtTeacher1.Location = new System.Drawing.Point(78, 122);
            this.txtTeacher1.Name = "txtTeacher1";
            this.txtTeacher1.Size = new System.Drawing.Size(134, 25);
            this.txtTeacher1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "任课老师";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "任课时间";
            // 
            // txtFinalGrade1
            // 
            this.txtFinalGrade1.Location = new System.Drawing.Point(610, 122);
            this.txtFinalGrade1.Name = "txtFinalGrade1";
            this.txtFinalGrade1.Size = new System.Drawing.Size(128, 25);
            this.txtFinalGrade1.TabIndex = 22;
            this.txtFinalGrade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // txtRegularGrade1
            // 
            this.txtRegularGrade1.Location = new System.Drawing.Point(330, 119);
            this.txtRegularGrade1.Name = "txtRegularGrade1";
            this.txtRegularGrade1.Size = new System.Drawing.Size(135, 25);
            this.txtRegularGrade1.TabIndex = 21;
            this.txtRegularGrade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "考试成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "平时成绩";
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "面向对象",
            "软件测试",
            "组成原理"});
            this.comboBox11.Location = new System.Drawing.Point(78, 47);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(134, 23);
            this.comboBox11.TabIndex = 18;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(859, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 34);
            this.button5.TabIndex = 15;
            this.button5.Text = "退出系统";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "输入学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级";
            // 
            // txtStudents1Name
            // 
            this.txtStudents1Name.Location = new System.Drawing.Point(1086, 52);
            this.txtStudents1Name.Name = "txtStudents1Name";
            this.txtStudents1Name.Size = new System.Drawing.Size(128, 25);
            this.txtStudents1Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生学号";
            // 
            // txtStudents1ID
            // 
            this.txtStudents1ID.Location = new System.Drawing.Point(859, 51);
            this.txtStudents1ID.Name = "txtStudents1ID";
            this.txtStudents1ID.Size = new System.Drawing.Size(128, 25);
            this.txtStudents1ID.TabIndex = 0;
            this.txtStudents1ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // goodsView
            // 
            this.goodsView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsView.Location = new System.Drawing.Point(1, 261);
            this.goodsView.Name = "goodsView";
            this.goodsView.RowTemplate.Height = 27;
            this.goodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsView.Size = new System.Drawing.Size(1225, 234);
            this.goodsView.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "计科一班",
            "计科二班",
            "数媒一班",
            "数媒二班",
            "土木一班",
            "土木二班",
            "电器一班",
            "电器二班"});
            this.comboBox1.Location = new System.Drawing.Point(565, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 23);
            this.comboBox1.TabIndex = 28;
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 491);
            this.Controls.Add(this.goodsView);
            this.Controls.Add(this.panel1);
            this.Name = "StudentAdd";
            this.Text = "输出学生成绩";
            this.Load += new System.EventHandler(this.Student2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFinalGrade1;
        private System.Windows.Forms.TextBox txtRegularGrade1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudents1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudents1ID;
        private System.Windows.Forms.DataGridView goodsView;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.TextBox txtTeacher1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}