using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// userinfo 的摘要说明
/// </summary>
public class UserInfo
{

	string username = "";
	string nickname = "";
	string name = "";
	string horoscope = "";
	string sex = ""; 
	int age = 0;
	int salary = 0;
	string marriage = "";
	//string birthday;//以 2000-01-01这种形式存储
	string degree = "";
	int height = 0;
	string address = "";
	string nativeplace = "";
	int weight;
	string blood = "";
	string nation = "";
	string animaltype = "";
	string religion = "";
	string hairtype = "";
	string facetype = "";
	string homeif = "";
	string car = "";
	string option2;
	string option3;
	string option6;
	string option7;
	string option8;

	public string UserName
	{
		get { return username; }
		set { username = value; }
	}
	public string NickName
	{
		get { return nickname; }
		set { nickname = value; }
	}
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public string Horoscope
	{
		get { return horoscope; }
		set { horoscope = value; }
	}
	public string Sex
	{
		get { return sex; }
		set { sex = value; }
	}
	public int Age
	{
		get { return age; }
		set { age = value; }
	}
	public int Salary
	{
		get { return salary; }
		set { salary = value; }
	}
	public string Marriage
	{
		get { return marriage; }
		set { marriage = value; }
	}
	
	public string Degree
	{
		get { return degree; }
		set { degree = value; }
	}
	public int Height
	{
		get { return height; }
		set { height = value; }
	}
	public string Address
	{
		get { return address; }
		set { address = value; }
	}
	public string NativePlace
	{
		get { return nativeplace; }
		set { nativeplace = value; }
	}
	public int Weight
	{
		get { return weight; }
		set { weight = value; }
	}
	public string Blood
	{
		get { return blood; }
		set { blood = value; }
	}
	public string Nation
	{
		get { return nation; }
		set { nation = value; }
	}
	public string AnimalType
	{
		get { return animaltype; }
		set { animaltype = value; }
	}
	public string Religion
	{
		get { return religion; }
		set { religion = value; }
	}
	public string HairType
	{
		get { return hairtype; }
		set { hairtype = value; }
	}
	public string FaceType
	{
		get { return facetype; }
		set { facetype = value; }
	}
	public string HomeIf
	{
		get { return homeif; }
		set { homeif = value; }
	}
	public string Car
	{
		get { return car; }
		set { car = value; }
	}
	public string Option6
	{
		get { return option6; }
		set { option6 = value; }
	}
	public string Option2
	{
		get { return option2; }
		set { option2 = value; }
	}
	public string Option3
	{
		get { return option3; }
		set { option3 = value; }
	}
	
	public string Option7
	{
		get { return option7; }
		set { option7 = value; }
	}
	public string Option8
	{
		get { return option2; }
		set { option8 = value; }
	}
	private readonly DataBase data = new DataBase();

