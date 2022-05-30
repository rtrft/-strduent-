using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp3
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        public bool checkuser1(string name, string passwd, string PhoneNumbe)//注册
        {
            bool result = false;
            string str1 = string.Format("select*from user1 where name='{0}'", name);//查询是否用户名重复
            string str2 = string.Format("select*from user2 where name='{0}'", name);
            string sql1 = string.Format("insert into user1(name,passwd,PhoneNumbe) values('{0}','{1}','{2}')", name, passwd, PhoneNumbe);//插入新数据，注册。
            string sql2 = string.Format("insert into user2(name,passwd,PhoneNumbe) values('{0}','{1}','{2}')", name, passwd, PhoneNumbe);
            int rows = 0;
            Helper help = new Helper();
            Helper help1 = new Helper();
            if (comboBox1.Text.Equals("学生"))
            {

                DataSet ds1 = help1.GetData(str1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("注册失败，用户名重复！");
                }
                else
                {
                    rows = help.Excute(sql1);
                }

            }
            else if (comboBox1.Text.Equals("教师"))
            {
                DataSet ds1 = help1.GetData(str2);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("注册失败，用户名重复！");
                }
                else
                {
                    rows = help.Excute(sql2);
                }
            }
            else
            {
                MessageBox.Show("你还未选择身份，请选择后注册！");
            }

            if (rows > 0)
            { MessageBox.Show("注册成功！"); }
            else
            { MessageBox.Show("注册失败！"); }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //电信手机号码正则        
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);
            //联通手机号正则        
            string liantong = @"^1[34578][01256]\d{8}$";
            Regex tReg = new Regex(liantong);
            //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("用户名或者密码为空！请重新输入！", "注册提示");
                return;
            }
            else if (dReg.IsMatch(textBox3.Text) || tReg.IsMatch(textBox3.Text) || yReg.IsMatch(textBox3.Text))
            {
                checkuser1(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            else
            {
                MessageBox.Show("手机号格式不正确;");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
        }
    }
}
