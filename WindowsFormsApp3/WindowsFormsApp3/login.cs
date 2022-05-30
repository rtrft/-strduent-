using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace WindowsFormsApp3
{
    public partial class login : Form
    {
        public string changetext()
        {
            return this.textBox1.Text;
        }

        public login()
        {
            InitializeComponent();
            

        }

      

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public bool checkuser(string name, string passwd)//登录
        {
            bool result = false;
            string sql1 = string.Format("select*from user1 where name='{0}'and passwd='{1}'", name, passwd);
            string sql2 = string.Format("select*from user2 where name='{0}'and passwd='{1}'", name, passwd);
            string sql=sql1;
            if (comboBox1.Text.Equals("学生"))
                     sql = sql1;  
            
            else if (comboBox1.Text.Equals("教师"))
                    sql = sql2;
            else
                MessageBox.Show("你还未选择身份，请选择后登陆！");
            Helper help = new Helper();
            DataSet ds = help.GetData(sql);
            if (ds.Tables[0].Rows.Count>0)
            { result = true; }
            else
            { result = false; }
            return result;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            if (checkuser(textBox1.Text, textBox2.Text) == true&& comboBox1.Text.Equals("学生"))
            {
                MessageBox.Show("登录成功！");
                StudentClass mainFrom = new StudentClass();
                mainFrom.ShowDialog();
               
                l.WindowState = FormWindowState.Minimized;

            }
            else if(checkuser(textBox1.Text, textBox2.Text) == true && comboBox1.Text.Equals("教师"))
            {
                MessageBox.Show("登录成功！");
                var frm2 = new MainForm(this);
                frm2.ShowDialog();
                l.WindowState = FormWindowState.Minimized;
            }
            else
                MessageBox.Show("用户名或密码错误，登录失败！");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            register f=new register();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) e.KeyChar = (char)0;   //处理负数
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