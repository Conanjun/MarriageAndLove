using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;



/// <summary>
/// msg 的摘要说明
/// </summary>
public class msg
{
	private readonly DataBase data = new DataBase();

	string send_username = "";
	string recv_username = "";
	string message = "";
	DateTime date_time;
	int readed = 0;//0表示未阅读，1表示已阅

	public string SendUsername
	{
		get { return send_username; }
		set { send_username = value; }
	}

	public string RecvUsername
	{
		get { return recv_username; }
		set { recv_username = value; }
	}

	public string Message
	{
		get { return message; }
		set { message = value; }
	}

	public DateTime DateTime
	{
		get { return date_time; }
		set { date_time=value; }
	}
	public int Readed
	{
		get { return readed; }
		set { readed = value; }
	}
	//加入一条消息
	public int MessageInsert(msg mymsg)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
								 data.MakeInParam("@Readed",SqlDbType.TinyInt,2,mymsg.readed),
							 };
		return data.RunProc("insert into msg(send_username,recv_username,content,sendtime,readed) values(@SendUsername,@RecvUsername,@Message,@Sendtime,@Readed)", parms);
	}

	//删除一条消息
	public int MessageDelete(msg mymsg)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProc("delete from msg where send_username=@SendUsername and recv_username=@RecvUsername and content=@Message and sendtime=@Sendtime", parms);
	}

	//根据发送人获取消息
	public DataSet MessageSelectBySendUser(msg mymsg)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 //data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 //data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 //data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProcReturn("select * from msg where send_username=@SendUsername",parms,"msg");
	}
	
	//根据接收人获取消息
	public DataSet MessageSelectByRecvUser(msg mymsg)
	{
		SqlParameter[] parms ={
								// data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 //data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 //data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProcReturn("select * from msg where recv_username=@RecvUsername", parms, "msg");
	}
	//根据接收人获取未读消息
	public DataSet MessageSelectByRecvUserUnreaded(msg mymsg)
	{
		SqlParameter[] parms ={
								// data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 //data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 //data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProcReturn("select * from msg where recv_username=@RecvUsername and readed=0", parms, "msg");
	}
	//根据接收人获取已读消息
	public DataSet MessageSelectByRecvUserReaded(msg mymsg)
	{
		SqlParameter[] parms ={
								// data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 //data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 //data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProcReturn("select * from msg where recv_username=@RecvUsername and readed=1", parms, "msg");
	}
	//更改消息阅读状态为已阅
	public int MessageUpdate(msg mymsg)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@SendUsername",SqlDbType.VarChar,50,mymsg.send_username),
								 data.MakeInParam("@RecvUsername",SqlDbType.VarChar,50,mymsg.recv_username),
								 data.MakeInParam("@Message",SqlDbType.VarChar,50,mymsg.message),
								 data.MakeInParam("@Sendtime",SqlDbType.DateTime,100,mymsg.date_time),
							 };
		return data.RunProc("update msg set readed=1 where send_username=@SendUsername and recv_username=@RecvUsername and content=@Message and sendtime=@Sendtime", parms);
	}
	

	public msg()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}