using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GiaoVien_GiaoVienMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getTime();
    }
    public void getTime()
    {
        string strday = DateTime.Now.ToString("yyyy-MM-dd");
        string strtoday = DateTime.Now.ToString("HH:mm:ss");
        lbltime.Text = "Bây giờ là: " + strtoday.ToString() + " Ngày " + strday.ToString();
    }
}
