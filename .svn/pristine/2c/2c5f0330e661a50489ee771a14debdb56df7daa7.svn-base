using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_map_ShowNearByUsers2 : System.Web.UI.Page
{
	//获取用户的前三级地址 如 广东省-广州市-天河区
	UserInfo myuser_info = new UserInfo();
	string user_pos; //= "广东省广州市天河区"; //暂时写死，后期需从数据库获取
	string[] user_nearby_pos;// = { "广州火车站", "广州塔（赤岗塔）", "广州动物园", "天河公园" };//暂时写死，后期需从数据库获取
	int user_nearby_count = 0;//用户附近的人的人数
	int other_user_pos_count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			myuser_info.UserName = Session["username"].ToString();
			string[] pos=myuser_info.GetUserInfo(myuser_info).Tables[0].Rows[0]["address"].ToString().Split('-');
			user_pos=pos[0]+pos[1]+pos[2];//获取该用户前三级地址
			user_position.Text = user_pos;
			//获取与该用户相同的其他用户的第四级地址即为附近的人的地址列表
			other_user_pos_count=myuser_info.GetOtherUserAddress(myuser_info).Tables[0].Rows.Count;
			string[] other_user_pos_list = new string[other_user_pos_count];
			string[] user_nearby_pos = new string[other_user_pos_count];

			for (int i = 0; i < other_user_pos_count; i++)
			{
				other_user_pos_list[i] = myuser_info.GetOtherUserAddress(myuser_info).Tables[0].Rows[i]["address"].ToString();
				string[] other_user_pos_one_two_three=other_user_pos_list[i].Split('-');
				//前三级地址与该用户的前三级地址相同则判定为附近的人
				if (other_user_pos_one_two_three[0] + other_user_pos_one_two_three[1] + other_user_pos_one_two_three[2] == user_pos)
				{
					user_nearby_count++;
					user_nearby_pos[i] = other_user_pos_one_two_three[3];//如果是附近的人则取出第四级地址
				}
			}
			Console.WriteLine("OK");
		}
		else
		{
			WebMessageBox.Show("session失效，请重新登陆","../../../../index.aspx");
		}
		
    }

	//返回用户地址
	public string UserPos
	{
		get
		{ return user_pos;}
	}
	//返回用户附近的人的地址列表
	public string[] UserNearbyPos
	{
		get
		{ return user_nearby_pos;}
	}

	//返回用户附近的人数
	public int UserNearbyCount
	{
		get { return user_nearby_count; }
	}
}