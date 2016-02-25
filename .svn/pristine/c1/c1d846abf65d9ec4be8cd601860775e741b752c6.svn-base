using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class actionapply : System.Web.UI.Page
{
    Action participant = new Action();
    Activity activityadd = new Activity();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../index.aspx");
        }
        if (!IsPostBack)
        {
            FindActivity();
        }
    }
    private void FindActivity()
    {
        string sql = "select activityname from activity where activitystatus='未开始'";
        SqlConnection conn = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        activity.DataSource = ds.Tables[0];
        activity.DataTextField = "activityname";
        activity.DataBind();
    }
    protected void apply_button_Click(object sender, EventArgs e)
    {
        participant.UserName = Session["username"].ToString();
        participant.Name = this.name.Text;
        if (male.Checked)
            participant.Sex = "male";
        else
            participant.Sex = "female";
        participant.Email = this.email.Text;
        participant.Telephone = this.telephone.Text;
        participant.AttendActivity = activity.SelectedItem.ToString();
        activityadd.ActivityName = activity.SelectedItem.ToString();
        participant.ParticipantAdd(participant);
        if(participant.ConfirmParticipant(participant)!=null)
        {
            activityadd.AddNumber(activityadd);
            WebMessageBox.Show("报名成功,请关注活动相关邮件和短信", "../index.aspx");
        }
        else
        {
            WebMessageBox.Show("报名失败,请重新报名");
        }
    }
    protected void Activity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}