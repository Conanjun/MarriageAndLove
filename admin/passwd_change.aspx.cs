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
			Server.Transfer("login.aspx");
		}
    }
	protected void Button1_Click(object sender, EventArgs e)
	{
		//使用MD5加密将用户输入的密码加密
		string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(old_password.Text, "MD5");
        sql_admin myadmin = new sql_admin();
        myadmin.AdminName = username.Text;
        myadmin.AdminPassword = pass;

        
        
        //创建数据库连接
			/*SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
			//打开数据库连接
			con.Open();
			
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
			if (Convert.ToInt32(com.ExecuteScalar()) > 0)*/
			if (myadmin.AdminLoginByAccount(myadmin).Tables[0].Rows.Count > 0)
			{
				string newpass = FormsAuthentication.HashPasswordForStoringInConfigFile(new_password.Text, "MD5");
                //myadmin.AdminNewPassword = newpass;
                
                /*string sqlChangePasswd = "update admin set adminPasswd=@pass where adminName=@name";
				SqlCommand comChangePasswd = new SqlCommand(sqlChangePasswd,con);
				comChangePasswd.Parameters.Add(new SqlParameter("pass", SqlDbType.VarChar, 32));
				comChangePasswd.Parameters["pass"].Value = newpass;
				comChangePasswd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar, 32));
				comChangePasswd.Parameters["name"].Value = username.Text;
                 */
				//if (comChangePasswd.ExecuteNonQuery() != null)
                if (myadmin.AdminPasswdChange(myadmin, newpass) == 0)
				{
                    WebMessageBox.Show("修改成功","check_userinfo.aspx");
				}
				else
				{
                    WebMessageBox.Show("修改失败", "passwd_change.aspx");
				}
			}
			else
			{

                WebMessageBox.Show("旧密码错误", "passwd_change.aspx");
            }
		}
}