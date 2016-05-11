using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ConnectDAL
/// </summary>
class ConnectDAL
{
    public static SqlConnection cnn = null;
    public SqlConnection getConn()
    {
        string conn = ConfigurationManager.ConnectionStrings["dbSoLienLacDT"].ToString();
        cnn = new SqlConnection(conn);
        cnn.Open();
        return cnn;
    }
    public ConnectDAL()
    {

    }
    
}