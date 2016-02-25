using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			Server.Transfer("../index.aspx");
		}
    }
	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{

	}
	
	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		Server.Transfer("login_by_account.aspx");
	}
	protected void LinkButton2_Click(object sender, EventArgs e)
	{
		Server.Transfer("login_by_email.aspx");
	}
	protected void LinkButton3_Click(object sender, EventArgs e)
	{
		Server.Transfer("login_by_phone.aspx");
	}
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Server.Transfer("forget_password.aspx");
    }
}