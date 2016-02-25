﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class user_auth_user_common_user_myprofile_myprofile : System.Web.UI.Page
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
    DateTime birthday =DateTime.Now;
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
        myinfo.UserName = Session["username"].ToString();
        myinfodetail.UserName = Session["username"].ToString();
        if (myinfo.GetUserInfo(myinfo).Tables[0].Rows.Count > 0)
        {
            nickname = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["nickname"].ToString();
            name = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["name"].ToString();
            horoscope = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["horoscope"].ToString();
            sex = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["sex"].ToString();
            age = Convert.ToInt32((myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["age"]));
            salary = Convert.ToInt32(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["salary"]);
            marriage = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["marriage"].ToString();
            degree = myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["degree"].ToString();
            //height = Int32.Parse(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["height"].ToString());
			height = Convert.ToInt32(myinfo.GetUserInfo(myinfo).Tables[0].Rows[0]["height"]);
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
            lovenum = Convert.ToInt32(myinfodetail.GetUserInfoDetail(myinfodetail).Tables[0].Rows[0]["lovenum"]);
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
            addresst.Text = address;
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
    }
    protected void ChangeInfo_Click(object sender, EventArgs e)
    {
        Response.Redirect("edit_profile.aspx");
    }
}