using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace WindowsFormsApp3
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DataBind2();
        }
        public bool repetition(string name)
        {
            string str1 = string.Format("select*from user1 where name='{0}'", name);
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

        public void DataBind2()//查找
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            u.passwd = txtuserPasswd.Text;
            string sqlStr = "select * from user1 where 1=1";
            sqlStr += u.name == "" ? "" : "and name='" + u.name + " ' ";
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("查询失败");
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.user1View.DataSource = ds.Tables[0];
            }
            else
            {
                this.user1View.DataSource = null;
            }
        }

        public bool format()
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

            if (txtuserName.Text == string.Empty || txtuserPasswd.Text == string.Empty)
            {
                MessageBox.Show("用户名或者密码为空！请重新输入！");
                return false;
            }
            else if (dReg.IsMatch(txtPhoneNumbe.Text) || tReg.IsMatch(txtPhoneNumbe.Text) || yReg.IsMatch(txtPhoneNumbe.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("手机号格式不正确;");
                return false;
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(format())
            {
                User1 u = new User1();
                u.name = txtuserName.Text;
                u.passwd = txtuserPasswd.Text;
                u.PhoneNumbe = txtPhoneNumbe.Text;
                if (repetition(u.name))
                {
                    string sqlStr = "insert into user1(name,passwd,PhoneNumbe)" + "values(@userName,@userPasswd,@userPhoneNumbe)";
                    SqlParameter[] param =
                    {
                        new SqlParameter("@userName",u.name),
                        new SqlParameter("@userPasswd",u.passwd),
                        new SqlParameter("@userPhoneNumbe",u.PhoneNumbe),
                    };
                    Helper help = new Helper();
                    if (help.Excute(sqlStr, param) > 0)
                    {
                        MessageBox.Show("添加成功");
                        txtuserName.Text = "";
                        txtuserPasswd.Text = "";
                        txtPhoneNumbe.Text = "";
                        DataBind2();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
                else
                {
                    MessageBox.Show("添加失败 ，用户名不可以重复！");
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtuserName.Text="";
            txtuserPasswd.Text="";
            txtPhoneNumbe.Text="";
        }

        private void user1View_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtuserName.Text = user1View.Rows[rowIndex].Cells[0].Value.ToString();
                txtuserPasswd.Text = user1View.Rows[rowIndex].Cells[1].Value.ToString();
                txtPhoneNumbe.Text = user1View.Rows[rowIndex].Cells[2].Value.ToString();
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
