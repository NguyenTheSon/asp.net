using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MonHocDTO
/// </summary>
public class MonHocDTO
{
    public int MaMH { get; set; }
    public string TenMH { get; set; }
	public MonHocDTO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public MonHocDTO(int mamh, string tenmh)
    {
        this.MaMH = mamh;
        this.TenMH = tenmh;
    }
}