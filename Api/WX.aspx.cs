using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Api_WX : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       string retString=Request.QueryString["echostr"];
       Response.Write(retString);
    }
}