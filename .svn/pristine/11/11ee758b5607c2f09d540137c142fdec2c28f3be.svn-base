<%@ WebHandler Language="C#" Class="chat_notice" %>

using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

//聊天请求
public class chat_invite
{
	public string launch_username { get; set; }
	public string invited_username { get; set; }
	public int IfHasInvite { get; set; }
}

public class chat_notice : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
		chat mychat = new chat();
		//mychat.Launch_username = context.Request["launch_username"];
		mychat.Invited_username = context.Request["invited_username"];
		if (mychat.GetChatAsk(mychat).Tables[0].Rows.Count > 0)
		{
			chat_invite my_chat_invite = new chat_invite();
			my_chat_invite.launch_username = mychat.GetChatAsk(mychat).Tables[0].Rows[0]["launch_username"].ToString();
			my_chat_invite.invited_username = mychat.GetChatAsk(mychat).Tables[0].Rows[0]["invited_username"].ToString();
			my_chat_invite.IfHasInvite = 1;
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			string JsonStr = serializer.Serialize(my_chat_invite);
			context.Response.Write(JsonStr);
			context.Response.End();
		}
		else
		{
			chat_invite my_chat_invite = new chat_invite();
			my_chat_invite.launch_username = null;
			my_chat_invite.invited_username = null;
			my_chat_invite.IfHasInvite = 0;
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			string JsonStr = serializer.Serialize(my_chat_invite);
			context.Response.Write(JsonStr);
			context.Response.End();	
		}
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}