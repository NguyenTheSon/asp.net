using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoaiDiem
/// </summary>
public class LoaiDiem
{
    public int MaLoaiD { get; set; }
    public string TenLoaiD { get; set; }
    public int HeSoD { get; set; }
	public LoaiDiem()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public LoaiDiem(int mald, string tenld, int hsd)
    {
        this.MaLoaiD = mald;
        this.TenLoaiD = tenld;
        this.HeSoD = hsd;
    }
}