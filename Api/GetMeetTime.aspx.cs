using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Api_GetMeetTime : System.Web.UI.Page
{
    const string strDate = "2018/6/17 16:09";
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime startDate = Convert.ToDateTime(strDate);
        string msg = "";
        try
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("lijinfeng.club,password=wsljf.");
            IDatabase db = redis.GetDatabase();
            msg = db.StringGet("Today");
        }
        catch (Exception ex)
        {
        }
        TimeSpan timeSpan = DateTime.Now.Subtract(startDate);
        var obj = new { time = Math.Round(timeSpan.TotalSeconds), message = msg };
        Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(obj));
    }
}