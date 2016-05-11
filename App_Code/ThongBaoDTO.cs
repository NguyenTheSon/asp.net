using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ThongBaoDTO
/// </summary>
public class ThongBaoDTO
{
    public int MaTB { get; set; }
    public DateTime NgayTB { get; set; }
    public string TenTB { get; set; }
    public string NoiDung { get; set; }
    public string TaiKhoan { get; set; }
	public ThongBaoDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public ThongBaoDTO(int matb, DateTime ngaytb, string tentb, string nd, string tk)
    {
        this.MaTB = matb;
        this.NgayTB = ngaytb;
        this.TenTB = tentb;
        this.NoiDung = nd;
        this.TaiKhoan = tk;
    }
}