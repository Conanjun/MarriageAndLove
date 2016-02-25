using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_auth_user_common_user_myfriend : System.Web.UI.Page
{
	private static PagedDataSource pds = new PagedDataSource();//分页类，先用着，后面再封装到App_Code中
	Friend myfriend = new Friend();
	string[] FriendList=null;
	string[] FriendAskList = null;
    string[] SearchFriendList = null;
    string searchname;
    int count = 0;
	int search_count=0;
	int ask_count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] == null)
		{
			Response.Redirect("../../../../index.aspx");
		}
		else
		{
			myfriend.UserName = Session["username"].ToString();
			Label2.Text=myfriend.SelectFriendSum(myfriend).Tables[0].Rows.Count.ToString();
			count=myfriend.SelectFriendByUserName(myfriend).Tables[0].Rows.Count;
			FriendList = new string[count];//动态设置朋友列表字符串数组的长度
			for (int i = 0; i < count; i++)
			{
				FriendList[i] = myfriend.SelectFriendByUserName(myfriend).Tables[0].Rows[i]["friendname"].ToString();
			}
			ask_count = myfriend.SelectFriendAskByUserName(myfriend).Tables[0].Rows.Count;
			FriendAskList = new string[ask_count];
			for (int i = 0; i < ask_count; i++)
			{
				FriendAskList[i] = myfriend.SelectFriendAskByUserName(myfriend).Tables[0].Rows[i]["friendname_toask"].ToString();
			}

		}
    }

	public string ROOTPATH
	{
		get
		{
			string strPath = Request.ApplicationPath;
			if (strPath == "/")
			{
				return String.Empty;
			}
			else
			{
				return strPath;
			}
		}
	}
	//返回给页面使用
	public String[] friendlist
	{
		get
		{
			return FriendList;
		}
	}
	public int FriendCount
	{
		get
		{
			return count;
		}
	}
	public String[] friendasklist
	{
		get
		{
			return FriendAskList;
		}
	}

	public int FriendAskCount
	{
		get
		{
			return ask_count;
		}
	}
	
	

	//发送消息按钮事件
	protected void Button1_Click(object sender, EventArgs e)
	{

	}
	//删除好友按钮事件
	protected void Button2_Click(object sender, EventArgs e)
	{

	}
	protected void search_Click(object sender, EventArgs e)
	{
        searchname = this.TextBox1.Text;
        search_count = myfriend.SearchFriend(myfriend,searchname).Tables[0].Rows.Count;
        SearchFriendList = new string[search_count];
        for (int i = 0; i < search_count; i++)
        {
            SearchFriendList[i] = myfriend.SearchFriend(myfriend,searchname).Tables[0].Rows[i]["friendname"].ToString();
        }
    }
        public string[] searchfriendlist
        {
	      get
         {
		return SearchFriendList;
	      }
        }
        public int SearchFriendCount
       {
         get
           {
return search_count;
           }
       }	
	protected void add_Click(object sender, EventArgs e)
	{
		//发送添加好友申请，等待被添加好友的允许后可添加好友
		if (myfriend.FriendAsk(myfriend, TextBox2.Text) == 0)
		{
			WebMessageBox.Show("添加好友申请成功");
		}
	}
	//判断好友在线情况
	public bool isInOnlineUserReal(string username)
	{
		string[] useronline = Application["users_online_real"].ToString().Split(',');
		for (int i = 0; i < (int)Application["users_online_count_real"]; i++)
		{
			if (useronline[i] == username)
			{
				return true;
			}
		}
		return false;
	}
}