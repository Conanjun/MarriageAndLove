using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_logout : System.Web.UI.Page
{
	//执行清除session并重定向到首页
    protected void Page_Load(object sender, EventArgs e)
    {
		Application.Lock();
		string users_online = Application["users_online_count_real"].ToString();
		Application["users_online_real"] = users_online.Replace(Session["username"].ToString(), "");
		Application["users_online_count_real"] = (int)Application["users_online_count_real"] - 1;
		Application.UnLock(); 
		Session["username"] = null;
		Response.Redirect("../index.aspx");
    }
}