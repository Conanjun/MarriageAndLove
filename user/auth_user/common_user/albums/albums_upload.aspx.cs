﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_auth_user_common_user_albums_albums_upload : System.Web.UI.Page
{
    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../../../../index.aspx");
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        username = Session["username"].ToString();
        string name = fulFile.PostedFile.FileName;//获取文件名称
        int index = name.LastIndexOf(".");
        string lastName = name.Substring(index, name.Length - index);//文件后缀
        string newname = username+"/"+username+"-"+DateTime.Now.ToString("yyyyMMddhhmmss") + lastName;//新文件名
        string addpath = username + "/";
        string path = Server.MapPath("~/user/auth_user/common_user/albums/upload/" + addpath);
        if (this.fulFile.HasFile)
        {
            string fileException = System.IO.Path.GetExtension(fulFile.FileName).ToLower();

            if (fileException.Equals(".jpg")||fileException.Equals(".png")||fileException.Equals(".bmp"))
            {
                if (!System.IO.Directory.Exists(path))//判断文件夹是否已经存在
                {
                    System.IO.Directory.CreateDirectory(path);//创建文件夹
                }
                path = Server.MapPath("~/user/auth_user/common_user/albums/upload/" + newname);
                this.fulFile.SaveAs(path);
                WebMessageBox.Show("上传成功","albums.aspx");
            }
            else
            {
                Response.Write("<script>alert(’上传失败!仅支持JPG、PNG、BMP格式的图片’);</script>");
            }
        }
        else
        {
            Response.Write("<script>alert(’请选择文件!’);</script>");
        }
    }
}