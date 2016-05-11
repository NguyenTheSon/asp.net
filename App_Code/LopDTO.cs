using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LopDTO
/// </summary>
public class LopDTO
{
    public string MaLop { get; set; }
    public string TenLop { get; set; }
    public string KhoiLop { get; set; }
	public LopDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public LopDTO(string malop, string tenlop, string khoilop)
    {
        this.MaLop = malop;
        this.TenLop = tenlop;
        this.KhoiLop = khoilop;
    }
}