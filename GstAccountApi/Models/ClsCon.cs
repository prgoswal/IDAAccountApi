using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models
{
    public abstract class ClsCon
    {
        //public SqlCommand cmd;

        //public SqlDataAdapter sda;

        //public SqlDataReader sdr;

        //public static SqlConnection con;

        //public static SqlConnection Conn()
        //{
        //    try
        //    {
        //        con = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        return con;
        //    }
        //    catch (Exception)
        //    {
        //        con.Close();
        //        return con;
        //    }
        //}

        static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;        

        public static SqlConnection SqlConn()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}