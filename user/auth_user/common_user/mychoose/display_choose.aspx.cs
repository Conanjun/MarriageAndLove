using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_mychoose_display_choose : System.Web.UI.Page
{

    choose choose = new choose();
    string username = "";//用户名
    string csex = "";//性别
    string option1 = "";//家庭背景
    string option2 = "";//是否介意婚前公证财产
    string option3 = "";//是否介意经常跟好朋友出去玩
    string option4 = "";//最关注对方什么条件
    string option5 = "";//最不能忍受对方的缺点
    string option6 = "";//是否介意抽烟喝酒
    string option7 = "";//是否要小孩
    string option8 = "";//你是个浪漫的人吗
    string option9 = "";//婚后理财规划
    string option10 = "";//家务如何分配
    string option11 = "";//消费观
    string option12 = "";//如果有外遇

    int age = 0;//年龄
    string marriagestatus = "";//婚姻状况
    string degree = "";//学历
    int height = 0;//身高
    string locationarea = "";//所在地区
    string ishasimage = "";//是否有图片
    int salary = 0;//薪水
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../../../../index.aspx");
        }
        if (!Page.IsPostBack)
        {
            choose.Username = Session["username"].ToString();
            if (choose.SelectChoose(choose).Tables[0].Rows.Count > 0)
            {
                //基本择偶要求
                csex = choose.SelectChoose(choose).Tables[0].Rows[0]["csex"].ToString();
                age = Int32.Parse(choose.SelectChoose(choose).Tables[0].Rows[0]["age"].ToString());
                marriagestatus = choose.SelectChoose(choose).Tables[0].Rows[0]["marriagestatus"].ToString();
                degree = choose.SelectChoose(choose).Tables[0].Rows[0]["degree"].ToString();
                height = Int32.Parse(choose.SelectChoose(choose).Tables[0].Rows[0]["height"].ToString());
                locationarea = choose.SelectChoose(choose).Tables[0].Rows[0]["locationarea"].ToString();
                ishasimage = choose.SelectChoose(choose).Tables[0].Rows[0]["ishasimage"].ToString();
                salary = Int32.Parse(choose.SelectChoose(choose).Tables[0].Rows[0]["salary"].ToString());

                //详细择偶要求
                option1 = choose.SelectChoose(choose).Tables[0].Rows[0]["option1"].ToString();
                option2 = choose.SelectChoose(choose).Tables[0].Rows[0]["option2"].ToString();
                option3 = choose.SelectChoose(choose).Tables[0].Rows[0]["option3"].ToString();
                option4 = choose.SelectChoose(choose).Tables[0].Rows[0]["option4"].ToString();
                option5 = choose.SelectChoose(choose).Tables[0].Rows[0]["option5"].ToString();
                option6 = choose.SelectChoose(choose).Tables[0].Rows[0]["option6"].ToString();
                option7 = choose.SelectChoose(choose).Tables[0].Rows[0]["option7"].ToString();
                option8 = choose.SelectChoose(choose).Tables[0].Rows[0]["option8"].ToString();
                option9 = choose.SelectChoose(choose).Tables[0].Rows[0]["option9"].ToString();
                option10 = choose.SelectChoose(choose).Tables[0].Rows[0]["option10"].ToString();
                option11 = choose.SelectChoose(choose).Tables[0].Rows[0]["option11"].ToString();
                option12 = choose.SelectChoose(choose).Tables[0].Rows[0]["option12"].ToString();

                //输入Text
                csext.Text = csex;
                aget.Text = age.ToString();
                marriagestatust.Text = marriagestatus;
                degreet.Text = degree;
                locationareat.Text = locationarea;
                heightt.Text = height.ToString();
                ishasimaget.Text = ishasimage;
                salaryt.Text = salary.ToString();
                option1t.Text = option1;
                option2t.Text = option2;
                option3t.Text = option3;
                option4t.Text = option4;
                option5t.Text = option5;
                option6t.Text = option6;
                option7t.Text = option7;
                option8t.Text = option8;
                option9t.Text = option9;
                option10t.Text = option10;
                option11t.Text = option11;
                option12t.Text = option12;
            }
        }
    }
    protected void ToUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("update_choose.aspx");
    }
}