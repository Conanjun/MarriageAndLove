using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// offlinevalidate 的摘要说明
/// </summary>
public class OfflineValidate
{
    string username="";
    string name="";
    string email="";
    string telephone="";
    string validateaddress="";

    public string UserName
    {
        get { return username; }
        set { username = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string Telephone
    {
        get { return telephone; }
        set { telephone = value; }
    }
    public string ValidateAddress
    {
        get { return validateaddress; }
        set { validateaddress = value; }
    }

    private readonly DataBase data = new DataBase();

    public DataSet SearchUser(OfflineValidate offlinevalidate)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, offlinevalidate.UserName),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, offlinevalidate.Name),
                data.MakeInParam("@Email", SqlDbType.VarChar, 50, offlinevalidate.Email),
                data.MakeInParam("@Telephone", SqlDbType.VarChar, 50, offlinevalidate.Telephone),
                data.MakeInParam("@ValidateAddress", SqlDbType.VarChar, 100, offlinevalidate.ValidateAddress),
            };
        return
            data.RunProcReturn(
                "SELECT * FROM offlinevalidate WHERE username = @UserName", parms,
                "offlinevalidate");
    }

    public int AddOfflineUser(OfflineValidate offlinevalidate)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, offlinevalidate.UserName),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, offlinevalidate.Name),
                data.MakeInParam("@Email", SqlDbType.VarChar, 50, offlinevalidate.Email),
                data.MakeInParam("@Telephone", SqlDbType.VarChar, 50, offlinevalidate.Telephone),
                data.MakeInParam("@ValidateAddress", SqlDbType.VarChar, 100, offlinevalidate.ValidateAddress),
            };
        return
            data.RunProc(
                "insert into offlinevalidate (username,name,email,telephone,validateaddress) values (@UserName,@Name,@Email,@Telephone,@ValidateAddress)", parms);
    }
	public OfflineValidate()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}