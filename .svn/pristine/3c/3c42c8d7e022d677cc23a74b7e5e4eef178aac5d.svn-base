using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// friend 的摘要说明
/// </summary>
public class Friend
{
	string username = "";
	string friendname = "";
	public string UserName
	{
		get { return username; }
		set { username = value; }
	}

	public string FriendName
	{
		get { return friendname; }
		set { friendname = value; }
	}

	private readonly DataBase data = new DataBase();

	//申请添加好友
	public int FriendAsk(Friend friend,string friendAsked)
	{
		SqlParameter[] parms={
								 data.MakeInParam("@friendAsked",SqlDbType.VarChar,50,friendAsked),
								 data.MakeInParam("@friendToask",SqlDbType.VarChar,50,friend.username),
							 };
		return data.RunProc("insert into friendask(friendname_asked,friendname_toask) values(@friendAsked,@friendToask)",parms);
	}


	//添加好友
	public int FriendAdd(Friend friend)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, friend.username),
                data.MakeInParam("@FriendName", SqlDbType.VarChar, 50, friend.friendname),
            };
		return data.RunProc("Insert into friend(username, friendname) values (@UserName, @FriendName)", parms);
	}

	//删除好友
	public int FriendDelete(string del_friendname)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,username),
								 data.MakeInParam("@FriendName",SqlDbType.VarChar,50,del_friendname),
							 };
		//return data.RunProc("delete from friend where username=@UserName and friendname=@FriendName",parms)+data.RunProc("delete from friend where username=@FriendName and friendname=@UserName");
		return data.RunProc("delete from friend where username=@UserName and friendname=@FriendName", parms);
	}

	//查询用户是否将其加为好友
	public DataSet SelectFriend(Friend friend)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, friend.UserName),
                data.MakeInParam("@FriendName", SqlDbType.VarChar, 50, friend.FriendName),
            };
		return
			data.RunProcReturn(
				"SELECT * FROM friend WHERE (username = @UserName ) AND (friendname =  @FriendName )", parms,
				"friend");
	}

    public DataSet SearchFriend(Friend friend,string searchname)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, friend.UserName),
                data.MakeInParam("@FriendName", SqlDbType.VarChar, 50, searchname),
            };
		return data.RunProcReturn("SELECT friendname FROM friend WHERE userName = @UserName AND friendname = @FriendName", parms, "friend");
	}

    //获取用户所有好友
	public DataSet SelectFriendByUserName(Friend friend)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, friend.UserName),
            };
		return data.RunProcReturn("SELECT * FROM friend WHERE userName = @UserName", parms, "friend");
	}

	//获取用户所有的好友申请
	public DataSet SelectFriendAskByUserName(Friend friend)
	{
		SqlParameter[] parms ={
								  data.MakeInParam("@friendAsked",SqlDbType.VarChar,50,friend.UserName),
							 };
		return data.RunProcReturn("select * from friendask where friendname_asked=@friendAsked and ask_status=0", parms, "friendask");
	}

	//允许好友申请
	public int AcceptFriendAsk(Friend friend,string accept_friendname)
	{
		//先将friendask里的status置为1，表示允许 0表示未处理 2表示拒绝
		SqlParameter[] parms ={
								data.MakeInParam("@friendname_asked",SqlDbType.VarChar,50,username),
								data.MakeInParam("@friendname_toask",SqlDbType.VarChar,50,accept_friendname),
							 };
		data.RunProc("update friendask set ask_status=1 where friendname_asked=friendname_asked and friendname_toask=@friendname_toask", parms);
		//再往用户的好友里添加该用户同时对方也要添加用户为好友
		SqlParameter[] parms1 ={
								data.MakeInParam("@friendname_asked",SqlDbType.VarChar,50,username),
								data.MakeInParam("@friendname_toask",SqlDbType.VarChar,50,accept_friendname),
							  };
		data.RunProc("insert into friend(username,friendname) values(@friendname_asked,@friendname_toask)",parms1);
		SqlParameter[] parms2 ={
								data.MakeInParam("@friendname_asked",SqlDbType.VarChar,50,username),
								data.MakeInParam("@friendname_toask",SqlDbType.VarChar,50,accept_friendname),
							  };
		data.RunProc("insert into friend(username,friendname) values(@friendname_toask,@friendname_asked)", parms2);
		return 0;
	}

	public int RefuseFriendAsk(Friend friend, string refuse_friendname)
	{
		//先将friendask里的status置为2，表示允许 0表示未处理 1表示接收
		SqlParameter[] parms ={
								data.MakeInParam("@friendname_asked",SqlDbType.VarChar,50,username),
								data.MakeInParam("@friendname_toask",SqlDbType.VarChar,50,refuse_friendname),
							 };
		return data.RunProc("update friendask set ask_status=2 where friendname_asked=friendname_asked and friendname_toask=@friendname_toask", parms);
	}

	//统计好友个数以便分页
	
	public DataSet SelectFriendSum(Friend friend)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@username", SqlDbType.VarChar, 50, friend.username),
            };
		return data.RunProcReturn("SELECT * FROM friend WHERE username = @UserName", parms, "friend");
	}
	//查看好友个人信息
	public DataSet SelectFriendInfo(Friend friend)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@username", SqlDbType.VarChar, 50, friend.friendname),
            };
		return data.RunProcReturn("SELECT * FROM userinfo WHERE username = @UserName", parms, "userinfo");
	}
	
	public Friend()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}