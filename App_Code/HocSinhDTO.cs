using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HocSinhDTO
/// </summary>
public class HocSinhDTO
{
    public int MaHS { get; set; }
    public string HotenHS { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string MaLop { get; set; }
    public string TaiKhoan { get; set; }
	public HocSinhDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public HocSinhDTO(int mahs, string hoten, DateTime ns, string dc, string malop, string taikhoan)
    {
        this.MaHS = mahs;
        this.HotenHS = hoten;
        this.NgaySinh = ns;
        this.DiaChi = dc;
        this.MaLop = malop;
        this.TaiKhoan = taikhoan;
    }
}