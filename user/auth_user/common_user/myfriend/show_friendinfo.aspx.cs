using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_myfriend_show_friendinfo : System.Web.UI.Page
{
	UserInfo myinfo = new UserInfo();
	string name = "";
	string sex = "";
	int age = 0;
	int salary = 0;
	string marriage = "";
	string degree = "";
	int height = 0;
	string address = "";
	string nativeplace = "";
	
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["username"] == null)
		{
			Response.Redirect("../../../../index.aspx");
		}

		myinfo.UserName = Request.QueryString["friendname_dtl"];
		if (myinfo.GetUserInfo(myinfo).Tables[0].Rows.Count > 0)
		{
			name = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["name"].ToString();
			sex = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["sex"].ToString();
			age = Convert.ToInt32((myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["age"]));
			salary = Convert.ToInt32(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["salary"]);
			marriage = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["marriage"].ToString();
			degree = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["degree"].ToString();
			height = Convert.ToInt32(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["height"]);
			address = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["address"].ToString();
			nativeplace = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["nativeplace"].ToString();
			

			namet.Text = name;
			sext.Text = sex;
			aget.Text = Convert.ToString(age);
			salaryt.Text = Convert.ToString(salary);
			marriaget.Text = marriage;
			degreet.Text = degree;
			heightt.Text = Convert.ToString(height);
			addresst.Text = address;
			nativeplacet.Text = nativeplace;


		}
	}
}