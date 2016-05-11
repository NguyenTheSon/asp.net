using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GiaovienDTO
/// </summary>
public class GiaovienDTO
{
    public int MaGV { get; set; }
    public string HotenGV { get; set; }
    public DateTime Ngaysinh { get; set; }
    public bool Chunhiem { get; set; }
    public string Taikhoan { get; set; }
	public GiaovienDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public GiaovienDTO(string hoten, DateTime ngaysinh, bool cn, string tk)
    {
        this.HotenGV = hoten;
        this.Ngaysinh = ngaysinh;
        this.Chunhiem = cn;
        this.Taikhoan = tk;
    }
}