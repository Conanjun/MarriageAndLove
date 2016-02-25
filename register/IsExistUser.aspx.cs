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


public partial class register_IsExistUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		//用于ajax实时检测用户名是否存在
		if (Request.QueryString["check_username"] != null)
		{
			string username_to_check = Request.QueryString["check_username"].ToString();
            sql_user myuser = new sql_user();
            myuser.UserName = username_to_check;

            if (myuser.IsUserExist(myuser).Tables[0].Rows.Count > 0)
			{
				Response.Write("此用户已存在");
			}
			else
			{
				Response.Write("此用户名可使用");
			}

		}
    }
	/*protected bool IsExistUser(string username)
	{
		bool IsExist = false;
		string sqlCheckUsername = "select * from users where username=@username";
		SqlConnection con = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
		con.Open();
		SqlCommand comCheckUsername = new SqlCommand(sqlCheckUsername, con);
		comCheckUsername.Parameters.Add(new SqlParameter("username", SqlDbType.VarChar, 50));
		comCheckUsername.Parameters["username"].Value = username;
		if (Convert.ToInt32(comCheckUsername.ExecuteScalar()) > 0)
		{
			IsExist = true;
		}
		con.Close();
		return IsExist;
	}
     */
}