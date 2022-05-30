using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void Student2_Load(object sender, EventArgs e)
        {
            DataBind();
            DataBindCourse();
        }
        public bool repetition(string id)
        {
            string str2 = string.Format("select * from Student where StudentID='{0}'and StudentsCourse='{1}'",txtStudents1ID.Text,comboBox11.Text);
            Helper help = new Helper();
            DataSet ds = help.GetData(str2);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DataBind()//查找
        {
            string sqlStr = "select StudentClass as 学生班级,StudentID as 学生编号,Teacher as 任课教师,Time as 时间," +
                "StudentName as 学生姓名,StudentsCourse as 科目,RegularGrade as 平时成绩,FinalGrade as 考试成绩,SumGrade as 总成绩 from Student where 1=1";
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
                comboBox11.Items.Clear();
                while(t<ds.Tables[0].Rows.Count)
                {
                    comboBox11.Items.Add(ds.Tables[0].Rows[t][0]);
                    t++;
                }
                    
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//添加
        {
            
            Student g = new Student();
            g.studentID = txtStudents1ID.Text;
            g.studentName = txtStudents1Name.Text;
            g.studentClass = comboBox1.Text;
            g.studentsCourse = comboBox11.Text;
            g.Time = comboBox12.Text;
            g.Teacher = txtTeacher1.Text;
            if(g.studentID==""||g.studentName==""||g.studentClass==""||g.studentsCourse==""||g.Time==""||g.Teacher=="")
            {
                MessageBox.Show("信息不完整");
            }
            else if (txtRegularGrade1.Text == "" || txtFinalGrade1.Text == "")
            {
                MessageBox.Show("成绩不能为空");
               
            }
            else if(repetition(g.studentID))
            {
                g.RegularGrade = Convert.ToDouble(txtRegularGrade1.Text);
                g.FinalGrade = Convert.ToDouble(txtFinalGrade1.Text);
                if ((0 <= g.RegularGrade && g.RegularGrade <= 100) && (0 <= g.FinalGrade && g.FinalGrade <= 100))
                {
                    g.SumGrade = g.RegularGrade*0.3 + g.FinalGrade*0.7;
                    string sqlStr4 = "insert into Student(StudentID,StudentName,StudentClass,StudentsCourse,RegularGrade,FinalGrade,SumGrade,Time,Teacher)" +
                       "values(@gID,@Name,@StudentClass,@StudentsCourse,@regularGrade,@finalGrade,@sumGrade,@time,@teacher)";
                    SqlParameter[] param4 =
                    {
                    new SqlParameter("@gID",g.studentID),
                    new SqlParameter("@Name",g.studentName),
                    new SqlParameter("@StudentClass",g.studentClass),
                    new SqlParameter("@StudentsCourse",g.studentsCourse),
                    new SqlParameter("@regularGrade",g.RegularGrade),
                    new SqlParameter("@finalGrade",g.FinalGrade),
                    new SqlParameter("@sumGrade",g.SumGrade),
                    new SqlParameter("@time",g.Time),
                    new SqlParameter("@teacher",g.Teacher),
                    };
                    Helper help4 = new Helper();
                    if (help4.Excute(sqlStr4, param4) > 0)
                    {
                        MessageBox.Show(" 添加成功");
                        txtStudents1ID.Text = "";
                        txtStudents1Name.Text = "";
                        comboBox1.Text = "";
                        txtRegularGrade1.Text = "";
                        txtFinalGrade1.Text = "";
                        txtTeacher1.Text = "";
                        DataBind();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtStudents1ID.Text = "";
            txtStudents1Name.Text = "";
            comboBox1.Text = "";
            txtRegularGrade1.Text = "";
            txtFinalGrade1.Text = "";
            txtTeacher1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) e.KeyChar = (char)0;   //处理负数
            if (e.KeyChar == '.') return;
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
