using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		Server.Transfer("register_by_phone.aspx");
	}
	protected void LinkButton2_Click(object sender, EventArgs e)
	{
		Server.Transfer("register_by_email.aspx");
	}
}