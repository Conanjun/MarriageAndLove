using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_MasterPage : System.Web.UI.MasterPage
{
	//string strPath = "";
    protected void Page_Load(object sender, EventArgs e)
    {
		//strPath = ROOTPATH;
		visitors.Text = "本站当前有:" + Application["users_online_count_real"].ToString() + "位会员在线";
    }
	public string ROOTPATH
	{
		get
		{
			string strPath = Request.ApplicationPath;
			if (strPath == "/")
			{
				return String.Empty;
			}
			else
			{
				return strPath;
			}
		}
	}
}
