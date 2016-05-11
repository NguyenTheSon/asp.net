using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for NhanXetBLL
/// </summary>
public class NhanXetBLL
{
    ConnectDAL dl = new ConnectDAL();
	public NhanXetBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetAllNhanXet()
    {
        dl.getConn();
        SqlDataAdapter adap = new SqlDataAdapter("Select * from NhanXet", ConnectDAL.cnn);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    
}