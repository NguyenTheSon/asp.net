using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PhanCongCNDTO
/// </summary>
public class PhanCongCNDTO
{
    public string MaLop { get; set; }
    public string NamHoc { get; set; }
    public int HocKy { get; set; }
    public int MaGV { get; set; }
	public PhanCongCNDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public PhanCongCNDTO(string mal, string namh, int hk, int magv)
    {
        this.MaLop = mal;
        this.NamHoc = namh;
        this.HocKy = hk;
        this.MaGV = magv;
    }
}