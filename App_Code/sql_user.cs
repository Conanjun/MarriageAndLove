﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// sql_user_login_register 的摘要说明
/// </summary>
public class sql_user
{
	//引入DataBase类
	private readonly DataBase data = new DataBase();
	//用户基本信息
	string username = "";
	string password = "";
	string email = "";
	string phone = "";
	int status = 0;//默认未激活
	int grank = 0;//标明用户等级，0为未认证用户，1为认证的普通用户，2为认证的vip用户
	//int sex = 0;//标明用户性别，0为保密，1为男，2为女
    string activecode = "";
    string resetcode = "";

	public string UserName
	{
		get { return username; }
		set { username = value; }
	}
	public string PassWord
	{
		get { return password; }
		set { password = value; }
	}
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
	public string Phone
	{
		get { return phone; }
		set { phone = value; }
	}
	public int Status
	{
		get { return status; }
		set { status = value; }
	}
	public int Grank
	{
		get { return grank; }
		set { grank = value; }
	}
	/*public int Sex
	{
		get { return sex; }
		set { sex = value; }
	}*/
    public string ActiveCode
    {
        get { return activecode; }
        set { activecode = value; }
    }
    public string ResetCode
    {
        get { return resetcode; }
        set { resetcode = value; }
    }
	
	//会员登录
	//账号登陆
	public DataSet LoginByAccount(sql_user user)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.email),
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
		//返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
		return data.RunProcReturn("select * from users where username=@Username and password=@PassWord",parms,"users");
	}

    //由邮箱登录
    public DataSet LoginByEmail(sql_user user)
    {
        SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
                                 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProcReturn("select * from users where email=@Email and password=@PassWord", parms, "users");
    }


    //由邮箱查找用户名
    public DataSet LoginByEmail_FindUserName(sql_user user)
    {
        SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
                                 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProcReturn("select username from users where email=@Email and password=@PassWord", parms, "users");
    }


    //由手机登录
    public DataSet LoginByPhone(sql_user user)
    {
        SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 //data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
                                 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 data.MakeInParam("@Phone",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProcReturn("select * from users where phone=@Phone and password=@PassWord", parms, "users");
    }


    //由手机查找用户名
    public DataSet LoginByPhone_FindUserName(sql_user user)
    {
        SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 //data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
                                 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 data.MakeInParam("@Phone",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProcReturn("select username from users where phone=@Phone and password=@PassWord", parms, "users");
    }

    //用户邮箱注册
    public int RegisterByEmail(sql_user user)
    {
        /*
        string db_email = email.Text;
        string db_username = username.Text;
        string db_password = password.Text;
         */

        SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								 data.MakeInParam("@UserPhone",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProc("insert into users(username,password,email,phone) values(@UserName,@PassWord,@Email,0) ", parms);
    }

    //用户邮箱注册
    public int RegisterByPhone(sql_user user)
    {
        SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								 data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								 data.MakeInParam("@Phone",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        //返回结果集的方式，使用data.Tables[0].Rows.Count取得行数判断是否登录成功
        return data.RunProc("insert into users(username,password,email,phone) values(@UserName,@PassWord,0,@Phone) ", parms);
    }
    
    //用于判断用户名是否存在
    public DataSet IsUserExist(sql_user user)
    {
        SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 //data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.email),
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        return data.RunProcReturn("select * from users where username=@Username", parms, "users");
    }

    //用于判断邮箱是否存在
    public DataSet IsEmailExist(sql_user user)
    {
        SqlParameter[] parms ={
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 //data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
								data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								 //data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.phone),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.status),
								 //data.MakeInParam("@UserName",SqlDbType.Int,50,user.grank),
								// data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.sex),
							 };
        return data.RunProcReturn("select * from users where email=@Email", parms, "users");
    }

    //注册用户激活状态
    public int InsertUserActiveCode(sql_user user)
    {
        SqlParameter[] parms ={
								  data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								  data.MakeInParam("@ActiveCode",SqlDbType.VarChar,50,user.activecode),
							  };
        return data.RunProc("insert into activecode(username,activecode) values(@UserName,@ActiveCode) ", parms);
    }
    
    
    
    public bool IsStatusValid(sql_user user)
	{
		SqlParameter[] parms ={
								  data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								 // data.MakeInParam("@Status",SqlDbType.Int,50,user.status),
							  };
		if (data.RunProcReturn("select * from users where username=@Username", parms, "users").Tables[0].Rows[0]["status"].ToString() == "1")
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	//更新用户激活状态
	public int UpdateUserStatus(sql_user user)
	{
		SqlParameter[] parms ={
								  data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								  data.MakeInParam("@Status",SqlDbType.TinyInt,1,user.status),
							  };
		return data.RunProc("update users set status=1 where username=@username",parms);
	}

    //注册用户重置码
    public int InsertUserResetCode(sql_user user)
    {
        SqlParameter[] parms ={
								  data.MakeInParam("@UserName",SqlDbType.VarChar,50,user.username),
								  data.MakeInParam("@ResetCode",SqlDbType.VarChar,50,user.resetcode),
							  };
        return data.RunProc("insert into resetcode(username,resetcode) values(@UserName,@ResetCode) ", parms);
    }
    
    //通过邮箱更新密码
    public int UpdateUserPassword(sql_user user)
    {
        SqlParameter[] parms ={
								  data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								  data.MakeInParam("@PassWord",SqlDbType.VarChar,50,user.password),
							  };
        return data.RunProc("update users set password=@PassWord where email=@Email", parms);
    }

    //删除重置码
    public int EmailResetCodeDelete(sql_user user)
    {
        SqlParameter[] parms ={
								  data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								  data.MakeInParam("@ResetCode",SqlDbType.VarChar,50,user.resetcode),
							  };
        return data.RunProc("delete from resetcode where email=@Email and resetcode=@ResetCode", parms);
    }

    //验证重置码
    public DataSet EmailResetCodeSelect(sql_user user)
    {
        SqlParameter[] parms ={
								 data.MakeInParam("@Email",SqlDbType.VarChar,50,user.email),
								 data.MakeInParam("@ResetCode",SqlDbType.VarChar,50,user.resetcode),
							  };
       
        return data.RunProcReturn("SELECT * FROM resetcode WHERE email = @Email and resetcode=@ResetCode", parms, "user");
    }

	//获取所有用户的用户名
	public DataSet GetAllUsername(sql_user user)
	{
		SqlParameter[] parms ={
							 };
		return data.RunProcReturn("select username from users",parms,"users");
	}
	public sql_user()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}