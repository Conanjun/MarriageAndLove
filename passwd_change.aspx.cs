using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;

public partial class admin_passwd_change : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] == null)
		{
			Server.Transfer("index.aspx");
		}
    }
	protected void Button1_Click(object sender, EventArgs e)
	{
			//创建数据库连接
			SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
			//打开数据库连接
			con.Open();
			//使用MD5加密将用户输入的密码加密
			string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(old_password.Text, "MD5");
			//创建SQL语句，该语句用来查询用户输入的用户名和密码是否正确
			string sqlSel = "select count(*) from users where username=@name and password=@pass";
			//创建SqlCommand对象
			SqlCommand com = new SqlCommand(sqlSel, con);
			//使用Parameters的add方法添加参数类型
			com.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar, 20));
			//设置Parameters的参数值
			com.Parameters["name"].Value = username.Text;
			com.Parameters.Add(new SqlParameter("pass", SqlDbType.VarChar, 32));
			com.Parameters["pass"].Value = pass;
			
			if (Convert.ToInt32(com.ExecuteScalar()) > 0)
			{
				string newpass = FormsAuthentication.HashPasswordForStoringInConfigFile(new_password.Text, "MD5");
				string sqlChangePasswd = "update users set password=@pass where username=@name";
				SqlCommand comChangePasswd = new SqlCommand(sqlChangePasswd,con);
				comChangePasswd.Parameters.Add(new SqlParameter("pass", SqlDbType.VarChar, 32));
				comChangePasswd.Parameters["pass"].Value = newpass;
				comChangePasswd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar, 32));
				comChangePasswd.Parameters["name"].Value = username.Text;
				if (comChangePasswd.ExecuteNonQuery() != null)
				{
					Response.Redirect("index.aspx");
					RegisterStartupScript("", "<script>alert('修改成功')</script>");
				}
				else
				{
					RegisterStartupScript("", "<script>alert('修改失败')</script>");
					Response.Redirect("passwd_change.aspx");
				}
			}
			else
			{
				RegisterStartupScript("", "<script>alert('旧密码错误')</script>");
				Response.Redirect("passwd_change.aspx");
			}
		}
}