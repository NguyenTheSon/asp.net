using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giaovien_NhapDiemThanhPhan : System.Web.UI.Page
{
    GiaoVienBLL1 gvBLL = new GiaoVienBLL1();
    GiaoVienDAL gvDAL = new GiaoVienDAL();
    static int monhoc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LopHoc lh = new LopHoc();
            if (Request.QueryString["action"] == "nhapdiem")
            {
                string action = Request.QueryString["nhapdiem"];
                string malop = Request.QueryString["malop"];
                Session["malop"] = malop;

                lh.MaLop = Session["malop"].ToString();

            }
            lh.MaLop = Session["malop"].ToString();
            GiaoVien gv = new GiaoVien();
            int magv = int.Parse(Session["magv"].ToString());
            monhoc = gvDAL.GetMaMonHoc(magv, lh.MaLop);   
            gv.MaGV = magv;           
            DSHocSinh.DataSource = gvDAL.GetDanhSachHSLopNhapDiem(Session["malop"].ToString(), magv,monhoc);
            DSHocSinh.DataBind();
            kiemtratb();
        }
        lbTenLop.Text = gvDAL.LayTenLop(Session["malop"].ToString());
        lbMonHoc.Text=gvDAL.LayTenMonHoc(monhoc);

    }

    public void kiemtratb()
    {
        foreach (DataListItem item in DSHocSinh.Items)
        {

            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {

                Label lb1 = (Label)item.FindControl("lbMasv");
                TextBox cb1 = (TextBox)item.FindControl("txtMieng1");
                if (!cb1.Text.Equals(""))
                {
                   ((TextBox)item.FindControl("txtMieng1")).Enabled = false;
                }

                TextBox cb2 = (TextBox)item.FindControl("txtMieng2");
                if (!cb2.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txtMieng2")).Enabled = false;
                }

                TextBox cb3 = (TextBox)item.FindControl("txtMieng3");
                if (!cb3.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txtMieng3")).Enabled = false;
                }

                TextBox cb4 = (TextBox)item.FindControl("txt15p1");
                if (!cb4.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt15p1")).Enabled = false;
                }

                TextBox cb5 = (TextBox)item.FindControl("txt15p2");
                if (!cb5.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt15p2")).Enabled = false;
                }

                TextBox cb6 = (TextBox)item.FindControl("txt15p3");
                if (!cb6.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt15p3")).Enabled = false;
                }

                TextBox cb7 = (TextBox)item.FindControl("txt15p4");
                if (!cb7.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt15p4")).Enabled = false;
                }

                TextBox cb8 = (TextBox)item.FindControl("txt45p1");
                if (!cb8.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt45p1")).Enabled = false;
                }

                TextBox cb9 = (TextBox)item.FindControl("txt45p2");
                if (!cb9.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt45p2")).Enabled = false;
                }

                TextBox cb10 = (TextBox)item.FindControl("txt45p3");
                if (!cb10.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txt45p3")).Enabled = false;
                }

                TextBox cb11 = (TextBox)item.FindControl("txtHocky");
                if (!cb11.Text.Equals(""))
                {
                    ((TextBox)item.FindControl("txtHocky")).Enabled = false;
                }

            }

        }
    }

    protected void btnLuu_Click(object sender, EventArgs e)
    {
        foreach (DataListItem item in DSHocSinh.Items)
        {

            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {

                TextBox cb1 = (TextBox)item.FindControl("txtMieng1");
                if (!cb1.Text.Equals(""))
                {
                    Label lb1 = (Label)item.FindControl("lbMasv");
                    int mahs = int.Parse(lb1.Text);
                    float d = float.Parse(cb1.Text);
                    Diem diem = new Diem();
                    diem.MaHS = mahs;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 4;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb2 = (TextBox)item.FindControl("txtMieng2");
                if (!cb2.Text.Equals(""))
                {
                    Label lb2 = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb2.Text);
                    float d = float.Parse(cb2.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 5;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb3 = (TextBox)item.FindControl("txtMieng3");
                if (!cb3.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb3.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 6;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb4 = (TextBox)item.FindControl("txt15p1");
                if (!cb4.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb4.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 7;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb5 = (TextBox)item.FindControl("txt15p2");
                if (!cb5.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb5.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 8;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb6 = (TextBox)item.FindControl("txt15p3");
                if (!cb6.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb6.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 10;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb7 = (TextBox)item.FindControl("txt15p4");
                if (!cb7.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb7.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 11;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb8 = (TextBox)item.FindControl("txt45p1");
                if (!cb8.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb8.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc =monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 12;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb9 = (TextBox)item.FindControl("txt45p2");
                if (!cb9.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb9.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc =monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 14;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb10 = (TextBox)item.FindControl("txt45p3");
                if (!cb10.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb10.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 15;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

                TextBox cb11 = (TextBox)item.FindControl("txtHocky");
                if (!cb11.Text.Equals(""))
                {
                    Label lb = (Label)item.FindControl("lbMasv");
                    int masv = int.Parse(lb.Text);
                    float d = float.Parse(cb11.Text);
                    Diem diem = new Diem();
                    diem.MaHS = masv;
                    diem.MaGV = int.Parse(Session["magv"].ToString());
                    diem.MaMonHoc = monhoc;
                    diem.HocKy = 1;
                    diem.NamHoc = "2015-2016";
                    diem.MaLoaiDiem = 16;
                    diem.DiemNhap = d;
                    gvBLL.NhapDiemCK(diem);
                }

            }
           

        }
        btnLuu.Enabled = false;
    }

    protected void btnHuy_Click(object sender, EventArgs e)
    {
        Response.Redirect("DanhSachLopNhapDiem.aspx");
    }
}