	public DataSet GetUserInfo(UserInfo userinfo)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfo.UserName),
            };
		return
			data.RunProcReturn(
				"SELECT * FROM userinfo WHERE username = @UserName", parms,
				"userinfo");
	}

	//返回除用户本身外的其他会员的信息
	public DataSet GetOtherUserAddress(UserInfo userinfo)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfo.UserName),
            };
		return
			data.RunProcReturn(
				"SELECT * FROM userinfo WHERE username not in (select username from userinfo where username= @UserName)", parms,
				"userinfo");
	}

	public int InsertUserInfo(UserInfo userinfo)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfo.UserName),
                data.MakeInParam("@NickName", SqlDbType.VarChar, 50, userinfo.NickName),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, userinfo.Name),
                data.MakeInParam("@Horoscope", SqlDbType.VarChar, 50, userinfo.Horoscope),
                data.MakeInParam("@Sex", SqlDbType.VarChar, 10, userinfo.Sex),
                data.MakeInParam("@Age", SqlDbType.Int, 32, userinfo.Age),
                data.MakeInParam("@Salary", SqlDbType.Int, 32, userinfo.Salary),
                data.MakeInParam("@Marriage", SqlDbType.VarChar, 50, userinfo.Marriage),
              //  data.MakeInParam("@Birthday", SqlDbType.VarChar, 50, userinfo.Birthday),
                data.MakeInParam("@Degree", SqlDbType.VarChar, 50, userinfo.Degree),
                data.MakeInParam("@Height", SqlDbType.Int, 32, userinfo.Height),
                data.MakeInParam("@Address", SqlDbType.VarChar, 100, userinfo.Address),
                data.MakeInParam("@NativePlace", SqlDbType.VarChar, 100, userinfo.NativePlace),
                data.MakeInParam("@Weight", SqlDbType.Int, 50, userinfo.Weight),
                data.MakeInParam("@Blood", SqlDbType.VarChar, 50, userinfo.Blood),
                data.MakeInParam("@Nation", SqlDbType.VarChar, 50, userinfo.Nation),
                data.MakeInParam("@AnimalType", SqlDbType.VarChar, 50, userinfo.AnimalType),
                data.MakeInParam("@Religion", SqlDbType.VarChar, 50, userinfo.Religion),
                data.MakeInParam("@HairType", SqlDbType.VarChar, 50, userinfo.HairType),
                data.MakeInParam("@FaceType", SqlDbType.VarChar, 50, userinfo.FaceType),
                data.MakeInParam("@HomeIf", SqlDbType.VarChar, 50, userinfo.HomeIf),
                data.MakeInParam("@Car", SqlDbType.VarChar, 50, userinfo.Car),
            };
		return
			data.RunProc("insert into userinfo(username,nickname,name,horoscope,sex,age,salary,marriage,degree,height,address,nativeplace,weight,blood,nation,animaltype,religion,hairtype,facetype,homeif,car) values(@UserName,@NickName,@Name,@Horoscope,@Sex,@Age,@Salary,@Marriage,@Degree,@Height,@Address,@NativePlace,@Weight,@Blood,@Nation,@AnimalType,@Religion,@HairType,@FaceType,@HomeIf,@Car)", parms);
	}

	public int ChangeUserInfo(UserInfo userinfo)
	{
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfo.UserName),
                data.MakeInParam("@NickName", SqlDbType.VarChar, 50, userinfo.NickName),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, userinfo.Name),
                data.MakeInParam("@Horoscope", SqlDbType.VarChar, 50, userinfo.Horoscope),
                data.MakeInParam("@Sex", SqlDbType.VarChar, 10, userinfo.Sex),
                data.MakeInParam("@Age", SqlDbType.Int, 32, userinfo.Age),
                data.MakeInParam("@Salary", SqlDbType.Int, 32, userinfo.Salary),
                data.MakeInParam("@Marriage", SqlDbType.VarChar, 50, userinfo.Marriage),
              //  data.MakeInParam("@Birthday", SqlDbType.DateTime, 50, userinfo.Birthday),
                data.MakeInParam("@Degree", SqlDbType.VarChar, 50, userinfo.Degree),
                data.MakeInParam("@Height", SqlDbType.Int, 32, userinfo.Height),
                data.MakeInParam("@Address", SqlDbType.VarChar, 100, userinfo.Address),
                data.MakeInParam("@NativePlace", SqlDbType.VarChar, 100, userinfo.NativePlace),
                data.MakeInParam("@Weight", SqlDbType.Int, 50, userinfo.Weight),
                data.MakeInParam("@Blood", SqlDbType.VarChar, 50, userinfo.Blood),
                data.MakeInParam("@Nation", SqlDbType.VarChar, 50, userinfo.Nation),
                data.MakeInParam("@AnimalType", SqlDbType.VarChar, 50, userinfo.AnimalType),
                data.MakeInParam("@Religion", SqlDbType.VarChar, 50, userinfo.Religion),
                data.MakeInParam("@HairType", SqlDbType.VarChar, 50, userinfo.HairType),
                data.MakeInParam("@FaceType", SqlDbType.VarChar, 50, userinfo.FaceType),
                data.MakeInParam("@HomeIf", SqlDbType.VarChar, 50, userinfo.HomeIf),
                data.MakeInParam("@Car", SqlDbType.VarChar, 50, userinfo.Car),
            };
		return data.RunProc("update userinfo set nickname=@NickName,name=@Name,horoscope=@Horoscope,sex=@Sex,age=@Age,salary=@Salary,marriage=@Marriage,degree=@Degree,height=@Height,address=@Address,nativeplace=@NativePlace,weight=@Weight,blood=@Blood,nation=@Nation,animaltype=@AnimalType,religion=@Religion,hairtype=@HairType,facetype=@FaceType,homeif=@HomeIf,car=@Car WHERE username = @UserName", parms);
	}

	public UserInfo()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

}