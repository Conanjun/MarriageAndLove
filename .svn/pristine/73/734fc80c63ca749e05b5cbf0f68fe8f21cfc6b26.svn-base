using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// EmailActive 的摘要说明
/// </summary>
public class EmailOrPhoneActive
{
	private readonly DataBase data = new DataBase();
	string username = "";
	string activecode = "";

	public string UserName
	{
		get
		{
			return username;
		}
		set
		{
			username = value;
		}
	}

	public string ActiveCode
	{
		get
		{
			return activecode;
		}
		set
		{
			activecode = value;
		}
	}

	//往activecode表里插入一条数据
	public int EmailActivateInsert(EmailOrPhoneActive active)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,active.username),
								 data.MakeInParam("@ActiveCode",SqlDbType.VarChar,50,active.activecode),
							 };
		data.RunProc("insert into activecode(username,activecode) values(@UserName,@ActiveCode)",parms);
		return 0;
	}

	//从active表查询数据
	public DataSet EmailActiveSelect(EmailOrPhoneActive active)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,active.username),
								 data.MakeInParam("@ActiveCode",SqlDbType.VarChar,50,active.activecode),
							  };
		//return data.RunProcReturn("select * from active where username=@UserName and activecode=@ActiveCode",parms);
		return data.RunProcReturn("SELECT * FROM activecode WHERE username = @UserName and activecode=@ActiveCode", parms, "activecode");
	}

	//从active表删除数据
	public int EmailActiveDelete(EmailOrPhoneActive active)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,active.username),
								 data.MakeInParam("@ActiveCode",SqlDbType.VarChar,50,active.activecode),
							  };
		return data.RunProc("delete from activecode where username=@UserName and activecode=@ActiveCode",parms);
	}
	public EmailOrPhoneActive()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}