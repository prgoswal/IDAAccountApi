using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GstAccountApi.Models.DL
{
    public class OpeningBlcTransferDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtClosingBlc;




        internal DataTable LoadClosingBalance(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRPTtrialBalance";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransfer.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransfer.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransfer.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransfer.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", ObjOpeningBlcTransfer.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", ObjOpeningBlcTransfer.VoucharDateto);
                ClsCon.cmd.Parameters.AddWithValue("@Reportorder", ObjOpeningBlcTransfer.Reportorder);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtClosingBlc = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtClosingBlc);
                dtClosingBlc.TableName = "success";
            }
            catch (Exception)
            {
                dtClosingBlc = new DataTable();
                dtClosingBlc.TableName = "error";
                return dtClosingBlc;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtClosingBlc;
        }

        internal DataTable SaveOpeningBalance(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOpeningBlcTransfer";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransfer.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransfer.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransfer.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjOpeningBlcTransfer.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjOpeningBlcTransfer.IP);
                ClsCon.cmd.Parameters.AddWithValue("@VChType", ObjOpeningBlcTransfer.VChType);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransfer.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@YrStartDate", ObjOpeningBlcTransfer.YrStartDate);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", ObjOpeningBlcTransfer.VoucharDate);
                ClsCon.cmd.Parameters.AddWithValue("@Narration", ObjOpeningBlcTransfer.Narration);
                //ClsCon.cmd.Parameters.AddWithValue("@TblOpeningBlc", ObjOpeningBlcTransfer.dtOpeningBlc);

                ClsCon.cmd.Parameters.AddWithValue("@TblOpeningBlc", JsonConvert.DeserializeObject<DataTable>(ObjOpeningBlcTransfer.dtOpeningBlc));


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtClosingBlc = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtClosingBlc);
                dtClosingBlc.TableName = "success";
            }
            catch (Exception)
            {
                dtClosingBlc = new DataTable();
                dtClosingBlc.TableName = "error";
                return dtClosingBlc;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtClosingBlc;
        }
    }
}