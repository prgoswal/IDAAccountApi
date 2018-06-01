using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    

    public class ItemGroupDataAccess
    {
        //public static string connection = @"Data Source=(LocalDb)\v11.0;Integrated Security=true; Initial Catalog=Sachin";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        List<ItemGroupModel> list;

        public List<ItemGroupModel> Get()
        {
            con = new SqlConnection(GetConn());
            cmd = new SqlCommand("SpParentChild", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 2);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
           
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            list = new List<ItemGroupModel>();
            while (dr.Read())
            {
                ItemGroupModel obj = new ItemGroupModel()
                {
                    ItemGroup = dr["ItemGroup"].ToString(),
                    GroupPrimary = dr["GroupPrimary"].ToString(),
                    ItemUnderGroup = dr["ParentGroupID"].ToString()
                };
                list.Add(obj);
            }
            con.Close();

            return list;
        }

        public string GetConn()
        {
            string s = File.ReadAllText(@"D:\Sachin\1_Projects\GST\GSTAccount\Conn.txt");
            return s;
        }


        internal bool CheckActivation(string UserID)
        {
            try
            {

            con = new SqlConnection(GetConn());
            cmd = new SqlCommand("SpParentChild", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 1);
            cmd.Parameters.AddWithValue("@UserLoginID", UserID);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            con.Open();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (Convert.ToBoolean(dr.Read()))
            {
                return true;
            }

            return false;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
    }
}