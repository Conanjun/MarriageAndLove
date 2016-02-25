<%@ Application Language="C#" %>

<script runat="server">

	//全局共享对象，用于用户聊天(聊天室需相应用户共享)
    void Application_Start(object sender, EventArgs e)
    {
		/*应用程序启动初始化一个聊天室需要的对象*/
        string user = "";
        Application["user"] = user;
        Application["userNum"] = 0;
        string chats = "";
        Application["chats"] = chats;
        Application["current"] = 0;
		
		//一次只允许两个人进入
		Application["launch_username"] = "";
		Application["allow_username"] = "";
		
		
		//在线人数
		Application["users_online_count"] = 0;//访问网站的人数
		Application["users_sessionid_online"] = "";
		Application["users_online_real"] = "";
		Application["users_online_count_real"] = 0;//真正登录的用户
		 
    }
    
    void Application_End(object sender, EventArgs e)
    {
        Application["user"] = "";
        Application["chat"] = "";
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
		//this.Session.Timeout = 20;

		Application.Lock();
		//用户登录并且不在已经在线的列表里
		//if (Session["username"] != null && !IsInOnlineUser(Session["username"].ToString()))
		//if (Session["username"] != null)
		//if(!IsInOnlineUser(Session["username"].ToString()))
		if(!IsInOnlineUser(Context.Session.SessionID))
		{
			Application["users_online_count"] = (int)Application["users_online_count"] + 1;
			Application["users_sessionid_online"] = Application["users_sessionid_online"] + "," + Context.Session.SessionID.ToString();
		}
		Application.UnLock(); 
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
		Application.Lock();
		Application["users_online_count"] = (int)Application["users_online_count"] - 1;
		//Application["users_sessionid_online"] = ""
		string users_sessionid_online = Application["users_sessionid_online"].ToString();
		Application["users_sessionid_online"] = users_sessionid_online.Replace(Context.Session.SessionID.ToString(), "");
		Application.UnLock(); 
    }

	bool IsInOnlineUser(string session_id)
	{
		string[] useronline = Application["users_sessionid_online"].ToString().Split(',');
		for (int i = 0; i < (int)Application["users_online_count"]; i++)
		{
			if (useronline[i] == session_id)
			{
				return true;
			}
		}
		return false;
	}
		
</script>
