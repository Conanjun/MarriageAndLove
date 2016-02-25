using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// userinfodetail 的摘要说明
/// </summary>
public class UserInfoDetail
{
	string username = "";
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

	public string UserName
	{
		get { return username; }
		set { username = value; }
	}
	public string HomeAddress
	{
		get { return homeaddress; }
		set { homeaddress = value; }
	}
	public string Parents
	{
		get { return parents; }
		set { parents = value; }
	}
	public string HomeRank
	{
		get { return homerank; }
		set { homerank = value; }
	}
	public string ChildrenIf
	{
		get { return childrenif; }
		set { childrenif = value; }
	}
	public string ChildProtector
	{
		get { return childprotector; }
		set { childprotector = value; }
	}
	public string MarryTime
	{
		get { return marrytime; }
		set { marrytime = value; }
	}
	public string MarryType
	{
		get { return marrytype; }
		set { marrytype = value; }
	}
	public string ParentsIf
	{
		get { return parentsif; }
		set { parentsif = value; }
	}
	public string ChildIf
	{
		get { return childif; }
		set { childif = value; }
	}
	public string ToMarriage
	{
		get { return tomarriage; }
		set { tomarriage = value; }
	}
	public string SmokeIf
	{
		get { return smokeif; }
		set { smokeif = value; }
	}
	public string DrinkIf
	{
		get { return drinkif; }
		set { drinkif = value; }
	}
	public string DailyLife
	{
		get { return dailylife; }
		set { dailylife = value; }
	}
	public string HouseWork
	{
		get { return housework; }
		set { housework = value; }
	}
	public string Cook
	{
		get { return cook; }
		set { cook = value; }
	}
	public string PetIf
	{
		get { return petif; }
		set { petif = value; }
	}
	public string Deposit
	{
		get { return deposit; }
		set { deposit = value; }
	}
	public string SingleTime
	{
		get { return singletime; }
		set { singletime = value; }
	}
	public int LoveNum
	{
		get { return lovenum; }
		set { lovenum = value; }
	}
	public string Why
	{
		get { return why; }
		set { why = value; }
	}
	public string Reason
	{
		get { return reason; }
		set { reason = value; }
	}
	public string Keep
	{
		get { return keep; }
		set { keep = value; }
	}
	public string Trip
	{
		get { return trip; }
		set { trip = value; }
	}
	public string Activity
	{
		get { return activity; }
		set { activity = value; }
	}
	public string BookType
	{
		get { return booktype; }
		set { booktype = value; }
	}
	public string Movie
	{
		get { return movie; }
		set { movie = value; }
	}
	public string Book
	{
		get { return book; }
		set { book = value; }
	}
	public string Music
	{
		get { return music; }
		set { music = value; }
	}
	public string Media
	{
		get { return media; }
		set { media = value; }
	}

	private readonly DataBase data = new DataBase();

