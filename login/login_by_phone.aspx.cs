﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;
public partial class login_login_by_phone : System.Web.UI.Page
{
    //建立数据库操作对象
    private readonly sql_user myuser = new sql_user();
    
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			Server.Transfer("../index.aspx");
		}
    }
	protected void Button1_Click(object sender, EventArgs e)
	{
		//string validatecode = validate_code.Text;
		//Request.Cookies["CheckCode"]为空时会导致异常故需先检测
		//验证码模块有点bug,先留着
		//if (Request.Cookies["CheckCode"]!=null && Request.Cookies["CheckCode"].Value == validatecode)
		if (true)
		{
			//创建数据库连接
			/*SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
			//打开数据库连接
			con.Open();
			//使用MD5加密将用户输入的密码加密
			string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
			//创建SQL语句，该语句用来查询用户输入的用户名和密码是否正确
			string sqlSel = "select count(*) from users where phone=@phone and password=@pass";
			//创建SqlCommand对象
			SqlCommand com = new SqlCommand(sqlSel, con);
			//使用Parameters的add方法添加参数类型
			com.Parameters.Add(new SqlParameter("phone", SqlDbType.VarChar, 20));
			//设置Parameters的参数值
			com.Parameters["phone"].Value = phone.Text;
			com.Parameters.Add(new SqlParameter("pass", SqlDbType.VarChar, 32));
			com.Parameters["pass"].Value = pass;
			//判断ExecuteScalar方法返回的参数是否大于0大于表示登录成功并给出提示
             */


            //使用MD5加密将用户输入的密码加密
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
            myuser.Phone = phone.Text;
            myuser.PassWord = pass;

            if (myuser.LoginByPhone(myuser).Tables[0].Rows.Count > 0)
			{
				/*string sqlGetUsername = "select username from users where phone=@phone";
				SqlCommand comGetUsername = new SqlCommand(sqlGetUsername, con);
				comGetUsername.Parameters.Add(new SqlParameter("phone", SqlDbType.VarChar, 20));
				comGetUsername.Parameters["phone"].Value = phone.Text;
				string SessionUsername = Convert.ToString(comGetUsername.ExecuteScalar());
				Session["username"] = SessionUsername;
                 */
               
                Session["username"] = myuser.LoginByPhone_FindUserName(myuser).Tables[0].Rows[0]["username"].ToString();

                //用于追踪在线用户
                if (!isInOnlineUserReal(Session["username"].ToString()))
                {
                    Application.Lock();
                    Application["users_online_count_real"] = (int)Application["users_online_count_real"] + 1;
                    Application["users_online_real"] = Application["users_online_real"] + "," + Session["username"].ToString();
                    Application.UnLock();
                }
                
                WebMessageBox.ShowNew("登录成功", "../index.aspx");

				//RegisterStartupScript("", "<script>alert('登录成功！')</script>");
				//清空文本框
				// txtCode.Text = txtUserName.Text = "";
				//服务器端重定向
				//Server.Transfer("../index.aspx");
			}
			else
			{
				RegisterStartupScript("", "<script>alert('用户名或密码错误！')</script>");
			}
		}
		else
		{
			RegisterStartupScript("", "<script>alert('验证码输入错误！')</script>");
		}
	}
	protected void register_button_Click(object sender, EventArgs e)
	{
		
	}
	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{

	}
	protected void password_TextChanged(object sender, EventArgs e)
	{

	}
	protected void validate_code_TextChanged(object sender, EventArgs e)
	{

	}
    //判断实在在在线用户里
    bool isInOnlineUserReal(string username)
    {
        string[] useronline = Application["users_online_real"].ToString().Split(',');
        for (int i = 0; i < (int)Application["users_online_count_real"]; i++)
        {
            if (useronline[i] == username)
            {
                return true;
            }
        }
        return false;
    }
}