using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_chat_chatroom : System.Web.UI.Page
{
	//页面加载时使用Sessioin中的username初始化Global.asax中的user
    protected void Page_Load(object sender, EventArgs e)
    {
		Application.Lock();
		int peopleNumber;
		string peopleName;
		string peopleNames;
		string[] peopleUser;
		bool IsPersonIn=false;
		string launch_username;
		string allow_username;
		

		peopleNumber = Int32.Parse(Application["userNum"].ToString());

		if(Session["username"]==null)
		//if (TextBox1.Text == "")
		{
			WebMessageBox.Show("用户未登陆，请登陆后再进入聊天","../../../../login/login.aspx");
		}
		else
		{
			chat chat_ask = new chat();
			if (Request.QueryString["launch_username"] != null && Request.QueryString["invited_username"] != null)
			{
				chat_ask.Launch_username = Request.QueryString["launch_username"];
				chat_ask.Invited_username = Request.QueryString["invited_username"];
				chat_ask.InsertChatAsk(chat_ask);
			}
			
			/*
			if (Request.QueryString["join_username"] == null)//发起聊天设置允许进入聊天室的对象
			{
				if (Request.QueryString["launch_user"] != null)
				{
					Application["launch_username"] = Request.QueryString["launch_user"];
				}
				if (Request.QueryString["friendname_chat"] != null)
				{
					Application["allow_username"] = Request.QueryString["friendname_chat"];
				}
			}
			else
			{
				//加入聊天
				if (Request.QueryString["join_username"] != Application["allow_username"]) {
					WebMessageBox.Show("你暂时不能与该用户聊天","../myfriend/myfriend.aspx");
				}
			}
			*/
			
		
			peopleName = Session["username"].ToString();
			peopleNames = Application["user"].ToString();
			peopleUser = peopleNames.Split(',');
			for (int i = 0; i < peopleNumber; i++)
			{
				//判断用户是否已在聊天室内
				if (peopleName == peopleUser[i].ToString())
				{
					IsPersonIn = true;
					//int peopleJudge = 1;
					//Response.Redirect("Login.aspx?value=" + peopleJudge);
				}
			}
			if (!IsPersonIn)
			{
				if (peopleNumber == 0)
				{
					Application["user"] = peopleName.ToString();
				}
				else
				{
					Application["user"] = Application["user"] + "," + peopleName.ToString();
				}
				peopleNumber += 1;
				Application["userNum"] = peopleNumber;
				//Session["username"] = peopleName;
			}
			
			Application.UnLock();
			//Response.Redirect("chatroom.aspx");
		}
    }
	protected void Button1_Click(object sender, EventArgs e)
	{
		int peopleCurrent = Int32.Parse(Application["current"].ToString());
		Application.Lock();
		if (peopleCurrent == 0 || peopleCurrent > 20)
		{
			peopleCurrent = 0;
			Application["chats"] = Session["username"].ToString() + "说： " + txtMessage.Text.Trim() + "(" +
								   DateTime.Now.ToString() + ")";
		}
		else
		{
			Application["chats"] = Application["chats"].ToString() + "," + Session["username"].ToString() + "说：" +
								   txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
		}
		peopleCurrent += 1;
		Application["current"] = peopleCurrent;
		Application.UnLock();
	}
	protected void Button2_Click(object sender, EventArgs e)
	{
		Application.Lock();
		string peopleUserName = Application["user"].ToString();
		Application["user"] = peopleUserName.Replace(Session["userName"].ToString(), "");
		Application.UnLock();
		Response.Redirect("../userdefault.aspx");
	}
}