﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_myissue_myissue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			//Label2.Text = Session["username"].ToString();
			//DateTime dt = DateTime.Now;
			//Label1.Text = dt.Year.ToString() + "年" + dt.Month.ToString() + "月" + dt.Day.ToString() + "日";
		}
		else
		{
			WebMessageBox.Show("session失效，请重新登录","../../../../index.aspx");
		}
		
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