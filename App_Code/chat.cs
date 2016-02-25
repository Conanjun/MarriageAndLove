using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// chat 的摘要说明
/// </summary>
public class chat
{
	private readonly DataBase data = new DataBase();
	string lauch_username;
	string invited_usrname;

	public string Launch_username
	{
		get { return lauch_username; }
		set { lauch_username = value; }
	}

	public string Invited_username
	{
		get { return invited_usrname; }
		set { invited_usrname = value; }
	}

	//获取某一用户收到的聊天请求

	public DataSet GetChatAsk(chat mychat)
	{
		SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 //data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
                                 //data.MakeInParam("@Lauch_username",SqlDbType.VarChar,50,mychat.lauch_username),
								 data.MakeInParam("@Invited_username",SqlDbType.VarChar,50,mychat.invited_usrname),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
		//返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
		return data.RunProcReturn("select * from chat_invite where invited_username=@Invited_username", parms, "chat_invite");
	}

	//发起聊天时插入一条聊天请求
	public int InsertChatAsk(chat mychat)
	{
		SqlParameter[] parms ={
								data.MakeInParam("@Launch_username",SqlDbType.VarChar,50,mychat.lauch_username),
								 data.MakeInParam("@Invited_username",SqlDbType.VarChar,50,mychat.invited_usrname),

							 };
		return data.RunProc("insert into chat_invite(launch_username,invited_username) values(@Launch_username,@Invited_username) ", parms);
	}
	//退出聊天室删除一条聊天请求
	public int DelChatAsk(chat mychat){
		SqlParameter[] parms ={
								data.MakeInParam("@Lauch_username",SqlDbType.VarChar,50,mychat.lauch_username),
								 data.MakeInParam("@Invited_username",SqlDbType.VarChar,50,mychat.invited_usrname),

							 };
		return data.RunProc("delete from chat_invite where lauch_username=@Lauch_username and invited_usrname=@Invited_username) ", parms);
	}

	public chat()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}