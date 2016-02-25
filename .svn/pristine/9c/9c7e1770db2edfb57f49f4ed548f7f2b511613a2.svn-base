using System;
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;


public partial class login_forget_password_FindByEmail : System.Web.UI.Page
{
    //数据库操作对象
    sql_user myuser = new sql_user();
       
    protected string rnumber()
    {
        int shu;
        Random r = new Random();
        shu = r.Next(10000, 30000);

        return Convert.ToString(shu);
    }

    protected void email_TextChanged(object sender, EventArgs e)
    {

    }

    protected void validate_code_TextChanged(object sender, EventArgs e)
    {

    }

    public void sendmail(string email, string resetCode)
    {
        MailMessage mailMsg = new MailMessage();
        mailMsg.From = new MailAddress("310394767@qq.com");
        mailMsg.To.Add(email);
        mailMsg.Subject = "通过邮箱找回密码";
        StringBuilder contentBuilder = new StringBuilder();
        contentBuilder.Append("请单击以下链接完成重置密码");
        contentBuilder.Append("<a href='http://localhost:7885/login/forget_password_FindByEmail_ResetPassword.aspx?resetcode=" + resetCode + "&email=" + email + "'>重置</a>");
        mailMsg.Body = contentBuilder.ToString();
        mailMsg.IsBodyHtml = true;
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.qq.com";
        client.Port = 25;
        NetworkCredential credetial = new NetworkCredential();
        credetial.UserName = "310394767";
        credetial.Password = "woSHI0704K";
        client.Credentials = credetial;
        client.Send(mailMsg);
    }
     
    protected void Page_Load(object sender, EventArgs e)
        {

        }

    protected void findpassword_button_Click(object sender, EventArgs e)
    {
        if (IsNotExistEmail(email.Text))
        {
            WebMessageBox.Show("该邮箱不存在，请确认填写的邮箱", "forget_password_FindByEmail.aspx");
            //RegisterStartupScript("", "<script>alert('该邮箱不存在，请确认填写的邮箱')</script>");
            //Response.Redirect("forget_password_FindByEmail.aspx");
        }
        else
        {
            string db_email = email.Text;
                //创建数据库连接
                /*SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
                //打开数据库连接
                con.Open();
                //使用MD5加密将用户输入的密码加密
                string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
                //创建SQL语句，该语句用来查询用户输入的用户名和密码是否正确
                //此处phone不允许插入空值，由于手机注册的原因，故暂时用0替代
                string sqlSel = "insert into users(username,password,email,phone) values(@username,@password,@email,0)";
                //创建SqlCommand对象
                SqlCommand com = new SqlCommand(sqlSel, con);
                //使用Parameters的add方法添加参数类型
                com.Parameters.Add(new SqlParameter("email", SqlDbType.VarChar, 32));
                //设置Parameters的参数值
                com.Parameters["email"].Value = db_email;
                com.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar, 32));
                com.Parameters["password"].Value = pass;
                com.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 32));
                com.Parameters["username"].Value = db_username;
                 * */
            //string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");
            sql_user myuser = new sql_user();
            myuser.Email = db_email;
            
            Session["email"] = db_email;
            string temp = "0";
            temp = rnumber();
            myuser.ResetCode = temp;
            /*string sqladd = "insert into resetcode(email,resetcode) values(@email,@resetcode)";
            SqlConnection con = new SqlConnection("Server=localhost;DataBase=MarriageAndLove;User=sa;Password=conan");
            con.Open();
            SqlCommand comm = new SqlCommand(sqladd, con);
            
            comm.Parameters.Add(new SqlParameter("email", SqlDbType.VarChar, 32));
            comm.Parameters["email"].Value = db_email;
            comm.Parameters.Add(new SqlParameter("resetcode", SqlDbType.VarChar, 32));
            comm.Parameters["resetcode"].Value = temp;
            comm.ExecuteNonQuery();
             */
            if (myuser.InsertUserResetCode(myuser) == 0)
            {
                sendmail(db_email, temp);
                WebMessageBox.Show("重置密码的邮件已发送至信箱", "forget_password_FindByEmail.aspx");
                //RegisterStartupScript("", "<script>alert('注册成功,激活邮件已发送至信箱')</script>");
                //加入user表status属性后判断状态需判断status,激活邮件部分以后再写
                //Response.Redirect("../index.aspx");

                //string db_password = pasword.Text;
            }
        }
    }

    protected bool IsNotExistEmail(string email)
    {
        bool IsNotExist = true;
        sql_user myuser = new sql_user();
        myuser.Email = email;

        if (myuser.IsEmailExist(myuser).Tables[0].Rows.Count > 0)
        {
            IsNotExist = false ;
        }
        //con.Close();
        return IsNotExist;
    }
}