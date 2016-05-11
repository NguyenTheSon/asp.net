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
    GiaovienBLL bll = new GiaovienBLL();
    NguoiDungBLL bllnd = new NguoiDungBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridView();
            if (Request.QueryString["action"] != null)
            {
                txttaikhoan.Enabled = false;
                string action = Request.QueryString["action"];
                int magv = Convert.ToInt16(Request.QueryString["MaGV"]);
                GiaovienDTO gv = bll.GetAGV(magv);
                txtmagv.Text = Convert.ToString(gv.MaGV);
                txthotengv.Text = gv.HotenGV.ToString();
                txtns.Text = Convert.ToString(gv.Ngaysinh);
                txttaikhoan.Text = gv.Taikhoan.ToString();
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        txttaikhoan.Enabled = true;
        ClearTextbox();
    }
    private void FillGridView()
    {
        DataTable table = bll.GetAllGiaovien();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
    public void ClearTextbox()
    {
        txtmagv.Text = "";
        txthotengv.Text = "";
        txtns.Text = "";
        txttaikhoan.Text = "";
        txthotengv.Focus();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        NguoiDungDTO nd = new NguoiDungDTO();
        nd.Taikhoan = txttaikhoan.Text;
        nd.Matkhau = "123456".ToString();
        nd.Quyen = "giaovien".ToString();
        nd.CauhoiBM = "";
        nd.Traloi = "";
        bllnd.SaveNguoidung(nd);
        GiaovienDTO gv = new GiaovienDTO();
        gv.HotenGV = txthotengv.Text;
        gv.Ngaysinh = Convert.ToDateTime(txtns.Text);
        gv.Chunhiem = false;
        gv.Taikhoan = txttaikhoan.Text;
        bll.SaveGiaovien(gv);
        ClearTextbox();
        FillGridView();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        GiaovienDTO gv = new GiaovienDTO();
        gv.MaGV = Convert.ToInt16(txtmagv.Text);
        gv.HotenGV = txthotengv.Text;
        gv.Ngaysinh = Convert.ToDateTime(txtns.Text);
        gv.Taikhoan = txttaikhoan.Text;
        bll.EditGiaovien(gv);
        ClearTextbox();
        FillGridView();
    }
    /*public void Delete_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        if (b.CommandName == "Xóa")
        {
            int magv = Convert.ToInt16(b.CommandArgument);
            bll.DelGiaoVien(magv);
            FillGridView();
        }
    }*/
    protected void btnHuy_Click(object sender, EventArgs e)
    {
        ClearTextbox();
    }
}