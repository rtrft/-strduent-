namespace WindowsFormsApp3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.学生登录信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入学生成绩ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.管理学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看班级汇总成绩ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生登录信息管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem,
            this.查看班级汇总成绩ToolStripMenuItem1,
            this.课程管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // 学生登录信息管理ToolStripMenuItem
            // 
            this.学生登录信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增用户ToolStripMenuItem,
            this.用户信息管理ToolStripMenuItem});
            this.学生登录信息管理ToolStripMenuItem.Name = "学生登录信息管理ToolStripMenuItem";
            this.学生登录信息管理ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.学生登录信息管理ToolStripMenuItem.Text = "用户登录信息管理";
            this.学生登录信息管理ToolStripMenuItem.Click += new System.EventHandler(this.学生登录信息管理ToolStripMenuItem_Click);
            // 
            // 新增用户ToolStripMenuItem
            // 
            this.新增用户ToolStripMenuItem.Name = "新增用户ToolStripMenuItem";
            this.新增用户ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.新增用户ToolStripMenuItem.Text = "新增用户";
            this.新增用户ToolStripMenuItem.Click += new System.EventHandler(this.新增用户ToolStripMenuItem_Click);
            // 
            // 用户信息管理ToolStripMenuItem
            // 
            this.用户信息管理ToolStripMenuItem.Name = "用户信息管理ToolStripMenuItem";
            this.用户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.用户信息管理ToolStripMenuItem.Text = "用户信息管理";
            this.用户信息管理ToolStripMenuItem.Click += new System.EventHandler(this.用户信息管理ToolStripMenuItem_Click);
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输入学生成绩ToolStripMenuItem1,
            this.管理学生信息ToolStripMenuItem});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            this.学生信息管理ToolStripMenuItem.Click += new System.EventHandler(this.商品信息管理ToolStripMenuItem_Click);
            // 
            // 输入学生成绩ToolStripMenuItem1
            // 
            this.输入学生成绩ToolStripMenuItem1.Name = "输入学生成绩ToolStripMenuItem1";
            this.输入学生成绩ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.输入学生成绩ToolStripMenuItem1.Text = "输入学生成绩";
            this.输入学生成绩ToolStripMenuItem1.Click += new System.EventHandler(this.输入学生成绩ToolStripMenuItem1_Click);
            // 
            // 管理学生信息ToolStripMenuItem
            // 
            this.管理学生信息ToolStripMenuItem.Name = "管理学生信息ToolStripMenuItem";
            this.管理学生信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.管理学生信息ToolStripMenuItem.Text = "学生信息管理";
            this.管理学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息管理ToolStripMenuItem_Click);
            // 
            // 查看班级汇总成绩ToolStripMenuItem1
            // 
            this.查看班级汇总成绩ToolStripMenuItem1.Name = "查看班级汇总成绩ToolStripMenuItem1";
            this.查看班级汇总成绩ToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.查看班级汇总成绩ToolStripMenuItem1.Text = "查看班级成绩";
            this.查看班级汇总成绩ToolStripMenuItem1.Click += new System.EventHandler(this.查看班级汇总成绩ToolStripMenuItem1_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程ToolStripMenuItem,
            this.修改课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            this.课程管理ToolStripMenuItem.Click += new System.EventHandler(this.课程管理ToolStripMenuItem_Click);
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItem_Click);
            // 
            // 修改课程ToolStripMenuItem
            // 
            this.修改课程ToolStripMenuItem.Name = "修改课程ToolStripMenuItem";
            this.修改课程ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.修改课程ToolStripMenuItem.Text = "课程信息管理";
            this.修改课程ToolStripMenuItem.Click += new System.EventHandler(this.修改课程ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员页面";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem 学生登录信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理学生信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 查看班级汇总成绩ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入学生成绩ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改课程ToolStripMenuItem;
    }
}