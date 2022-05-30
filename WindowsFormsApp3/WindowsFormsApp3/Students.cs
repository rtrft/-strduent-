using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Students : Form
    {
        public Students()
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
                comboBox2.Items.Clear();
                comboBox2.Items.Add("查询所有科目");
                while (t < ds.Tables[0].Rows.Count)
                {
                    comboBox2.Items.Add(ds.Tables[0].Rows[t][0]);
                    t++;
                }

            }

        }
        public void DataBind()//查找
        {
            Student g = new Student();
            g.studentID= txtStudentsID.Text;
            g.studentName= txtStudentsName.Text;
            g.studentClass = comboBox1.Text;
            g.studentsCourse = comboBox2.Text;
            if (comboBox2.Text == "查询所有科目")
            {
                g.studentClass = "";
            }
            if (comboBox1.Text == "查询所有班级")
            {
                g.studentClass = "";
            }
            string sqlStr = "select ID,StudentID as 学生编号,StudentName as 学生姓名,StudentClass as 学生班级,StudentsCourse as 科目,RegularGrade as 平时成绩,FinalGrade as 考试成绩,SumGrade as 总成绩 from Student where 1=1";
            sqlStr += g.studentID == ""? "" : "and StudentID='" + g.studentID+ " ' ";
            sqlStr += g.studentName == ""? "" : "and StudentName like'%" + g.studentName + "%' ";
            sqlStr += g.studentClass == ""? "" : "and StudentClass='" + g.studentClass+" ' ";
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("表为空");
            }
            if (ds!=null&&ds.Tables[0].Rows.Count>0)
            {
                this.goodsView.DataSource = ds.Tables[0];
            }
            else
            {
                this.goodsView.DataSource = null;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//调用方法实现查找
        {
                DataBind();
        }

        public bool repetition(string id)
        {
            string str2 = string.Format("select * from Student where StudentID='{0}'and ID!='{1}'and StudentsCourse='{2}'", id,txtID.Text,comboBox2.Text);
            Helper help = new Helper();
            DataSet ds2 = help.GetData(str2);
            if(ds2==null)
            {
                MessageBox.Show("空");
            }
            if (ds2.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button3_Click(object sender, EventArgs e)//重置文本框
        {
 
            txtStudentsID.Text="";
            txtStudentsName.Text="";
            comboBox1.Text="";
            comboBox2.Text="";
            txtRegularGrade.Text="";
            txtFinalGrade.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)//修改
        {
            Student g = new Student();
            g.studentID = txtStudentsID.Text;
            g.studentName = txtStudentsName.Text;
            g.studentClass = comboBox1.Text;
            g.studentsCourse = comboBox2.Text;
            if (repetition(g.studentID))
            {

                if (txtRegularGrade.Text != "" && txtFinalGrade.Text != "")
                {
                    g.RegularGrade = Convert.ToDouble(txtRegularGrade.Text);
                    g.FinalGrade = Convert.ToDouble(txtFinalGrade.Text);
                    g.SumGrade = (0.3 * g.RegularGrade) + (0.7 * g.FinalGrade);
                }

                if ((0 <= g.RegularGrade && g.RegularGrade <= 100) && (0 <= g.FinalGrade && g.FinalGrade <= 100))
                {
                    string sqlStr = "Update Student Set StudentID=@gID,StudentsCourse=@studentCours,StudentName=@Name,StudentClass=@studentClass,RegularGrade=@regularGrade,FinalGrade=@finalGrade,SumGrade=@sumGrade " +
                        "where ID=@ID";
                    SqlParameter[] param =
                    {
                       new SqlParameter("@ID",txtID.Text),
                       new SqlParameter("@gID",g.studentID),
                       new SqlParameter("@Name",g.studentName),
                       new SqlParameter("@studentClass",g.studentClass),
                        new SqlParameter("@studentCours",g.studentsCourse),
                       new SqlParameter("@regularGrade",g.RegularGrade),
                       new SqlParameter("@finalGrade",g.FinalGrade),
                       new SqlParameter("@sumGrade",g.SumGrade),
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
                    MessageBox.Show("成绩范围为0-100！");
                }
            }
            else
            {
                MessageBox.Show("学号重复！");
            }
            





        }

        private void button4_Click(object sender, EventArgs e)//删除
        {
            Student g = new Student();
            g.studentID = txtStudentsID.Text;
            string sqlStr = "Delete from Student where StudentID='" + g.studentID + "'";
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

        private void goodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)//点击表格，数据显示到文本框
        {
            int rowIndex = e.RowIndex;
            if(0<=rowIndex)
            {

                 txtID.Text = goodsView.Rows[rowIndex].Cells[0].Value.ToString();
                 txtStudentsID.Text = goodsView.Rows[rowIndex].Cells[1].Value.ToString();
                 txtStudentsName.Text = goodsView.Rows[rowIndex].Cells[2].Value.ToString();
                 comboBox1.Text = goodsView.Rows[rowIndex].Cells[3].Value.ToString();
                 comboBox2.Text = goodsView.Rows[rowIndex].Cells[4].Value.ToString();
                 txtRegularGrade.Text = goodsView.Rows[rowIndex].Cells[5].Value.ToString();
                 txtFinalGrade.Text = goodsView.Rows[rowIndex].Cells[6].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("点击标题行无效！");
            }
           

        }

        private void tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) e.KeyChar = (char)0;   //处理负数
            if (e.KeyChar == '.') return ;
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

        private void button5_Click(object sender, EventArgs e)//关闭本页面
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void goodsView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
