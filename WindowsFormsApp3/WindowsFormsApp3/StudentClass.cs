using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StudentClass : Form
    {
        public StudentClass()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataBind();
            DataBindCourse();
        }
        public void DataBindCourse()//查找
        {
            string sqlStr = "select CourseName from Course where 1=1";
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("表为空");
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                int t = 0;
                comboBox21.Items.Clear();
                comboBox21.Items.Add("查询所有科目");
                while (t < ds.Tables[0].Rows.Count)
                {
                    comboBox21.Items.Add(ds.Tables[0].Rows[t][0]);
                    t++;
                }

            }

        }
        public void DataBind()//查找
        {
            Student g = new Student();
            g.studentID = txtStudents2ID.Text;
            g.studentName = txtStudents2Name.Text;
            g.studentClass = comboBox1.Text;
            g.studentsCourse = comboBox21.Text;
            if (comboBox21.Text == "查询所有科目")
            {
                g.studentsCourse = "";
            }
            if (comboBox1.Text == "查询所有班级")
            {
                g.studentClass = "";
            }
            string sqlStr = "select StudentClass as 学生班级,StudentID as 学生编号,Teacher as 任课教师,Time as 时间," +
                "StudentName as 学生姓名,StudentsCourse as 科目,RegularGrade as 平时成绩,FinalGrade as 考试成绩,SumGrade as 总成绩 from Student where 1=1";
            sqlStr += g.studentID == "" ? "" : "and StudentID='" + g.studentID + " ' ";
            sqlStr += g.studentName == "" ? "" : "and StudentName like'%" + g.studentName + "%' ";
            sqlStr += g.studentClass == "" ? "" : "and StudentClass='" + g.studentClass + " ' ";
            sqlStr += g.studentsCourse == "" ? "" : "and StudentsCourse='" + g.studentsCourse + " ' ";
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("表为空");
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.goodsView.DataSource = ds.Tables[0];
            }
            else
            {
                this.goodsView.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtStudents2ID.Text = "";
            txtStudents2Name.Text = "";
            comboBox1.Text = "";
            comboBox21.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStudents2ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
    }
}
