using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class user_auth_user_common_user_chat_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		ArrayList ItemList = new ArrayList();
		Application.Lock();
		string peopleNames;
		string[] peopleUsers;
		int peopleCount = Int32.Parse(Application["userNum"].ToString());
		peopleNames = Application["user"].ToString();
		peopleUsers = peopleNames.Split(',');
		for (int i = peopleCount - 1; i >= 0; i--)
		{
			if (peopleUsers[i].ToString() != "")
			{
				ItemList.Add(peopleUsers[i].ToString());
			}
		}
		lbList.DataSource = ItemList;
		lbList.DataBind();
		Application.UnLock();
    }
}