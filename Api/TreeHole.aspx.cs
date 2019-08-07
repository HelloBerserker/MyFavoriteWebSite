using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackExchange.Redis;
using System.Collections;

public partial class TreeHole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewResult result = new ViewResult("测试Redis是否正确，然后就可以复制粘贴了");
        try
        {
            string action = Convert.ToString(Request.QueryString["action"]);
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("lijinfeng.club,password=wsljf.");
            IDatabase db = redis.GetDatabase();
           var flag=db.StringSet("greet", "Hello,李晋峰");
            result.Success = flag;
            result.Data.Add("Action", action);
            String name=db.StringGet("Today");
            result.Data.Add("Today", name);
        }
        catch(Exception ex)
        {
            result.Message = ex.Message;
        }
        Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(result));
    }
    class ViewResult
    {
        public ViewResult(string message)
        {
            this.Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public Hashtable Data = new Hashtable();

    }
}