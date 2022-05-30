using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
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
            string sqlStr = "select ID,CourseName as 课程名,CourseType as 课程类型 from Course where 1=1";
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

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//修改
        {
            CourseMod c = new CourseMod();
            c.CourseName = txtCourseName.Text;
            c.CourseType = comboBox1.Text;
            if(txtCourseName.Text!=""||comboBox1.Text!="")
            {
                string sqlStr = "Update Course Set CourseName=@Name,CourseType=@Type where ID=@id";
                SqlParameter[] param =
                {
                       new SqlParameter("@id",txtID.Text),
                       new SqlParameter("@Name",c.CourseName),
                       new SqlParameter("@Type",c.CourseType),
                 };
                Helper help = new Helper();
                if (help.Excute(sqlStr, param) > 0)
                {
                    MessageBox.Show("修改成功");
                    DataBind();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请将信息填写完整");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseMod c = new CourseMod();
            c.CourseName = txtCourseName.Text;
            string sqlStr = "Delete from Course where CourseName='" + c.CourseName + "'";
            Helper help = new Helper();
            if (help.Excute(sqlStr) > 0)
            {
                MessageBox.Show("删除成功");
                DataBind();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CourseView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtID.Text = goodsView.Rows[rowIndex].Cells[0].Value.ToString();
               txtCourseName.Text = goodsView.Rows[rowIndex].Cells[1].Value.ToString();
               comboBox1.Text = goodsView.Rows[rowIndex].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("点击标题行无效！");
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

    }
}
