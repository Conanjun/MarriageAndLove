﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class register_register_by_phone : System.Web.UI.Page
{
    //数据库操作对象
    sql_user myuser = new sql_user();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户状态
        if (Session["username"] != null)
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
    protected void password_checked_TextChanged(object sender, EventArgs e)
    {

    }
    protected void validate_code_TextChanged(object sender, EventArgs e)
    {

    }
    protected void register_button_Click(object sender, EventArgs e)
    {
        if (IsExistUser(username.Text))
        {
            RegisterStartupScript("", "<script>alert('用户名已存在，请使用其他用户名注册')</script>");
            Response.Redirect("register_by_phone.aspx");
        }
        else
        {
            if (IsPasswdSame(password.Text, password_check.Text))
            {
                string db_phone = phone.Text;
                string db_username = username.Text;
                string db_password = password.Text;


                //创建数据库连接
                //SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=19940919;");
                //打开数据库连接
                //con.Open();

                sql_user myuser = new sql_user();
                
                //使用MD5加密将用户输入的密码加密
                string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(db_password, "MD5");
                
                myuser.Phone = db_phone;
                myuser.UserName = db_username;
                myuser.PassWord = pass;

                
                //创建SQL语句，该语句用来查询用户输入的用户名和密码是否正确
                //此处phone不允许插入空值，由于手机注册的原因，故暂时用0替代
                //string sqlSel = "insert into users(username,password,email,phone) values(@username,@password,@email,0)";
                //创建SqlCommand对象
                //SqlCommand com = new SqlCommand(sqlSel, con);
                //使用Parameters的add方法添加参数类型
                /*com.Parameters.Add(new SqlParameter("email", SqlDbType.VarChar, 32));
                //设置Parameters的参数值
                com.Parameters["email"].Value = db_email;
                com.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar, 32));
                com.Parameters["password"].Value = pass;
                com.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 32));
                com.Parameters["username"].Value = db_username;
                 */
                if (myuser.RegisterByPhone(myuser) == 0)
                {
                    Session["username"] = db_username;
                    RegisterStartupScript("", "<script>alert('注册成功,激活邮件已发送至信箱')</script>");
                    //加入user表status属性后判断状态需判断status,激活邮件部分以后再写
                    Response.Redirect("../index.aspx");
                }
                else
                {
                    RegisterStartupScript("", "<script>alert('注册失败，请重新注册')</script>");
                    Response.Redirect("register_by_email.aspx");
                }

            }
            else
            {
                RegisterStartupScript("", "<script>alert('两次密码输入不一致，请重新输入')	</script>");
                Response.Redirect("register_by_email.aspx");
            }


            //string db_password = pasword.Text;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("../login/login.aspx");
    }
    protected bool IsExistUser(string username)
    {
        bool IsExist = false;
        sql_user myuser = new sql_user();
        myuser.UserName = username;

        /*
		string sqlCheckUsername = "select * from users where username=@username";
		SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=19940919;");
		con.Open();
		SqlCommand comCheckUsername = new SqlCommand(sqlCheckUsername, con);
		comCheckUsername.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 50));
		comCheckUsername.Parameters["username"].Value = username;
         */
        //if (Convert.ToInt32(comCheckUsername.ExecuteScalar()) > 0)
        if (myuser.IsUserExist(myuser).Tables[0].Rows.Count > 0)
        {
            IsExist = true;
        }
        //con.Close();
        return IsExist;
    }
    protected bool IsPasswdSame(string passwd, string passwd_check)
    {
        return passwd == passwd_check;
    }
    protected void phone_TextChanged(object sender, EventArgs e)
    {

    }
    protected void password_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void password_check_TextChanged(object sender, EventArgs e)
    {

    }



}