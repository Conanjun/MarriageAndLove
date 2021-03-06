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


public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)//已登录用户再次点击跳转到index.aspx页面
		{
			Response.Redirect("admin_manage.aspx");
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
		string validatecode = validate_code.Text;
		//Request.Cookies["CheckCode"]为空时会导致异常故需先检测
		//验证码模块有点bug,先留着
		//if (Request.Cookies["CheckCode"]!=null && Request.Cookies["CheckCode"].Value == validatecode)
		if(true)
		{
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
            sql_admin myadmin = new sql_admin();
            myadmin.AdminName=username.Text;
            myadmin.AdminPassword = pass;
            
            //创建数据库连接
            /*SqlContion con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
            //打开数据库连接
            con.Open();
            //使用MD5加密将用户输入的密码加密
            
            //创建SQL语句，该语句用来查询用户输入的用户名和密码是否正确
            string sqlSel = "select count(*) from admin where adminName=@name and adminPasswd=@pass";
            //创建SqlCommand对象
            SqlCommand com = new SqlCommand(sqlSel, con);
            //使用Parameters的add方法添加参数类型
            com.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar, 20));
            //设置Parameters的参数值
            com.Parameters["name"].Value = username.Text;
            com.Parameters.Add(new SqlParameter("pass", SqlDbType.VarChar, 32));
            com.Parameters["pass"].Value = pass;
             */
            //判断ExecuteScalar方法返回的参数是否大于0大于表示登录成功并给出提示
            //if (Convert.ToInt32(com.ExecuteScalar()) > 0)
            if (myadmin.AdminLoginByAccount(myadmin).Tables[0].Rows.Count > 0)
            {
				//设置session
				Session["username"] = username.Text;
                WebMessageBox.Show("登录成功", "admin_manage.aspx");
               // RegisterStartupScript("", "<script>alert('登录成功！')</script>");
               //清空文本框
               // txtCode.Text = txtUserName.Text = "";
			   //服务器端重定向
				//  Server.Transfer();
            }
            else
            {
				WebMessageBox.Show("用户名或密码错误","login.aspx");
            }
        }
        else
        {
            WebMessageBox.Show("验证码输入错误","login.aspx");
        }
	}
	protected void register_button_Click(object sender, EventArgs e)
	{

	}
	protected void validate_code_TextChanged(object sender, EventArgs e)
	{

	}
}