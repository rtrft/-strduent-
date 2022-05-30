using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class CourseAdd : Form
    {
        public CourseAdd()
        {
            InitializeComponent();
        }

        private void goodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        public void DataBind()//查找
        {
            CourseMod c = new CourseMod();
            c.CourseName = txtCourseName.Text;
            c.CourseType = comboBox1.Text;
            string sqlStr = "select CourseName as 课程名,CourseType as 课程类型 from Course where 1=1";
            sqlStr += c.CourseName == "" ? "" : "and CourseName like'%" + c.CourseName + "%' ";
            sqlStr += c.CourseType == "" ? "" : "and CourseType='" + c.CourseType + " ' ";
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

        public bool repetition(string name)
        {
            string str1 = string.Format("select*from Course where CourseName='{0}'", name);
            Helper help = new Helper();
            DataSet ds = help.GetData(str1);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            CourseMod c = new CourseMod();
            c.CourseName = txtCourseName.Text;
            c.CourseType = comboBox1.Text;
            if (c.CourseName == "" || c.CourseType == "")
            {
                MessageBox.Show("信息不完整");
            }
            else if(repetition(c.CourseName))
            {
                string sqlStr = "insert into Course(CourseName,CourseType)" +
                        "values(@Name,@Type)";
                SqlParameter[] param =
                {
                    new SqlParameter("@Name",c.CourseName),
                    new SqlParameter("@Type",c.CourseType),

                };
                Helper help4 = new Helper();
                if (help4.Excute(sqlStr, param) > 0)
                {
                    MessageBox.Show(" 添加成功");
                    DataBind();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else
            {
                MessageBox.Show("课程名重复！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCourseName.Text="";
            comboBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
