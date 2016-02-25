using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// action 的摘要说明
/// </summary>
public class Action
{
    string username = "";
    string name = "";
    string sex = "";
    string email = "";
    string telephone = "";
    string evaluation="";
    string attendactivity = "";

    public string AttendActivity
    {
        get { return attendactivity; }
        set { attendactivity = value; }
    }
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
    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string Telephone
    {
        get { return telephone; }
        set { telephone= value; }
    }

    public string Evaluation
    {
        get { return evaluation; }
        set { evaluation = value; }
    }

    private readonly DataBase data = new DataBase();

    public int ParticipantAdd(Action action)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, action.username),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, action.name),
                data.MakeInParam("@Sex", SqlDbType.VarChar, 20, action.sex),
                data.MakeInParam("@Email", SqlDbType.VarChar, 50, action.email),
                data.MakeInParam("@Telephone", SqlDbType.VarChar, 50, action.telephone),
                data.MakeInParam("@AttendActivity", SqlDbType.VarChar, 50, action.AttendActivity),
            };
        return data.RunProc("Insert into action(username,name,sex,email,telephone,attendactivity) values (@UserName,@Name,@Sex,@Email,@Telephone,@AttendActivity)", parms);
    }

    public int ParticipantDelete(string del_participant)
    {
        SqlParameter[] parms ={
								 data.MakeInParam("@UserName",SqlDbType.VarChar,50,del_participant),
							 };
        return data.RunProc("delete from action where username=@UserName", parms);
    }

    public DataSet ConfirmParticipant(Action action)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, action.username),
                data.MakeInParam("@Name", SqlDbType.VarChar, 50, action.name),
                data.MakeInParam("@Sex", SqlDbType.VarChar, 20, action.sex),
                data.MakeInParam("@Email", SqlDbType.VarChar, 50, action.email),
                data.MakeInParam("@Telephone", SqlDbType.VarChar, 50, action.telephone),
                data.MakeInParam("@AttendActivity", SqlDbType.VarChar, 50, action.AttendActivity),
            };
        return
            data.RunProcReturn(
                "SELECT * FROM action WHERE (username=@UserName) AND (name = @Name) AND (sex=@Sex) AND(email=@Email) AND (telephone=@Telephone) AND (attendactivity=@AttendActivity)", parms,
                "action");
    }
    public DataSet GetAttendActivity(Action action)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, action.username),
            };
        return
            data.RunProcReturn(
                "SELECT attendactivity FROM action WHERE username=@UserName", parms,
                "action");
    }
    public DataSet JudgeParticipant(Action action)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, action.username),
            };
        return
            data.RunProcReturn(
                "SELECT * FROM action WHERE username=@UserName", parms,
                "action");
    }
    public int EvaluationInsert(Action action)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@Evaluation", SqlDbType.VarChar, 200, action.evaluation),
                data.MakeInParam("@UserName", SqlDbType.VarChar, 50, action.username),
                data.MakeInParam("@AttendActivity", SqlDbType.VarChar, 50, action.AttendActivity),
            };
        return data.RunProc("update action set evaluation=@Evaluation where (username=@UserName) AND (attendactivity=@AttendActivity)", parms);
    }
	public Action()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}