namespace WindowsFormsApp3
{
    partial class StudentClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentClass));
            this.goodsView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudents2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudents2ID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsView
            // 
            this.goodsView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsView.Location = new System.Drawing.Point(1, 203);
            this.goodsView.Name = "goodsView";
            this.goodsView.RowTemplate.Height = 27;
            this.goodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsView.Size = new System.Drawing.Size(1225, 376);
            this.goodsView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox21);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudents2Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStudents2ID);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 196);
            this.panel1.TabIndex = 4;
            // 
            // comboBox21
            // 
            this.comboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "面向对象",
            "软件测试",
            "组成原理"});
            this.comboBox21.Location = new System.Drawing.Point(1032, 37);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(155, 23);
            this.comboBox21.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(762, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "退出系统";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "查询学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级";
            // 
            // txtStudents2Name
            // 
            this.txtStudents2Name.Location = new System.Drawing.Point(435, 37);
            this.txtStudents2Name.Name = "txtStudents2Name";
            this.txtStudents2Name.Size = new System.Drawing.Size(131, 25);
            this.txtStudents2Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生学号";
            // 
            // txtStudents2ID
            // 
            this.txtStudents2ID.Location = new System.Drawing.Point(116, 37);
            this.txtStudents2ID.Name = "txtStudents2ID";
            this.txtStudents2ID.Size = new System.Drawing.Size(128, 25);
            this.txtStudents2ID.TabIndex = 0;
            this.txtStudents2ID.TextChanged += new System.EventHandler(this.txtStudents2ID_TextChanged);
            this.txtStudents2ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "查询所有班级",
            "计科一班",
            "计科二班",
            "数媒一班",
            "数媒二班",
            "土木一班",
            "土木二班",
            "电器一班",
            "电器二班"});
            this.comboBox1.Location = new System.Drawing.Point(718, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // StudentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goodsView);
            this.Name = "StudentClass";
            this.Text = "学生成绩查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goodsView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudents2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudents2ID;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}