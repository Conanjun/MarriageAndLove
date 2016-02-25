﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// activity 的摘要说明
/// </summary>
public class Activity
{
    string activityname = "";
    string activitytime = "";
    string activityplace = "";
    int joinnumber;
    string activitystatus = "";
    string activityintroduction = "";

    public string ActivityName
    {
        get { return activityname; }
        set { activityname = value; }
    }
    public string ActivityTime
    {
        get { return activitytime; }
        set { activitytime = value; }
    }
    public string ActivityPlace
    {
        get { return activityplace; }
        set { activityplace = value; }
    }
    public int JoinNumber
    {
        get { return joinnumber; }
        set { joinnumber = value; }
    }
    public string ActivityStatus
    {
        get { return activitystatus; }
        set { activitystatus = value; }
    }
    public string ActivityIntroduction
    {
        get { return activityintroduction; }
        set { activityintroduction = value; }
    }

    private readonly DataBase data = new DataBase();

    public int InsertActivity(Activity activity)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@ActivityName", SqlDbType.VarChar, 50, activity.ActivityName),
                data.MakeInParam("@ActivityTime", SqlDbType.VarChar, 50, activity.ActivityTime),
                data.MakeInParam("@ActivityPlace", SqlDbType.VarChar, 50, activity.ActivityPlace),
                data.MakeInParam("@JoinNumber", SqlDbType.Int, 32, activity.JoinNumber),
                data.MakeInParam("@ActivityStatus", SqlDbType.VarChar, 50, activity.ActivityStatus),
                data.MakeInParam("@ActivityIntroduction", SqlDbType.VarChar, 200, activity.ActivityIntroduction),
            };
        return
            data.RunProc("insert into activity values(@ActivityName,@ActivityTime,@ActivityPlace,@JoinNumber,@ActivityStatus,@ActivityIntroduction)", parms);
    }
    public int AddNumber(Activity activity)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@ActivityName", SqlDbType.VarChar, 50, activity.ActivityName),
                data.MakeInParam("@JoinNumber", SqlDbType.Int, 32, activity.JoinNumber),
            };
        return
            data.RunProc("update activity set joinnumber=joinnumber+1 where activityname=@ActivityName", parms);
    }
    public DataSet GetAllActivity(Activity activity)
    {
        SqlParameter[] parms =
            {
                data.MakeInParam("@ActivityName", SqlDbType.VarChar, 50, activity.ActivityName),
                data.MakeInParam("@ActivityTime", SqlDbType.VarChar, 50, activity.ActivityTime),
                data.MakeInParam("@ActivityPlace", SqlDbType.VarChar, 50, activity.ActivityPlace),
                data.MakeInParam("@JoinNumber", SqlDbType.Int, 32, activity.JoinNumber),
                data.MakeInParam("@ActivityStatus", SqlDbType.VarChar, 50, activity.ActivityStatus),
                data.MakeInParam("@ActivityIntroduction", SqlDbType.VarChar, 200, activity.ActivityIntroduction),
            };
        return
            data.RunProcReturn("select * from activity", parms, "activity");
    }
	public Activity()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
}