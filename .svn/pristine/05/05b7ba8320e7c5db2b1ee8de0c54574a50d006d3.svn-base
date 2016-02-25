using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_chat_content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		int peopleCurrent = Int32.Parse(Application["current"].ToString());
		Application.Lock();
		string strChats = Application["chats"].ToString();
		string[] strChat = strChats.Split(',');
		for (int i = strChat.Length - 1; i >= 0; i--)
		{
			if (peopleCurrent == 0)
			{
				txtContent.Text = strChat[i].ToString();
			}
			else
			{
				txtContent.Text = txtContent.Text + "\n" + strChat[i].ToString();
			}
		}
		Application.UnLock();
    }
}