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
		
		Session["username"] = null;
		Response.Redirect("login.aspx");
    }
}