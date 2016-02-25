using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;

public partial class admin_admin_manage : System.Web.UI.Page
{
	string[] username;
	string[] useremail;
	string[] userphone;
	string[] userstatus;
	string[] userrank;
	int count = 0;

	sql_admin myadmin = new sql_admin();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (false)
		{
			//WebMessageBox.Show("session失效，管理员重新登录","login.aspx");
		}
		else
		{	
			myadmin.AdminName = Session["username"].ToString();
			count = myadmin.GetAllUsers().Tables[0].Rows.Count;
			username = new string[count];
			useremail = new string[count];
			userphone = new string[count];
			userstatus = new string[count];
			userrank = new string[count];
			for (int i = 0; i < count; i++)
			{
				username[i] = myadmin.GetAllUsers().Tables[0].Rows[i]["username"].ToString();
				useremail[i] = myadmin.GetAllUsers().Tables[0].Rows[i]["email"].ToString();
				userphone[i] = myadmin.GetAllUsers().Tables[0].Rows[i]["phone"].ToString();
				userstatus[i] = myadmin.GetAllUsers().Tables[0].Rows[i]["status"].ToString();
				userrank[i] = myadmin.GetAllUsers().Tables[0].Rows[i]["grank"].ToString();
			}
			if (!IsPostBack)
			{
				//调用绑定分页和GridView
				BindData();
			}
		}
	}

	//分页

	
	protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{

		GridView1.PageIndex = e.NewPageIndex;

		BindData();

	}
	//将用户消息绑定到分页器上
	protected void BindData()
	{
		DataTable dt = new DataTable();
		dt.Columns.Add("username");
		dt.Columns.Add("useremail");
		dt.Columns.Add("userphone");
		dt.Columns.Add("tempstatus");
		dt.Columns.Add("temprank");
		for (int i = 0; i < count; i++)
		{
			string tempstatus;
			if (userstatus[i] == "1")
			{
				tempstatus = "已激活";
			}
			else
			{
				tempstatus = "未激活";
			}
			string temprank;
			if (userrank[i] == "1")
			{
				temprank = "vip会员";
			}
			else
			{
				temprank = "普通会员";
			}
			dt.Rows.Add(username[i], useremail[i], userphone[i], tempstatus, temprank);
		}
		this.GridView1.DataSource = dt.DefaultView;
		this.GridView1.DataKeyNames = new string [] { "username" };//设置主键
		this.GridView1.DataBind();
	}
	public int Count
	{
		get { return count; }
	}
	public string[] UserName
	{
		get { return username; }
	}

	public string[] UserEmail
	{
		get { return useremail; }
	}

	public string[] UserPhone
	{
		get { return userphone; }

	}

	public string[] UserStatus
	{
		get { return userstatus; }
	}

	public string[] UserRank
	{
		get { return userrank; }
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}
	protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
	{

	}
	/*
	protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		this.GridView1.PageIndex = e.NewPageIndex;
		BindData();
	} */
	protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
	{

	}
	protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		 string del_username=GridView1.DataKeys[e.RowIndex].Value.ToString();
		 //从数据库中删除此用户
		 myadmin.DeleteUserByName(del_username);
		 WebMessageBox.Show("删除成功","admin_manage.aspx");
	}

	protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		GridView1.EditIndex = -1;/*编辑索引赋值为-1，变回正常显示状态*/
		BindData();
	}

	protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{
		//获取编辑区的新值
		string temp_username = GridView1.DataKeys[e.RowIndex].Value.ToString();
		string temp_useremail=(GridView1.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
		string temp_userphone = (GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
		int temp_userstatus = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text=="已激活"?1:0;
		int temp_useregrank = (GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text=="vip会员"?1:0;
		//WebMessageBox.Show(temp_username + " " + temp_useremail + " " + temp_userphone + " " + temp_userstatus + " " + temp_useregrank);
		//利用新值更新users表
		if (myadmin.EditUserBasicAttributes(temp_username, temp_useremail, temp_userphone, temp_userstatus, temp_useregrank) == 0)
		{
			WebMessageBox.Show("更新成功","admin_manage.aspx");
		}
		else
		{
			WebMessageBox.Show("更新失败","admin_manage.aspx");
		}
	}
	protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
	{
		GridView1.EditIndex = e.NewEditIndex;
        BindData();              /*再次绑定显示编辑行的原数据,不进行绑定要点2次编辑才能跳到编辑状态*/
		//WebMessageBox.Show("修改成功");
	}
}
			
    

	
	
