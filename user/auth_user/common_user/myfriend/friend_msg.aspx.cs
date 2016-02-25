using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_myfriend_friend_msg : System.Web.UI.Page
{
	Friend myfriend = new Friend();
	msg mymsg = new msg();
    protected void Page_Load(object sender, EventArgs e)
    {
		//检查登陆状态
		if (Session["username"] == null)
		{
			WebMessageBox.Show("session失效，请重新登录","../../../../login/login.aspx");
		}
		else
		{
			myfriend.UserName = Session["username"].ToString();
			myfriend.FriendName = Request.QueryString["friendname_msg"];
			//检查是否是好友关系
			if (myfriend.SelectFriend(myfriend).Tables[0].Rows.Count <= 0)
			{
				WebMessageBox.Show("非好友不能发送消息，请添加后再发送消息", "myfriend.aspx");
			}
			Label2.Text = myfriend.FriendName;
		}	
    }

	//获取发送的消息，发送人和接收人分别用参数获取
	//发送消息后通过ajax轮询的方式接收人获取消息提示

	protected void Button1_Click(object sender, EventArgs e)
	{
		mymsg.SendUsername = myfriend.UserName;
		mymsg.RecvUsername = myfriend.FriendName;
		mymsg.Message=TextBox1.Text;
		mymsg.DateTime = DateTime.Now;
		mymsg.Readed = 0;
		if (mymsg.MessageInsert(mymsg)==0)
		{
			WebMessageBox.Show("消息发送成功", "myfriend.aspx");
		}
		else
		{
			WebMessageBox.Show("消息发送失败，请重新发送");
		}
	}
}