using System;
using System.Windows.Forms;
namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        private login f1;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(login frm1)
        {
            InitializeComponent();
            f1 = frm1;//将传过来的Form1全部赋值给f1，这样就可以在这边调用Form1了 
            

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = f1.changetext();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void 学生登录信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void 学生信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students f = new Students();
            f.Show();
        }

        

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)//退出系统
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void 商品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新增用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd f = new UserAdd();
            f.Show();
        }

        private void 用户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement f = new UserManagement();
            f.Show();
        }

        private void 输入学生成绩ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentAdd f = new StudentAdd();
            f.Show();
        }

        private void 查看班级汇总成绩ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassGrade f = new ClassGrade();
            f.Show();
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAdd f = new CourseAdd();
            f.Show();
        }

        private void 修改课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course f = new Course();
            f.Show();
        }
    }
}
