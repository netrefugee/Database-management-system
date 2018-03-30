using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int loginCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            loginValidate();
            
            
            /*
            this.Visible = false;
            Frm_Main fm = new Frm_Main();
            fm.Show();
            */
        }

        public void loginValidate()
        {
            Boolean bResult = false;

            if (txtUserName.Text.Trim() == "" || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("用户名不能为空！","登录提示");
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == "" || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("密码不能为空！", "登录提示");
                txtPassword.Focus();
            }
            else
            {

                SqlConnection con = new SqlConnection(DBHelper.conStr);
                try
                {
                    con.Open();
                    if ("admin".Equals(txtUserName.Text.Trim()))
                    {
                        //高级管理员验证
                    }
                    else
                    {
                        //非高级管理员
                        string sql = string.Format("select * from t_zg where " + "bh ='{0}' and kl ='{1}'", txtUserName.Text, txtPassword.Text);
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            LoginInfo.Bh = Convert.ToString(dr["bh"]);
                            LoginInfo.Xm = Convert.ToString(dr["xm"]);
                            LoginInfo.Qx = Convert.ToString(dr["qx"]);
                            bResult = true;
                        }
                        else
                        {
                            loginCount++;
                            tips.ForeColor = Color.Red;
                            tips.Text = "第" + loginCount + "次输入密码错误";
                        }
                        dr.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally {con.Close(); }
                if (bResult)
                {
                    this.Visible = false;
                    Frm_Main fm = new Frm_Main();
                    fm.Show();
                }
                if (loginCount == 3) {
                    MessageBox.Show("登陆错误次数超出限制，程序退出！", "登录提示");
                Application.Exit();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                    loginValidate();
                else
                    SendKeys.Send("{TAB}");
            }
        }

       
    }
}
