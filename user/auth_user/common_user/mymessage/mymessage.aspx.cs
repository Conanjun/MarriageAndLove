using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_mymessage_mymessage : System.Web.UI.Page
{
	msg mymsg = new msg();
	string[] msglist;
	int msgcount = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
		//获取该用户的已读和未读消息列表并根据日期时间排列，返回到前台页面供使用
		//前台ajax返回json数据轮询动态刷新消息列表
		if (Session["username"] == null)
		{
			WebMessageBox.Show("session失效，请重新登录", "../../../../login/login.aspx");
		}
		else
		{
			mymsg.RecvUsername = Session["username"].ToString();
			Label6.Text=mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows.Count.ToString();
			Label2.Text = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows.Count.ToString();
			Label4.Text = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows.Count.ToString();
		}
    }

	//返回供页面使用
	public string[] MsgList
	{
		get { return msglist; }
	}

	public int MsgCount
	{
		get
		{ return msgcount;}
	}



}