using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class redirecturl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        oauth.Text = Request.Params["code"];

        Request.Headers.Add("Authorization", "Bearer " + oauth.Text);
        Request.Headers.Add("Accept", "application/json;odata.metadata=minimal");
        
    }
}