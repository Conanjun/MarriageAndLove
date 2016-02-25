using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class register_emailvalidate : System.Web.UI.Page
{
	EmailOrPhoneActive active = new EmailOrPhoneActive();
	sql_user activeuser = new sql_user();
    protected void Page_Load(object sender, EventArgs e)
    {
		active.UserName = Request.QueryString["username"];
		active.ActiveCode = Request.QueryString["activecode"];
		activeuser.UserName = Request.QueryString["username"];
		if(active.EmailActiveSelect(active).Tables[0].Rows.Count>0)
        {
			if (activeuser.UpdateUserStatus(activeuser) == 0)
			{
				active.EmailActiveDelete(active);//从activecode表中删除记录
				WebMessageBox.Show("激活成功", "../user/auth_user/common_user/userdefault.aspx");
			}else{
					WebMessageBox.Show("激活失败","../index.aspx");
				}
			}
            
        }
    
}