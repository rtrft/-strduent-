namespace WindowsFormsApp3
{
    partial class Students
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.txtRegularGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentsID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtGoodsPrice = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.goodsView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFinalGrade);
            this.panel1.Controls.Add(this.txtRegularGrade);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudentsName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStudentsID);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 343);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(690, 48);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(103, 25);
            this.txtID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID";
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(965, 139);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(92, 25);
            this.txtFinalGrade.TabIndex = 22;
            this.txtFinalGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // txtRegularGrade
            // 
            this.txtRegularGrade.Location = new System.Drawing.Point(690, 135);
            this.txtRegularGrade.Name = "txtRegularGrade";
            this.txtRegularGrade.Size = new System.Drawing.Size(103, 25);
            this.txtRegularGrade.TabIndex = 21;
            this.txtRegularGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "考试成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "平时成绩";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "面向对象",
            "软件测试",
            "组成原理"});
            this.comboBox2.Location = new System.Drawing.Point(102, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 23);
            this.comboBox2.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(899, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 34);
            this.button5.TabIndex = 15;
            this.button5.Text = "退出系统";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "删除学生信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "修改学生信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 222);
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
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "科目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级";
            // 
            // txtStudentsName
            // 
            this.txtStudentsName.Location = new System.Drawing.Point(381, 139);
            this.txtStudentsName.Name = "txtStudentsName";
            this.txtStudentsName.Size = new System.Drawing.Size(103, 25);
            this.txtStudentsName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生学号";
            // 
            // txtStudentsID
            // 
            this.txtStudentsID.Location = new System.Drawing.Point(102, 135);
            this.txtStudentsID.Name = "txtStudentsID";
            this.txtStudentsID.Size = new System.Drawing.Size(128, 25);
            this.txtStudentsID.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(419, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 25);
            this.textBox3.TabIndex = 6;
            // 
            // txtGoodsPrice
            // 
            this.txtGoodsPrice.Location = new System.Drawing.Point(419, 37);
            this.txtGoodsPrice.Name = "txtGoodsPrice";
            this.txtGoodsPrice.Size = new System.Drawing.Size(68, 25);
            this.txtGoodsPrice.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(582, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(775, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 25);
            this.textBox5.TabIndex = 10;
            // 
            // goodsView
            // 
            this.goodsView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsView.Location = new System.Drawing.Point(1, 338);
            this.goodsView.Name = "goodsView";
            this.goodsView.RowTemplate.Height = 27;
            this.goodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsView.Size = new System.Drawing.Size(1059, 319);
            this.goodsView.TabIndex = 2;
            this.goodsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsView_CellContentClick);
            this.goodsView.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsView_CellContentClick);
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
            this.comboBox1.Location = new System.Drawing.Point(356, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 25;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 658);
            this.Controls.Add(this.goodsView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStudentsID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentsName;
        private System.Windows.Forms.TextBox txtGoodsPrice;
        private System.Windows.Forms.DataGridView goodsView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.TextBox txtRegularGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

