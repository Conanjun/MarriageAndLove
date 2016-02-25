using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// reply 的摘要说明
/// </summary>
/// 评论表数据库接口
public class reply
{
	private readonly DataBase data = new DataBase();
	string reply_username;
	string reply_title;
	string reply_content;
	DateTime reply_date;
	int article_id;
	string username;

	public int Article_id
	{
		get { return article_id; }
		set { article_id = value; }
	}
	public string Username
	{
		get { return username; }
		set { username = value; }
	}
	public string Reply_username
	{
		get { return reply_username;}
		set { reply_username = value; }
	}
	public string Reply_title
	{
		get { return reply_title; }
		set { reply_title = value; }
	}
	public string Reply_content
	{
		get { return reply_content; }
		set { reply_content = value; }
	}
	public DateTime Reply_date
	{
		get { return reply_date; }
		set { reply_date = value; }
	}
	public reply()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
	//获取该文章评论
	public DataSet GetComments(reply myreply)
	{
		SqlParameter[] parms ={
								// data.MakeInParam("@Username",SqlDbType.VarChar,50,myreply.username),
								// data.MakeInParam("@Reply_title",SqlDbType.VarChar,50,myreply.reply_title),
								// data.MakeInParam(reply_content),
								 //data.MakeInParam(reply_date),
								 data.MakeInParam("@Article_id",SqlDbType.Int,50,myreply.article_id),
								 //data.MakeInParam(username),
							 };
		return data.RunProcReturn("select * from reply where article_id=@Article_id",parms,"reply");
	}
}