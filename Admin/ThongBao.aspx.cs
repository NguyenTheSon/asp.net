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
    ThongBaoBLL bll = new ThongBaoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
            if (Request.QueryString["action"] != null)
            {
                txtmatb.Enabled = false;
                string action = Request.QueryString["action"];
                int matb = Convert.ToInt16(Request.QueryString["MaTB"]);
                ThongBaoDTO tb = bll.GetATB(matb);
                txtmatb.Text = Convert.ToString(tb.MaTB);
                txtntb.Text = Convert.ToString(tb.NgayTB);
                txttentb.Text = Convert.ToString(tb.TenTB);
                txtnd.Text = Convert.ToString(tb.NoiDung);
            }
        }
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllThongBao();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    public void ClearTextbox()
    {
        txtmatb.Text = "";
        txtntb.Text = "";
        txttentb.Text = "";
        txtnd.Text = "";
        txtntb.Focus();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClearTextbox();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        ThongBaoDTO tb = new ThongBaoDTO();
        tb.MaTB = Convert.ToInt16(txtmatb.Text);
        tb.NgayTB = Convert.ToDateTime(txtntb.Text);
        tb.TenTB = txttentb.Text;
        tb.NoiDung = txtnd.Text;
        tb.TaiKhoan = Session["idlogin"].ToString();
        bll.SaveThongBao(tb);
        ClearTextbox();
        FillGridView();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        ThongBaoDTO tb = new ThongBaoDTO();
        tb.MaTB = Convert.ToInt16(txtmatb.Text);
        tb.NgayTB = Convert.ToDateTime(txtntb.Text);
        tb.TenTB = txttentb.Text;
        tb.NoiDung = txtnd.Text;
        bll.EditThongBao(tb);
        ClearTextbox();
        FillGridView();
    }
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        ClearTextbox();
    }
}