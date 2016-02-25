﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class user_auth_user_common_user_albums_albums : System.Web.UI.Page
{
    string username;
    string addpath;
    string path;
    string[] temp = null;
    int imagecount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../../../../index.aspx");
        }
        username = Session["username"].ToString();
        addpath = username + "/";
        path = Server.MapPath("~/user/auth_user/common_user/albums/upload/" + addpath);
        DirectoryInfo dinfo = new DirectoryInfo(path);
        if (dinfo.Exists)
        {
            FileInfo[] finfo = dinfo.GetFiles();
            temp = new string[finfo.Length];
            imagecount = finfo.Length;
            for (int i = 0; i < finfo.Length; i++)
                temp[i] = finfo[i].Name;
        }
    }
    public String[] imagename
    {
        get {return temp; }
    }
    public string user
    {
        get { return username; }
    }
    public int count
    {
        get { return imagecount; }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("albums_upload.aspx");
    }
}