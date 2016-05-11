using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnThoat_Click(object sender, EventArgs e)
    {
        Session["idlogin"] = null;
        Response.Redirect("~/Dangnhap.aspx");
    }
}
