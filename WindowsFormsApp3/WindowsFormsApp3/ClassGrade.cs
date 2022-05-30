using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class ClassGrade : Form
    {
        public ClassGrade()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DataBind2();
            DataBindCourse();
        }

        private void button1_Click(object sender, EventArgs e)//调用方法实现查找
        {
            if (comboBox1.Text == "全班汇总成绩")
            {
                DataBind3();
            }
            else if (comboBox1.Text == "全班单科成绩")
            {
                DataBind2();
            }
           
            else
            {
                MessageBox.Show("错误！没有这种格式输出");
            }
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

        public void DataBind2()//查找
        {
            Student g = new Student();
            g.studentClass = comboBox3.Text;
            g.studentsCourse = comboBox2.Text;
            if (comboBox2.Text == "查询所有科目")
            {
                g.studentsCourse = "";
            }
            if (comboBox3.Text == "查询所有班级")
            {
                g.studentClass = "";
            }
            string sqlStr = "select StudentClass as 学生班级,StudentID as 学生编号,Teacher as 任课教师,Time as 时间," +
                "StudentName as 学生姓名,StudentsCourse as 科目,RegularGrade as 平时成绩,FinalGrade as 考试成绩,SumGrade as 总成绩 from Student where 1=1";
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

        public void DataBind3()//查找
        {
            Student g = new Student();
            g.studentClass = comboBox3.Text;
            g.studentsCourse = comboBox2.Text;
            if (comboBox2.Text == "" || comboBox3.Text == ""||comboBox3.Text=="查询所有班级")
            {
                MessageBox.Show("查询汇总成绩，请选择具体的班级和科目");
                return;
            }
            string sqlStr1 = "select * from Course where 1=1";
            Helper help1 = new Helper();
            DataSet ds1 = help1.GetData(sqlStr1);
            string sqlStr2 = "select * from Class where 1=1";
            Helper help2 = new Helper();
            DataSet ds2 = help1.GetData(sqlStr2);
            int i = 0;
            double sum = 0, avgsum = 0;
            string sqlStr3 = "select StudentClass as 学生班级,StudentName as 学生姓名,StudentsCourse as 科目,SumGrade as 总成绩 " +
              "from Student where 1=1";
            sqlStr3 += g.studentsCourse == "" ? "" : "and StudentsCourse='" + g.studentsCourse + " ' ";
            sqlStr3 += g.studentClass == "" ? "" : "and StudentClass='" + g.studentClass + " ' ";
            Helper help3 = new Helper();
            DataSet ds3 = help3.GetData(sqlStr3);
            int count = 0;
            if (ds3 == null)
            {
                MessageBox.Show("表为空");
            }
            if (ds3 != null && ds3.Tables[0].Rows.Count > 0)
            {
                count = ds3.Tables[0].Rows.Count;
                int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
                while (i < count)
                {
                    double a;
                    a = Convert.ToDouble(ds3.Tables[0].Rows[i][3]);
                    sum = sum + a;
                    avgsum = sum / Convert.ToDouble(count);
                    if (90 <= a && a < 100)
                    {
                        count1 = count1 + 1;
                    }
                    else if (80 <= a && a < 90)
                    {
                        count2 = count2 + 1;
                    }
                    else if (70 <= a && a < 80)
                    {
                        count3 = count3 + 1;
                    }
                    else if (60 <= a && a < 70)
                    {
                        count4 = count4 + 1;
                    }
                    else if (0 <= a && a < 60)
                    {
                        count5 = count5 + 1;
                    }

                    i++;
                }
                string sqlStr4 = "insert into SumStudents(StudentClass,StudentsCourse,averageSumGrade,Excellent,Good,Average,Fair,Poor)" +
                         "values(@sumStudentClass,@sumStudentsCourse,@sumaverageSumGrade,@sumExcellent,@sumGood,@sumAverage,@sumFair,@sumPoor)";
                SqlParameter[] param4 =
                {
                new SqlParameter("@sumStudentClass",ds3.Tables[0].Rows[0][0]),
                new SqlParameter("@sumStudentsCourse",ds3.Tables[0].Rows[0][2]),
                new SqlParameter("@sumaverageSumGrade",avgsum),
                new SqlParameter("@sumExcellent",count1),
                new SqlParameter("@sumGood",count2),
                new SqlParameter("@sumAverage",count3),
                new SqlParameter("@sumFair",count4),
                new SqlParameter("@sumPoor",count5),
                };
                Helper help6 = new Helper();
                string cmd = "truncate table  SumStudents";
                help6.Excute(cmd);
                Helper help4 = new Helper();
                if (help4.Excute(sqlStr4, param4) > 0)
                {
                    MessageBox.Show("查询成功");
                }
                else
                {
                    MessageBox.Show("查询失败！");
                }
            }
            else
            {
                MessageBox.Show("表为空");
                this.goodsView.DataSource = null;
            }

            string sqlStr5 = "select * from SumStudents where 1=1";
            sqlStr5 += g.studentsCourse == "" ? "" : "and StudentsCourse='" + g.studentsCourse + " ' ";
            sqlStr5 += g.studentClass == "" ? "" : "and StudentClass='" + g.studentClass + " ' ";
            Helper help5 = new Helper();
            DataSet ds5 = help1.GetData(sqlStr5);
            if (ds5 == null)
            {
                MessageBox.Show("表为空");
            }
            if (ds5 != null && ds5.Tables[0].Rows.Count > 0)
            {
                this.goodsView.DataSource = ds5.Tables[0];
            }
            else
            {
                this.goodsView.DataSource = null;
            }
            
           
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
