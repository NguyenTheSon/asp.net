using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class LayLaiMatKhAU : System.Web.UI.Page
{
    NguoiDungBLL dll = new NguoiDungBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtcauhoi.Enabled = true;
        }
        
    }
    protected void txttaikhoan_TextChanged(object sender, EventArgs e)
    {
        txtcauhoi.Enabled = false;
        string taikhoan = txttaikhoan.Text;
        string cauhoi = dll.getCauHoiBM(taikhoan);
        txtcauhoi.Text = cauhoi.ToString();
    }
    protected void btnXacnhan_Click(object sender, EventArgs e)
    {
        string taikhoan = txttaikhoan.Text.ToString();
        string traloi = dll.getXacNhan(taikhoan);
        string matkhau = "123456";
        if (taikhoan == "" && txttraloi.Text == "")
        {
            Response.Write("<script language='JavaScript'>alert('Tài khoản hoặc câu trả lời không đúng. Vui lòng nhập lại!');</script>");
            txttaikhoan.Focus();
        }

        if (traloi == txttraloi.Text.ToString())
        {

            NguoiDungDTO nd = new NguoiDungDTO();
            nd.Taikhoan = taikhoan;
            nd.Matkhau = matkhau;
            dll.UpdateNguoidung(nd);
            Response.Write("<script language='JavaScript'>alert('Thành công! Mật khẩu của bạn là: 123456');</script>");            
            Response.Redirect("~/Dangnhap.aspx");
        }
        else
        {
            Response.Write("<script language='JavaScript'>alert('Thất bại!');</script>");
            Cleartextbox();
        }
        
    }
    public void Cleartextbox()
    {
        txttaikhoan.Focus();
        txttaikhoan.Text = "";
        txtcauhoi.Text = "";
        txttraloi.Text = "";

    }
    protected void btnQuaylai_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Dangnhap.aspx");
    }
}