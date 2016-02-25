﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_auth_user_common_user_myprofile_edit_profile : System.Web.UI.Page
{
    UserInfo myinfo = new UserInfo();
    UserInfoDetail myinfodetail = new UserInfoDetail();
    string nickname = "";
    string name = "";
    string horoscope = "";
    string sex = "";
    int age = 0;
    int salary = 0;
    string marriage = "";
	string birthday ;
    string degree = "";
    int height = 0;
    string address = "";
    string nativeplace = "";
    string weight = "";
    string blood = "";
    string nation = "";
    string animaltype = "";
    string religion = "";
    string hairtype = "";
    string facetype = "";
    string homeif = "";
    string car = "";
    string homeaddress = "";
    string parents = "";
    string homerank = "";
    string childrenif = "";
    string childprotector = "";
    string marrytime = "";
    string marrytype = "";
    string parentsif = "";
    string childif = "";
    string tomarriage = "";
    string smokeif = "";
    string drinkif = "";
    string dailylife = "";
    string housework = "";
    string cook = "";
    string petif = "";
    string deposit = "";
    string singletime = "";
    int lovenum = 0;
    string why = "";
    string reason = "";
    string keep = "";
    string trip = "";
    string activity = "";
    string booktype = "";
    string movie = "";
    string book = "";
    string music = "";
    string media = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../../../../index.aspx");
        }
        if (!Page.IsPostBack)
        {
            myinfo.UserName = Session["username"].ToString();
            myinfodetail.UserName = Session["username"].ToString();
            FindProvince();
            FindCity(Province.SelectedItem.Value);
            FindDistrict(City.SelectedItem.Value);
            if (myinfo.GetUserInfo(myinfo).Tables[0].Rows.Count > 0)
            {
                nickname = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["nickname"].ToString();
                name = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["name"].ToString();
                horoscope = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["horoscope"].ToString();
                sex = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["sex"].ToString();
                age = Int32.Parse(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["age"].ToString());
                salary = Int32.Parse(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["salary"].ToString());
                marriage = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["marriage"].ToString();
                degree = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["degree"].ToString();
                height = Int32.Parse(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["height"].ToString());
                address = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["address"].ToString();
                nativeplace = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["nativeplace"].ToString();
                weight = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["weight"].ToString();
                blood = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["blood"].ToString();
                nation = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["nation"].ToString();
                animaltype = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["animaltype"].ToString();
                religion = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["religion"].ToString();
                hairtype = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["hairtype"].ToString();
                facetype = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["facetype"].ToString();
                homeif = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["homeif"].ToString();
                car = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["car"].ToString();

                homeaddress = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["homeaddress"].ToString();
                parents = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["parents"].ToString();
                homerank = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["homerank"].ToString();
                childrenif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["childrenif"].ToString();
                childprotector = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["childprotector"].ToString();
                marrytime = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["marrytime"].ToString();
                marrytype = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["marrytype"].ToString();
                parentsif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["parentsif"].ToString();
                childif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["childif"].ToString();
                tomarriage = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["tomarriage"].ToString();
                smokeif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["smokeif"].ToString();
                drinkif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["drinkif"].ToString();
                dailylife = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["dailylife"].ToString();
                housework = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["housework"].ToString();
                cook = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["cook"].ToString();
                petif = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["petif"].ToString();
                deposit = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["deposit"].ToString();
                singletime = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["singletime"].ToString();
                lovenum = Int32.Parse(myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["lovenum"].ToString());
                why = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["why"].ToString();
                reason = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["reason"].ToString();
                keep = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["keep"].ToString();
                trip = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["trip"].ToString();
                activity = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["activity"].ToString();
                booktype = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["booktype"].ToString();
                movie = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["movie"].ToString();
                book = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["book"].ToString();
                music = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["music"].ToString();
                media = myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["media"].ToString();

                nicknamet.Text = nickname;
                namet.Text = name;
                horoscopet.Text = horoscope;
                sext.Text = sex;
                aget.Text = Convert.ToString(age);
                salaryt.Text = Convert.ToString(salary);
                marriaget.Text = marriage;
                degreet.Text = degree;
                heightt.Text = Convert.ToString(height);
                nativeplacet.Text = nativeplace;
                weightt.Text = weight;
                bloodt.Text = blood;
                nationt.Text = nation;
                animaltypet.Text = animaltype;
                religiont.Text = religion;
                hairtypet.Text = hairtype;
                facetypet.Text = facetype;
                homeift.Text = homeif;
                cart.Text = car;

                homeaddresst.Text = homeaddress;
                parentst.Text = parents;
                homerankt.Text = homerank;
                childrenift.Text = childrenif;
                childprotectort.Text = childprotector;
                marrytimet.Text = marrytime;
                marrytypet.Text = marrytype;
                parentsift.Text = parentsif;
                childift.Text = childif;
                tomarriaget.Text = tomarriage;
                smokeift.Text = smokeif;
                drinkift.Text = drinkif;
                dailylifet.Text = dailylife;
                houseworkt.Text = housework;
                cookt.Text = cook;
                petift.Text = petif;
                depositt.Text = deposit;
                singletimet.Text = singletime;
                lovenumt.Text = Convert.ToString(lovenum);
                whyt.Text = why;
                reasont.Text = reason;
                keept.Text = keep;
                tript.Text = trip;
                activityt.Text = activity;
                booktypet.Text = booktype;
                moviet.Text = movie;
                bookt.Text = book;
                musict.Text = music;
                mediat.Text = media;

            }
            else
            {
                lovenumt.Text = "0";
            }
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
    protected void submit_Click(object sender, EventArgs e)
    {
        myinfo.UserName = Session["username"].ToString();
        myinfodetail.UserName = Session["username"].ToString();
        myinfo.NickName = this.nicknamet.Text;
        myinfo.Name = this.namet.Text;
        myinfo.Horoscope = this.horoscopet.Text;
        myinfo.Sex = this.sext.Text;
        myinfo.Age = Convert.ToInt32(this.aget.Text);
        myinfo.Salary = Convert.ToInt32(this.salaryt.Text);
        myinfo.Marriage = this.marriaget.Text;
        myinfo.Degree = this.degreet.Text;
        myinfo.Height = Convert.ToInt32(this.heightt.Text);
        myinfo.Address = Province.SelectedItem.ToString()+"-"+City.SelectedItem.ToString()+"-"+District.SelectedItem.ToString()+"-"+this.AddressDetail.Text;
        myinfo.NativePlace = this.nativeplacet.Text;
		myinfo.Weight = Convert.ToInt32(this.weightt.Text);
        myinfo.Blood = this.bloodt.Text;
        myinfo.Nation = this.nationt.Text;
        myinfo.AnimalType = this.animaltypet.Text;
        myinfo.Religion = this.religiont.Text;
        myinfo.HairType = this.hairtypet.Text;
        myinfo.FaceType = this.facetypet.Text;
        myinfo.HomeIf = this.homeift.Text;
        myinfo.Car = this.cart.Text;
        //myinfo.Birthday = birthday;

        myinfodetail.HomeAddress = this.homeaddresst.Text;
        myinfodetail.Parents = this.parentst.Text;
        myinfodetail.HomeRank = this.homerankt.Text;
        myinfodetail.ChildrenIf = this.childrenift.Text;
        myinfodetail.ChildProtector = this.childprotectort.Text;
        myinfodetail.MarryTime = this.marrytimet.Text;
        myinfodetail.MarryType = this.marrytypet.Text;
        myinfodetail.ParentsIf = this.parentsift.Text;
        myinfodetail.ChildIf = this.childift.Text;
        myinfodetail.ToMarriage = this.tomarriaget.Text;
        myinfodetail.SmokeIf = this.smokeift.Text;
        myinfodetail.DrinkIf = this.drinkift.Text;
        myinfodetail.DailyLife = this.dailylifet.Text;
        myinfodetail.HouseWork = this.houseworkt.Text;
        myinfodetail.Cook = this.cookt.Text;
        myinfodetail.PetIf = this.petift.Text;
        myinfodetail.Deposit = this.depositt.Text;
        myinfodetail.SingleTime = this.singletimet.Text;
        myinfodetail.LoveNum = Convert.ToInt32(this.lovenumt.Text);
        myinfodetail.Why = this.whyt.Text;
        myinfodetail.Reason = this.reasont.Text;
        myinfodetail.Keep = this.keept.Text;
        myinfodetail.Trip = this.tript.Text;
        myinfodetail.Activity = this.activityt.Text;
        myinfodetail.BookType = this.booktypet.Text;
        myinfodetail.Movie = this.moviet.Text;
        myinfodetail.Book = this.bookt.Text;
        myinfodetail.Music = this.musict.Text;
        myinfodetail.Media = this.mediat.Text;

        if(myinfo.GetUserInfo(myinfo).Tables[0].Rows.Count<=0)
        {
            myinfo.InsertUserInfo(myinfo);
            myinfodetail.InsertUserInfoDetail(myinfodetail);
        }
        else
        {
            myinfo.ChangeUserInfo(myinfo);
            myinfodetail.ChangeUserInfoDetail(myinfodetail);
        }
        Response.Redirect("myprofile.aspx");
    }
}