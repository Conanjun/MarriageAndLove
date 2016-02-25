<%@ WebHandler Language="C#" Class="GetNearbyUsers" %>

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

public class NearbyUsers
{
	public int nearby_users_count{get;set;}
	public string[] nearby_users{get;set;}
}

public class GetNearbyUsers : IHttpHandler {
	UserInfo myuser_info = new UserInfo();
	string user_pos;
	int user_nearby_count = 0;//用户附近的人的人数
	int other_user_pos_count = 0;
    public void ProcessRequest (HttpContext context) {
		myuser_info.UserName = context.Request["username"];
		string[] pos = myuser_info.GetUserInfo(myuser_info).Tables[0].Rows[0]["address"].ToString().Split('-');
		user_pos = pos[0] + pos[1] + pos[2];//获取该用户前三级地址
		//获取与该用户相同的其他用户的第四级地址即为附近的人的地址列表
		other_user_pos_count = myuser_info.GetOtherUserAddress(myuser_info).Tables[0].Rows.Count;
		string[] other_user_pos_list = new string[other_user_pos_count];
		string[] user_nearby_pos = new string[other_user_pos_count];

		for (int i = 0; i < other_user_pos_count; i++)
		{
			other_user_pos_list[i] = myuser_info.GetOtherUserAddress(myuser_info).Tables[0].Rows[i]["address"].ToString();
			string[] other_user_pos_one_two_three = other_user_pos_list[i].Split('-');
			//前三级地址与该用户的前三级地址相同则判定为附近的人
			if (other_user_pos_one_two_three[0] + other_user_pos_one_two_three[1] + other_user_pos_one_two_three[2] == user_pos)
			{
				user_nearby_count++;
				user_nearby_pos[i] = other_user_pos_one_two_three[3];//如果是附近的人则取出第四级地址
			}
		}		
		
		NearbyUsers my_nearby_users = new NearbyUsers();
		my_nearby_users.nearby_users_count = user_nearby_count;
		my_nearby_users.nearby_users = user_nearby_pos;
		JavaScriptSerializer serializer = new JavaScriptSerializer();
		string JsonStr = serializer.Serialize(my_nearby_users);
		context.Response.Write(JsonStr);
		context.Response.End();
       // context.Response.ContentType = "text/plain";
       // context.Response.Write("Hello World");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}