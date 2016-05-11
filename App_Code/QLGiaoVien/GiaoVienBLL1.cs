using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GiaoVienBLL
/// </summary>
public class GiaoVienBLL1
{
    GiaoVienDAL kn = new GiaoVienDAL();
    
    public DataTable LayKhoiLop(){
        return kn.GetKhoi();
    }

    public DataTable LayLopHocTheoKhoi_GV(KhoiLop kl, GiaoVien gv){
        return kn.GetLopTheoKhoi_GV(kl.MaKhoi,gv.MaGV);
    }

    public DataTable LayLopHocTheoKhoi(KhoiLop kl)
    {
        return kn.GetLopTheoKhoi(kl.MaKhoi);
    }

    public DataTable LayLopHocTheoGV(GiaoVien gv)
    {
        return kn.GetDanhSachLopDay(gv.MaGV);
    }

    public DataTable LayDanhSachHS(LopHoc lh)
    {
        return kn.GetDanhSachHSLop(lh.MaLop);
    }

   

    public DataTable XemDiemThanhPhan(int mahs)
    {
        return kn.GetXemDiemThanhPhan(mahs);
    }

   
  
    public void NhapDiemCK(Diem d)
    {
        kn.NhapDiemCuoiKy(d);
    }
	public GiaoVienBLL1()
	{
		
	}


}