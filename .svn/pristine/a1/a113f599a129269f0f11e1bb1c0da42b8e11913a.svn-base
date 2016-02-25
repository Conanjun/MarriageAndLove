<%@ WebHandler Language="C#" Class="MessageDeal" %>

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

//将后台取得的消息封装为一个对象用于json的序列化和反序列号处理
public class Message
{
	public int message_count { get; set; }
	public int message_read_count { get; set; }
	public int message_unread_count{get;set;}
	public string[] message_read { get; set; }
	public string[] message_unread { get; set; }
	//仍需添加时间
}

public class MessageDeal : IHttpHandler {
	//消息的字符串数组，可按日期时间排序
    public void ProcessRequest (HttpContext context) {
		msg mymsg = new msg();
		mymsg.RecvUsername = context.Request["recv_username"];
		int read_count=mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows.Count;
		int unread_count=mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows.Count;
		string[] Message_Read = new string[read_count];
		string[] Message_UnRead = new string[unread_count];
		for (int i = 0; i < read_count; i++)
		{
			Message_Read[i] = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows[i]["content"].ToString();
		}
		for (int i = 0; i < unread_count; i++)
		{
			Message_UnRead[i] = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows[i]["content"].ToString();
		}
		
		Message mymessage = new Message
		{
			message_count = read_count+unread_count,
			message_unread_count = unread_count,
			message_read_count = read_count,
			message_read=Message_Read,
			message_unread=Message_UnRead
		};
		//序列化对象用于json传输
		//message_count = mymsg.MessageSelectByRecvUser(mymsg).Tables[0].Rows.Count;
		//message_unread_count = mymsg.MessageSelectByRecvUserUnreaded(mymsg).Tables[0].Rows.Count;
		//message_read_count = mymsg.MessageSelectByRecvUserReaded(mymsg).Tables[0].Rows.Count;
        //context.Response.ContentType = "text/plain";
		//string JsonStr = JsonConvert.SerializeObject();//将消息信息转化为json
		//string data="[{\"messagecount\":";
		JavaScriptSerializer serializer = new JavaScriptSerializer();
		string JsonStr = serializer.Serialize(mymessage);
        context.Response.Write(JsonStr);
		context.Response.End();
    }
		
    public bool IsReusable {
        get {
            return false;
        }
    }

}