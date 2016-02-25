using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class user_noauth_user_prompt_activation : System.Web.UI.Page
{
	private readonly sql_user myuser = new sql_user();//引用数据库对象，由users表的status判断激活状态
	
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["username"] != null)
		{
			myuser.UserName = Session["username"].ToString();
			//此处判断用户的激活状态并作相应处理
			if (myuser.IsStatusValid(myuser))
			{
				WebMessageBox.Show("用户已激活", "../auth_user/common_user/userdefault.aspx");
			}
			else
			{
				WebMessageBox.Show("用户未激活，请激活","user_active.aspx");//此处需加入第二个参数跳转到用户激活的页面
			}
		}
		else
		{
			Response.Redirect("../../index.aspx");
		}
		
    }
}