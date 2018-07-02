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
        TimeSpan timeSpan = DateTime.Now.Subtract(startDate);
        Response.Write(Math.Round(timeSpan.TotalSeconds));
    }
}