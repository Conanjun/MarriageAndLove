using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_myfriend_accept_friendask : System.Web.UI.Page
{
	Friend dealfriend = new Friend();
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			string action = Request.QueryString["action"];
			string deal_friendname = Request.QueryString["deal_friend"];
			dealfriend.UserName = Session["username"].ToString();

			if (action == "accept")
			{
				string current_user = Session["username"].ToString();
				if (dealfriend.AcceptFriendAsk(dealfriend, deal_friendname) == 0)
				{
					WebMessageBox.Show("允许添加成功","myfriend.aspx");
				}

			}
			else
			{
				if (action == "refuse")
				{
					string current_user = Session["username"].ToString();
					if (dealfriend.RefuseFriendAsk(dealfriend, deal_friendname) == 0)
					{
						WebMessageBox.Show("拒绝添加成功", "myfriend.aspx");
					}
				}
				else
				{
					WebMessageBox.Show("无此处理动作");
				}
		
			}
		}
		else
		{
			WebMessageBox.Show("session失效未登陆,请重新登录","../../../../index.aspx");
		}
    }
}