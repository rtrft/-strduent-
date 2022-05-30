using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace WindowsFormsApp3
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DataBind2();
        }

        public void DataBind2()//查找
        {
            User1 u = new User1();
            u.name = txtuserName.Text; ;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//调用查询方法
        {
            DataBind2();
        }

        public bool repetition(string name)
        {
            string str = string.Format("select * from user1 where name='{0}'and ID!='{1}'",name,txtID.Text);
            Helper help = new Helper();
            DataSet ds = help.GetData(str);
            if (ds== null)
            {
                MessageBox.Show("空");
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
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
                return false;
                MessageBox.Show("手机号格式不正确;");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)//修改
        {
            
            if(format())
            {
                User1 u = new User1();
                u.name = txtuserName.Text;
                u.passwd = txtuserPasswd.Text;
                u.PhoneNumbe = txtPhoneNumbe.Text;
                if (repetition(u.name))
                {
                    string sqlStr = "Update user1 Set name=@userName,passwd=@userPasswd,PhoneNumbe=@userPhoneNumbe where ID=@id";
                    SqlParameter[] param =
                    {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@userName",u.name),
                new SqlParameter("@userPasswd",u.passwd),
                new SqlParameter("@userPhoneNumbe",u.PhoneNumbe),
                };
                    Helper help = new Helper();
                    if (help.Excute(sqlStr, param) > 0)
                    {
                        MessageBox.Show("修改成功");
                        DataBind2();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("修改失败 ，用户名不可以重复！");
                }
            }
            else
            {
                MessageBox.Show("修改失败 ，手机格式不正确或用户名与密码为空！");
            }
           
            
        }

        

        private void button4_Click_1(object sender, EventArgs e)//删除
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            string sqlStr = "Delete from user1 where name='" + u.name + "'";
            Helper help = new Helper();
            if (help.Excute(sqlStr) > 0)
            {
                MessageBox.Show("删除成功");
                DataBind2();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtuserName.Text = "";
            txtuserPasswd.Text = "";
            txtPhoneNumbe.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void user1View_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = e.RowIndex;
            if(rowIndex>=0)
            {
               
               txtuserName.Text = user1View.Rows[rowIndex].Cells[0].Value.ToString().Trim();
               txtuserPasswd.Text = user1View.Rows[rowIndex].Cells[1].Value.ToString().Trim();
               txtPhoneNumbe.Text = user1View.Rows[rowIndex].Cells[2].Value.ToString().Trim();
               txtID.Text = user1View.Rows[rowIndex].Cells[3].Value.ToString().Trim();
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
