using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// article 的摘要说明
/// </summary>
public class article
{
	private readonly DataBase data = new DataBase();
	int article_id;
	string article_title;
	string article_content;
	DateTime article_date;
	int type_id;
	string type_name;
	int view_times=0;
	string username;

	public string Username
	{
		get { return username; }
		set { username = value; }
	}

	public int View_times
	{
		get { return view_times; }
		set { view_times = value; }
	}
	public string Article_title
	{
		get { return article_title; }
		set { article_title = value; }
	}
	public int Article_id
	{
		get { return article_id; }
		set { article_id = value; }
	}


	public DateTime Article_date
	{
		get { return article_date; }
		set { article_date = value; }
	}

	public int Type_id
	{
		get { return type_id; }
		set { type_id = value; }
	}

	public string Type_name
	{
		get { return type_name; }
		set { type_name = value; }
	}

	public string Article_content
	{
		get { return article_content; }
		set { article_content = value; }
	}
	
	public article()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
	//添加文章
	public int InsertArticle(article myarticle)
	{
		SqlParameter[] parms ={
								  data.MakeInParam("@UserName",SqlDbType.VarChar,50,myarticle.username),
								  data.MakeInParam("@Article_title",SqlDbType.VarChar,50,myarticle.article_title),
								  data.MakeInParam("@Article_content",SqlDbType.VarChar,50,myarticle.article_content),
								  data.MakeInParam("@Article_date",SqlDbType.DateTime,50,myarticle.article_date),
								  data.MakeInParam("@Type_name",SqlDbType.VarChar,50,myarticle.type_name),
								  data.MakeInParam("@Type_id",SqlDbType.Int,50,myarticle.type_id),
								  data.MakeInParam("@View_times",SqlDbType.Int,50,myarticle.view_times),
							  };
		return data.RunProc("insert into article (username, article_title, article_content, article_date, type_name, type_id,view_times) values(@UserName,@Article_title,@Article_content,@Article_date,@Type_name,@Type_id,@View_times) ", parms);
	}
    //根据文章id获取文章
	public DataSet GetArticleById(article myarticle)
	{
		SqlParameter[] parms ={
								 data.MakeInParam("@Article_id",SqlDbType.Int,50,myarticle.Article_id),
							 };
		return data.RunProcReturn("select * from article where article_id=@Article_id",parms,"article");
	}
}