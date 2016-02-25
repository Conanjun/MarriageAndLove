using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_mymessage_showmessage : System.Web.UI.Page
{
	msg mymsg = new msg();
	string[] msglist;
	int msgcount = 0;
	string[] timelist;
	string[] sendpeoplelist;

    string[] set_read_status_url;
    string display_conten;// 设为已阅 设为未阅
    string[] del_msg_url;
    //string[] del_msg_content; //删除消息";

    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] == null)
		{
			WebMessageBox.Show("session失效，请重新登录", "../../../../login/login.aspx");
		}
        else
		{
			mymsg.RecvUsername = Session["username"].ToString();
			string kind = Request.QueryString["kind"];
			if (kind == "all")
			{
				msgcount = mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows.Count;
				msglist=new string[msgcount];
				timelist = new string[msgcount];
                set_read_status_url = new string[msgcount];
               // display_conten = new string[msgcount];
                del_msg_url = new string[msgcount];
               // del_msg_content = new string[msgcount];
				sendpeoplelist = new string[msgcount];
				for (int i = 0; i < msgcount; i++)
				{
					msglist[i] = mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows[i]["content"].ToString();
					timelist[i] = mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows[i]["sendtime"].ToString();
					sendpeoplelist[i] = mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows[i]["send_username"].ToString();
                    set_read_status_url[i] = "change_msg_status.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";                    
                    del_msg_url[i] = "delete_msg.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";
                }
			}
			else if (kind == "read")
			{
				msgcount = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows.Count;
				msglist = new string[msgcount];
				timelist = new string[msgcount];
				sendpeoplelist = new string[msgcount];
               set_read_status_url = new string[msgcount];
               // display_conten = new string[msgcount];
                del_msg_url = new string[msgcount];
               // del_msg_content = new string[msgcount];

				for (int i = 0; i < msgcount; i++)
				{
					msglist[i] = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows[i]["content"].ToString();
					timelist[i] = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows[i]["sendtime"].ToString();
					sendpeoplelist[i] = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows[i]["send_username"].ToString();
                    set_read_status_url[i] = "change_msg_status.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";
                    del_msg_url[i] = "delete_msg.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";
				}
			}
			else
			{
				msgcount = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows.Count;
				msglist = new string[msgcount];
				timelist = new string[msgcount];
				sendpeoplelist = new string[msgcount];
                set_read_status_url = new string[msgcount];
                //display_conten = new string[msgcount];
                del_msg_url = new string[msgcount];
              //  del_msg_content = new string[msgcount];
				for (int i = 0; i < msgcount; i++)
				{
					msglist[i] = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows[i]["content"].ToString();
					timelist[i] = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows[i]["sendtime"].ToString();
					sendpeoplelist[i] = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows[i]["send_username"].ToString();
                    set_read_status_url[i] = "change_msg_status.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";
                    display_conten="标记为已读";
                    del_msg_url[i] = "delete_msg.aspx?username=" + mymsg.RecvUsername + "&msg=" + msglist[i] + "&time=" + timelist[i] + "&sendpeople=" + sendpeoplelist[i] + "";
                    //del_msg_content[i] = "删除信息";
                }
			}
		}
    }
	
	//返回前台调用
	public string[] MsgList
	{
		get { return msglist; }
	}

	public string[] TimeList
	{
		get { return timelist; }
	}

	public string[] SendPeopleList
	{
		get { return sendpeoplelist; }
	}
	public int MsgCount
	{
		get { return msgcount; }
	}
    public string[] SetReadStatusUrl
    {
        get { return set_read_status_url; }
    }
    public string DisplayConten
    {
        get { return display_conten; }
    }
    public string[] DelMsgUrl
    {
        get { return del_msg_url; }
    }
}