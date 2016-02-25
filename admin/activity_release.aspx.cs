using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_activity_release : System.Web.UI.Page
{
    string[] ActivityList=null;
    string[] ActivityTime = null;
    string[] ActivityPlace = null;
    int[] ActivityJoinNum = null;
    string[] ActivityStatus = null;
    int ActivityCount = 0;
    Activity GetActivity = new Activity();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FindProvince();
            FindCity(Province.SelectedItem.Value);
            FindDistrict(City.SelectedItem.Value);
        }
        ActivityCount = GetActivity.GetAllActivity(GetActivity).Tables[0].Rows.Count;
        ActivityList = new string[ActivityCount];
        ActivityTime = new string[ActivityCount];
        ActivityPlace = new string[ActivityCount];
        ActivityJoinNum = new int[ActivityCount];
        ActivityStatus = new string[ActivityCount];
        for(int i=0;i<ActivityCount;i++)
        {
            ActivityList[i] = GetActivity.GetAllActivity(GetActivity).Tables[0].Rows[i]["activityname"].ToString();
            ActivityTime[i] = GetActivity.GetAllActivity(GetActivity).Tables[0].Rows[i]["activitytime"].ToString();
            ActivityPlace[i] = GetActivity.GetAllActivity(GetActivity).Tables[0].Rows[i]["activityplace"].ToString();
            ActivityJoinNum[i] = Convert.ToInt32(GetActivity.GetAllActivity(GetActivity).Tables[0].Rows[i]["joinnumber"]);
            ActivityStatus[i] = GetActivity.GetAllActivity(GetActivity).Tables[0].Rows[i]["activitystatus"].ToString();
        }
    }
    private void FindProvince()
    {
        string sql = "select ProSort,ProName from T_Province";
        SqlConnection conn = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        Province.DataSource = ds.Tables[0];
        Province.DataValueField = "ProSort";
        Province.DataTextField = "ProName";
        Province.DataBind();
    }
    private void FindCity(string ProSort)
    {
        string provinceCode = ProSort;
        string sql = "select CitySort,CityName from T_City where ProID='" + provinceCode + "'";
        SqlConnection conn = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        City.DataSource = ds.Tables[0];
        City.DataValueField = "CitySort";
        City.DataTextField = "CityName";
        City.DataBind();
    }

    private void FindDistrict(string CitySort)
    {
        string cityCode = CitySort;
        string sql = "select ID,DisName from T_District where CityID='" + cityCode + "'";
        SqlConnection conn = new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        District.DataSource = ds.Tables[0];
        District.DataValueField = "ID";
        District.DataTextField = "DisName";
        District.DataBind();
    }
    protected void City_SelectedIndexChanged(object sender, EventArgs e)
    {
        FindDistrict(City.SelectedItem.Value);
    }

    protected void Province_SelectedIndexChanged(object sender, EventArgs e)
    {
        FindCity(Province.SelectedItem.Value);
        FindDistrict(City.SelectedItem.Value);
    }
    protected void release_button_Click(object sender, EventArgs e)
    {
        Activity activity = new Activity();
        activity.ActivityName = this.activityname.Text;
        activity.ActivityTime = this.activitytime.Text;
        activity.ActivityPlace = Province.SelectedItem.ToString() + "-" + City.SelectedItem.ToString() + "-" + District.SelectedItem.ToString() + "-" + this.activityplace.Text;
        activity.ActivityIntroduction = this.activityintroduction.Text;
        activity.JoinNumber = 0;
        activity.ActivityStatus = "未开始";
        activity.InsertActivity(activity);
    }
    public string[] activitylist
    {
        get { return ActivityList; }
    }
    public string[] activitytimelist
    {
        get { return ActivityTime; }
    }
    public string[] activityplacelist
    {
        get { return ActivityPlace; }
    }
    public int[] activityjoinnumlist
    {
        get { return ActivityJoinNum; }
    }
    public string[] activitystatuslist
    {
        get { return ActivityStatus; }
    }
    public int activitycount
    {
        get { return ActivityCount; }
    }
}

