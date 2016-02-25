using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class actionevaluate : System.Web.UI.Page
{
    Action evaluated = new Action();
    string username = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../index.aspx");
        }
        else
        {
            evaluated.UserName = Session["username"].ToString();
            username = Session["username"].ToString();
            if (evaluated.JudgeParticipant(evaluated).Tables[0].Rows.Count <=0)
            {
                Response.Redirect("../index.aspx");
            }
        }
        if(!IsPostBack)
        {
            UserAttend();
        }
    }
    private void UserAttend()
    {
        activity.DataSource = evaluated.GetAttendActivity(evaluated).Tables[0];
        activity.DataTextField = "attendactivity";
        activity.DataBind();
    }
    protected void submit_button_Click(object sender, EventArgs e)
    {
        evaluated.Evaluation = this.TextBox1.Text;
        evaluated.AttendActivity = activity.SelectedItem.ToString();
        int i = evaluated.EvaluationInsert(evaluated);
        if(i==0)
        {
            WebMessageBox.Show("评价成功,感谢您对我们的大力支持", "../index.aspx");
        }
        else
        {
            WebMessageBox.Show("评价失败");
        }
    }
}