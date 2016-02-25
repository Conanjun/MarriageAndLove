using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_myfriend_friend_del : System.Web.UI.Page
{
	Friend delfriend = new Friend();
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			string del_friend_name = Request.QueryString["friendname_del"];

			Console.WriteLine(del_friend_name);

			delfriend.UserName = Session["username"].ToString();

			if (delfriend.FriendDelete(del_friend_name) == 0)
			{
				WebMessageBox.Show("删除成功", "myfriend.aspx");
			}
			else
			{
				WebMessageBox.Show("删除失败", "myfriend.aspx");
			}
		}
		else
		{
			Response.Redirect("../../../../index.aspx");
		}
    }
}