using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class offlinevalidate : System.Web.UI.Page
{
    OfflineValidate offlinevalidate1 = new OfflineValidate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("index.aspx");
        }
        offlinevalidate1.UserName = Session["username"].ToString();
        if(offlinevalidate1.SearchUser(offlinevalidate1).Tables[0].Rows.Count>0)
        {
            WebMessageBox.Show("你已报名线下认证！", "index.aspx");
        }
    }
    protected void submit_button_Click(object sender, EventArgs e)
    {
        if(this.name.Text==null||this.email.Text==null||this.telephone.Text==null||this.validateaddress.Text==null)
        {
            WebMessageBox.Show("你的信息未填完整！", "offlinevalidate.aspx");
        }
        else
        {
            offlinevalidate1.Name = this.name.Text;
            offlinevalidate1.Email = this.email.Text;
            offlinevalidate1.Telephone = this.telephone.Text;
            offlinevalidate1.ValidateAddress = this.validateaddress.Text;
            offlinevalidate1.AddOfflineUser(offlinevalidate1);
            WebMessageBox.Show("你的线下认证报名成功！", "index.aspx");
        }
    }
}