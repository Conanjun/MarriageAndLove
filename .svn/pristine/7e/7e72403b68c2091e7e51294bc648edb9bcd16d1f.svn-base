using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AdminMasterPage : System.Web.UI.MasterPage
{
	string strPath = "";
	protected void Page_Load(object sender, EventArgs e)
	{
		strPath = ROOTPATH;
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