	public DataSet GetUserInfoDetail(UserInfoDetail userinfodetail)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfodetail.UserName),
            };
		return
			data.RunProcReturn(
				"SELECT * FROM userinfodetail WHERE username = @UserName", parms,
				"userinfo");
	}

	public int InsertUserInfoDetail(UserInfoDetail userinfodetail)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfodetail.UserName),
                data.MakeInParam("@HomeAddress", SqlDbType.VarChar, 100, userinfodetail.HomeAddress),
                data.MakeInParam("@Parents", SqlDbType.VarChar, 50, userinfodetail.Parents),
                data.MakeInParam("@HomeRank", SqlDbType.VarChar, 50, userinfodetail.HomeRank),
                data.MakeInParam("@ChildrenIf", SqlDbType.VarChar, 50, userinfodetail.ChildrenIf),
                data.MakeInParam("@ChildProtector", SqlDbType.VarChar, 50, userinfodetail.ChildProtector),
                data.MakeInParam("@MarryTime", SqlDbType.VarChar, 50, userinfodetail.MarryTime),
                data.MakeInParam("@MarryType", SqlDbType.VarChar, 50, userinfodetail.MarryType),
                data.MakeInParam("@ParentsIf", SqlDbType.VarChar, 50, userinfodetail.ParentsIf),
                data.MakeInParam("@ChildIf", SqlDbType.VarChar, 50, userinfodetail.ChildIf),
                data.MakeInParam("@ToMarriage", SqlDbType.VarChar, 50, userinfodetail.ToMarriage),
                data.MakeInParam("@SmokeIf", SqlDbType.VarChar, 50, userinfodetail.SmokeIf),
                data.MakeInParam("@DrinkIf", SqlDbType.VarChar, 50, userinfodetail.DrinkIf),
                data.MakeInParam("@DailyLife", SqlDbType.VarChar, 50, userinfodetail.DailyLife),
                data.MakeInParam("@HouseWork", SqlDbType.VarChar, 50, userinfodetail.HouseWork),
                data.MakeInParam("@Cook", SqlDbType.VarChar, 50, userinfodetail.Cook),
                data.MakeInParam("@PetIf", SqlDbType.VarChar, 50, userinfodetail.PetIf),
                data.MakeInParam("@Deposit", SqlDbType.VarChar, 50, userinfodetail.Deposit),
                data.MakeInParam("@SingleTime", SqlDbType.VarChar, 50, userinfodetail.SingleTime),
                data.MakeInParam("@LoveNum", SqlDbType.Int, 32, userinfodetail.LoveNum),
                data.MakeInParam("@Why", SqlDbType.VarChar, 50, userinfodetail.Why),
                data.MakeInParam("@Reason", SqlDbType.VarChar, 50, userinfodetail.Reason),
                data.MakeInParam("@Keep", SqlDbType.VarChar, 50, userinfodetail.Keep),
                data.MakeInParam("@Trip", SqlDbType.VarChar, 50, userinfodetail.Trip),
                data.MakeInParam("@Activity", SqlDbType.VarChar, 50, userinfodetail.Activity),
                data.MakeInParam("@BookType", SqlDbType.VarChar, 50, userinfodetail.BookType),
                data.MakeInParam("@Movie", SqlDbType.VarChar, 50, userinfodetail.Movie),
                data.MakeInParam("@Book", SqlDbType.VarChar, 50, userinfodetail.Book),
                data.MakeInParam("@Music", SqlDbType.VarChar, 100, userinfodetail.Music),
                data.MakeInParam("@Media", SqlDbType.VarChar, 100, userinfodetail.Media),
            };
		return
			data.RunProc("INSERT INTO userinfodetail(username,homeaddress,parents,homerank,childrenif,childprotector,marrytime,marrytype,parentsif,childif,tomarriage,smokeif,drinkif,dailylife,housework,cook,petif,deposit,singletime,lovenum,why,reason,keep,trip,activity,booktype,movie,book,music,media) VALUES (@UserName,@HomeAddress,@Parents,@HomeRank,@ChildrenIf,@ChildProtector,@MarryTime,@MarryType,@ParentsIf,@ChildIf,@ToMarriage,@SmokeIf,@DrinkIf,@DailyLife,@HouseWork,@Cook,@PetIf,@Deposit,@SingleTime,@LoveNum,@Why,@Reason,@Keep,@Trip,@Activity,@BookType,@Movie, @Book,@Music,@Media)", parms);
	}

	public int ChangeUserInfoDetail(UserInfoDetail userinfodetail)
	{
		SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, userinfodetail.UserName),
                data.MakeInParam("@HomeAddress", SqlDbType.VarChar, 100, userinfodetail.HomeAddress),
                data.MakeInParam("@Parents", SqlDbType.VarChar, 50, userinfodetail.Parents),
                data.MakeInParam("@HomeRank", SqlDbType.VarChar, 50, userinfodetail.HomeRank),
                data.MakeInParam("@ChildrenIf", SqlDbType.VarChar, 50, userinfodetail.ChildrenIf),
                data.MakeInParam("@ChildProtector", SqlDbType.VarChar, 50, userinfodetail.ChildProtector),
                data.MakeInParam("@MarryTime", SqlDbType.VarChar, 50, userinfodetail.MarryTime),
                data.MakeInParam("@MarryType", SqlDbType.VarChar, 50, userinfodetail.MarryType),
                data.MakeInParam("@ParentsIf", SqlDbType.VarChar, 50, userinfodetail.ParentsIf),
                data.MakeInParam("@ChildIf", SqlDbType.VarChar, 50, userinfodetail.ChildIf),
                data.MakeInParam("@ToMarriage", SqlDbType.VarChar, 50, userinfodetail.ToMarriage),
                data.MakeInParam("@SmokeIf", SqlDbType.VarChar, 50, userinfodetail.SmokeIf),
                data.MakeInParam("@DrinkIf", SqlDbType.VarChar, 50, userinfodetail.DrinkIf),
                data.MakeInParam("@DailyLife", SqlDbType.VarChar, 50, userinfodetail.DailyLife),
                data.MakeInParam("@HouseWork", SqlDbType.VarChar, 50, userinfodetail.HouseWork),
                data.MakeInParam("@Cook", SqlDbType.VarChar, 50, userinfodetail.Cook),
                data.MakeInParam("@PetIf", SqlDbType.VarChar, 50, userinfodetail.PetIf),
                data.MakeInParam("@Deposit", SqlDbType.VarChar, 50, userinfodetail.Deposit),
                data.MakeInParam("@SingleTime", SqlDbType.VarChar, 50, userinfodetail.SingleTime),
                data.MakeInParam("@LoveNum", SqlDbType.Int, 32, userinfodetail.LoveNum),
                data.MakeInParam("@Why", SqlDbType.VarChar, 50, userinfodetail.Why),
                data.MakeInParam("@Reason", SqlDbType.VarChar, 50, userinfodetail.Reason),
                data.MakeInParam("@Keep", SqlDbType.VarChar, 50, userinfodetail.Keep),
                data.MakeInParam("@Trip", SqlDbType.VarChar, 50, userinfodetail.Trip),
                data.MakeInParam("@Activity", SqlDbType.VarChar, 50, userinfodetail.Activity),
                data.MakeInParam("@BookType", SqlDbType.VarChar, 50, userinfodetail.BookType),
                data.MakeInParam("@Movie", SqlDbType.VarChar, 50, userinfodetail.Movie),
                data.MakeInParam("@Book", SqlDbType.VarChar, 50, userinfodetail.Book),
                data.MakeInParam("@Music", SqlDbType.VarChar, 100, userinfodetail.Music),
                data.MakeInParam("@Media", SqlDbType.VarChar, 100, userinfodetail.Media),
            };
        return data.RunProc("update userinfodetail set homeaddress=@HomeAddress,parents=@Parents,homerank=@HomeRank,childrenif=@ChildrenIf,childprotector=@ChildProtector,marrytime=@MarryTime,marrytype=@MarryType,parentsif=@ParentsIf,childif=@ChildIf,tomarriage=@ToMarriage,smokeif=@SmokeIf,drinkif=@DrinkIf,dailylife=@DailyLife,housework=@HouseWork,cook=@Cook,petif=@PetIf,deposit=@Deposit,singletime=@SingleTime,lovenum=@LoveNum,why=@Why,reason=@Reason,keep=@Keep,trip=@Trip,activity=@Activity,booktype=@BookType,movie=@Movie,book=@Book,music=@Music,media=@Media where username=@UserName",parms);
    }

	public UserInfoDetail()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}