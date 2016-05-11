using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Default2 : System.Web.UI.Page
{
    LopBLL bll = new LopBLL();
    protected void Page_Load(object sender, EventArgs e)
    {       
            
        if (!IsPostBack)
        {
            txtmalop.Enabled = true;        
            hienkhoi();
            FillGridView();
            if (Request.QueryString["action"] != null)
            {
                txtmalop.Enabled = false;
                string action = Request.QueryString["action"];
                string malop = Convert.ToString(Request.QueryString["MaLop"]);
                LopDTO lop = bll.GetALop(malop);
                txtmalop.Text = Convert.ToString(lop.MaLop);
                txttenlop.Text = lop.TenLop.ToString();
                string khoi = Convert.ToString(lop.KhoiLop);
                if (khoi == "10")
                {
                    ddlkhoi.SelectedIndex = 0;
                }
                else if (khoi == "11")
                {
                    ddlkhoi.SelectedIndex = 1;
                }
                else
                {
                    ddlkhoi.SelectedIndex = 2;
                }
            }
            
        }
    }

    public void hienkhoi()
    {
        ddlkhoi.Items.Insert(0, new ListItem("10", "10"));
        ddlkhoi.Items.Insert(1, new ListItem("11", "11"));
        ddlkhoi.Items.Insert(2, new ListItem("12", "12"));
        ddlkhoi.DataBind();
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllLop();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Clear();
        Response.Redirect("~/Admin/ThongTinLopHoc.aspx");
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        LopDTO tb = new LopDTO();
        tb.MaLop = Convert.ToString(txtmalop.Text);
        tb.TenLop = Convert.ToString(txttenlop.Text);
        tb.KhoiLop = ddlkhoi.Text;
        bll.SaveLop(tb);
        Clear();
        FillGridView();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        LopDTO tb = new LopDTO();
        tb.MaLop = Convert.ToString(txtmalop.Text);
        tb.TenLop = Convert.ToString(txttenlop.Text);
        tb.KhoiLop = ddlkhoi.SelectedValue;
        bll.EditLop(tb);
        Clear();
        FillGridView();
    }
    public void Clear()
    {
        txtmalop.Text = "";
        txtmalop.Focus();
        txttenlop.Text = "";
        txtmalop.Enabled = true;
    }
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        Clear();
    }
}