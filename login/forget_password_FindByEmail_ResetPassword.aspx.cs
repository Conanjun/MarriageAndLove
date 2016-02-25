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

public partial class login_forget_password_FindByEmail_ResetPassword : System.Web.UI.Page
{
    //数据库操作对象
    sql_user myuser = new sql_user();
    
    protected void Page_Load(object sender, EventArgs e)
    {

        sql_user myuser = new sql_user(); 
        myuser.Email = Request.QueryString["email"];
        myuser.ResetCode = Request.QueryString["resetcode"];

        if (myuser.EmailResetCodeSelect(myuser).Tables[0].Rows.Count <= 0)
        {
            WebMessageBox.Show("非法验证码！请从邮箱所发链接进入", "../index.aspx");
        }
    }

    protected void password_TextChanged(object sender, EventArgs e)
    {

    }

    protected void password_check_TextChanged(object sender, EventArgs e)
    {

    }

    protected void validate_code_TextChanged(object sender, EventArgs e)
    {

    }

    protected void reset_button_Click(object sender, EventArgs e)
    {
        if (IsPasswdSame(password.Text, password_check.Text))
        {
            sql_user myuser = new sql_user();
            myuser.Email = Request.QueryString["email"];
            myuser.ResetCode = Request.QueryString["resetcode"];
            
            string db_password = password.Text;
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(db_password, "MD5");

            myuser.PassWord = pass;
         
            if (myuser.UpdateUserPassword(myuser) == 0)
            {
                myuser.EmailResetCodeDelete(myuser);//从resetcode表中删除记录
                WebMessageBox.Show("密码重置成功，请使用新密码登录", "../index.aspx");
            }
        }
        else
        {
            WebMessageBox.Show("两次密码输入不一致，请重新输入", "forget_password_FindByEmail_ResetPassword.aspx");
            //RegisterStartupScript("", "<script>alert('两次密码输入不一致，请重新输入')	</script>");
            //Response.Redirect("forget_password_FindByEmail_ResetPassword.aspx");
        }
    }

    protected bool IsPasswdSame(string passwd, string passwd_check)
    {
        return passwd == passwd_check;
    }

}