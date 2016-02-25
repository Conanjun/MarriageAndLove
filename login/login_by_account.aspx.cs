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



public partial class login_login_by_account : System.Web.UI.Page
{
	
	//建立数据库操作对象
	private readonly sql_user myuser = new sql_user();
	
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)//已登录用户再次点击跳转到index.aspx页面
		{
			Server.Transfer("../index.aspx");
		}

    }

	
	protected void username_TextChanged(object sender, EventArgs e)
	{

	}
	protected void password_TextChanged(object sender, EventArgs e)
	{

	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		//string validatecode = validate_code.Text;
		//Request.Cookies["CheckCode"]为空时会导致异常故需先检测
		//验证码模块有点bug,先留着
		//if (Request.Cookies["CheckCode"]!=null && Request.Cookies["CheckCode"].Value == validatecode)
		if(true)
		{
			
			//使用数据库操作对象简化代码
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
			myuser.UserName = username.Text;
			myuser.PassWord = pass;
			if (myuser.LoginByAccount(myuser).Tables[0].Rows.Count > 0)
            {
				//设置session
				Session["username"] = username.Text;
               // RegisterStartupScript("", "<script>alert('登录成功！')</script>");
				//登陆成功后跳转的未激活页面，有该页面判断用户是否激活

				//用于追踪在线用户
				if (!isInOnlineUserReal(Session["username"].ToString()))
				{
					Application.Lock();
					Application["users_online_count_real"] = (int)Application["users_online_count_real"] + 1;
					Application["users_online_real"] = Application["users_online_real"] + "," + Session["username"].ToString();
					Application.UnLock();
				}
				WebMessageBox.ShowNew("登录成功","../user/noauth_user/prompt_activation.aspx");
               //清空文本框
               // txtCode.Text = txtUserName.Text = "";
			   //服务器端重定向
				Server.Transfer("../index.aspx");
            }
            else
            {
               // RegisterStartupScript("", "<script>alert('用户名或密码错误！')</script>");
				WebMessageBox.Show("用户名或密码错误");
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
	protected void validate_code_TextChanged(object sender, EventArgs e)
	{

	}
}