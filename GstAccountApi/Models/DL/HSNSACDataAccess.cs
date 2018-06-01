using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class HSNSACDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtHSNSAC;

        internal DataTable LoadHSNSACInfo(HSNSACModel objHSNSACModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPHSNSACMaster";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objHSNSACModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@GoodsServiceInd", objHSNSACModel.GoodsServiceInd);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objHSNSACModel.HSNSACCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtHSNSAC = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtHSNSAC);
                dtHSNSAC.TableName = "success";
            }
            catch (Exception)
            {
                dtHSNSAC = new DataTable();
                dtHSNSAC.TableName = "error";
                return dtHSNSAC;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtHSNSAC;
        }

        internal DataTable UpdateHSNSACInfo(HSNSACModel objHSNSACModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPHSNSACMaster";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objHSNSACModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@GoodsServiceInd", objHSNSACModel.GoodsServiceInd);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objHSNSACModel.HSNSACCode);
                ClsCon.cmd.Parameters.AddWithValue("@TaxRate", objHSNSACModel.TaxRate);
                ClsCon.cmd.Parameters.AddWithValue("@IGRate", objHSNSACModel.IGRate);
                ClsCon.cmd.Parameters.AddWithValue("@SGRate", objHSNSACModel.SGRate);
                ClsCon.cmd.Parameters.AddWithValue("@CGRate", objHSNSACModel.CGRate);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtHSNSAC = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtHSNSAC);
                dtHSNSAC.TableName = "success";
            }
            catch (Exception)
            {
                dtHSNSAC = new DataTable();
                dtHSNSAC.TableName = "error";
                return dtHSNSAC;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtHSNSAC;
        }
    }
}