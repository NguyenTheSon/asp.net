using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NhanXetDTO
/// </summary>
public class NhanXetDTO
{
    public int MaNX { get; set; }
    public string TenNX { get; set; }
    public DateTime NgayNX { get; set; }
    public string NoiDung { get; set; }
    public int MaHS { get; set; }
    public int MaGV { get; set; }
	public NhanXetDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public NhanXetDTO(int manx, string tennx, DateTime ngaynx, string nd, int mahs, int magv)
    {
        this.MaNX = manx;
        this.TenNX = tennx;
        this.NgayNX = ngaynx;
        this.NoiDung = nd;
        this.MaHS = mahs;
        this.MaGV = magv;
    }
}