using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_mymessage_delete_msg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = Request.QueryString["username"];
        string msg = Request.QueryString["msg"];
        string time = Request.QueryString["time"];
        string sendpeople = Request.QueryString["sendpeople"];

        msg mymsg = new msg();
        mymsg.RecvUsername = username;
        mymsg.SendUsername = sendpeople;
        mymsg.Message = msg;
        mymsg.DateTime = Convert.ToDateTime(time);

        if (mymsg.MessageDelete(mymsg) == 0)
        {
            WebMessageBox.Show("设置成功", "mymessage.aspx");
        }
    }
}