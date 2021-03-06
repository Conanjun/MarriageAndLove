﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class search_for_fate_fate_search : System.Web.UI.Page
{
	choose mychoose = new choose();
	sql_user myuser = new sql_user();
	//匹配的用户名及其相应的匹配分数
	string most_match_username;
	string[] match_username;
	int match_user_count;
	int[] match_score;

	//匹配项
	string csex;//
	string option1;
	string option2;//
	string option3;//
	string option4;
	string option5;
	string option6;//
	string option7;//
	string option8;//
	string option9;
	string option10;
	string option11;
	string option12;
	int age;//
	string marriagestatus;//
	string degree;//
	int height;//
	string locationarea;
	string ishaiimage;
	int salary;//
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["username"] != null)
		{
			myuser.UserName = mychoose.Username = Session["username"].ToString();
		}
		else
		{
			WebMessageBox.Show("sessioin失效，请重新登录");
		}
	}
	public void SetMatchOption(choose mychoose)
	{
		csex = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["csex"].ToString();
		option1 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option1"].ToString();
		option2 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option2"].ToString();
		option3 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option3"].ToString();
		option4 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option4"].ToString();
		option5 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option5"].ToString();
		option6 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option6"].ToString();
		option7 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option7"].ToString();
		option8 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option8"].ToString();
		option9 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option9"].ToString();
		option10 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option10"].ToString();
		option11 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option11"].ToString();
		option12 = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["option12"].ToString();
		age = Convert.ToInt32(mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["age"]);
		marriagestatus = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["marriagestatus"].ToString();
		degree = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["degree"].ToString();
		height = Convert.ToInt32(mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["height"]);
		locationarea = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["locationarea"].ToString();
		ishaiimage = mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["ishasimage"].ToString();
		salary = Convert.ToInt32(mychoose.SelectChoose(mychoose).Tables[0].Rows[0]["salary"]);
	}

	public void SetMatchUsernameAndMatchUserCountAndMatchUserScore(sql_user matchuser)
	{
		match_user_count = matchuser.GetAllUsername(matchuser).Tables[0].Rows.Count;
		match_username = new string[match_user_count];
		match_score = new int[match_user_count];
		for (int i = 0; i < match_user_count; i++)
		{
			match_username[i] = matchuser.GetAllUsername(matchuser).Tables[0].Rows[i]["username"].ToString();
		}
	}

	public int ConvertDegreeToInt(string degree)
	{
		switch (degree)
		{
			case "大专": return 1; break;
			case "本科": return 2; break;
			case "硕士": return 3; break;
			case "博士": return 4; break;
			case "海归": return 5; break;
			default: return 0;
		}
	}

	//获取匹配分数最高的下标
	public int GetMaxIndex(int[] score, int count)
	{
		int index = 0;
		int max = score[0];
		for (int i = 0; i < count; i++)
		{
			if (score[i] > max)
			{
				max = score[i];
				index = i;
			}
		}
		return index;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		
		//获取用户的择偶要求
		SetMatchOption(mychoose);
		//获取会员用来匹配的信息
		SetMatchUsernameAndMatchUserCountAndMatchUserScore(myuser);
		//遍历要匹配的用户并并设置匹配程度数组
		for (int i = 0; i < match_user_count; i++)
		{
			UserInfo match_user = new UserInfo();//新建一个临时对象，并用待匹配的会员初始化
			match_user.UserName = match_username[i];
			//暂时只用11个匹配项作为匹配条件
			match_user.Sex = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["sex"].ToString();
			match_user.Option2 = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["option2"].ToString();
			match_user.Option3 = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["option3"].ToString();
			match_user.Option6 = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["option6"].ToString();
			match_user.Option7 = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["option7"].ToString();
			match_user.Option8 = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["option8"].ToString();
			match_user.Age = Convert.ToInt32(match_user.GetUserInfo(match_user).Tables[0].Rows[0]["age"]);
			match_user.Marriage = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["marriage"].ToString();
			match_user.Degree = match_user.GetUserInfo(match_user).Tables[0].Rows[0]["degree"].ToString();
			match_user.Height = Convert.ToInt32(match_user.GetUserInfo(match_user).Tables[0].Rows[0]["height"]);
			match_user.Salary = Convert.ToInt32(match_user.GetUserInfo(match_user).Tables[0].Rows[0]["salary"]);

			//开始匹配
			if (csex == match_user.Sex) { match_score[i]++; }
			if (option2 == match_user.Option2) { match_score[i]++; }
			if (option3 == match_user.Option3) { match_score[i]++; }
			if (option6 == match_user.Option6) { match_score[i]++; }
			if (option7 == match_user.Option7) { match_score[i]++; }
			if (option8 == match_user.Option8) { match_score[i]++; }
			if (System.Math.Abs(age - match_user.Age) <= 5) { match_score[i]++; }
			if (marriagestatus == match_user.Marriage) { match_score[i]++; }
			//转换学历为数字比较
			if (ConvertDegreeToInt(degree) <= ConvertDegreeToInt(match_user.Degree)) { match_score[i]++; }
			if (height <= match_user.Height) { match_score[i]++; }
			if (salary <= match_user.Salary) { match_score[i]++; }
		}
		//取出匹配分数最高的会员返回前台
		int temp_index = GetMaxIndex(match_score, match_user_count);
		//最匹配的会员的用户名
		most_match_username = match_username[temp_index];
		Label2.Text = most_match_username;
	}
}