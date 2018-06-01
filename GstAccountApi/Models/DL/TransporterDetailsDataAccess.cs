using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace GstAccountApi.Models.DL
{
    public class TransporterDetailsDataAccess
    {

        SqlConnection con = new SqlConnection();
        DataTable dtTransporterDetail;
        DataSet dsState;

        internal DataTable SaveTransporterDetail(TransporterDetailModal ObjTransporterModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPTranspoter";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjTransporterModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjTransporterModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjTransporterModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjTransporterModel.yrcd);
                ClsCon.cmd.Parameters.AddWithValue("@TransporterName", ObjTransporterModel.TransportationName);
                ClsCon.cmd.Parameters.AddWithValue("@OwnerName", ObjTransporterModel.OwnerName);
                ClsCon.cmd.Parameters.AddWithValue("@Address", ObjTransporterModel.Address);
                ClsCon.cmd.Parameters.AddWithValue("@City", ObjTransporterModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@State", ObjTransporterModel.State);
                ClsCon.cmd.Parameters.AddWithValue("@Pincode", ObjTransporterModel.Pincode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjTransporterModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@RegistrationNo", ObjTransporterModel.RegistrationNo);



                ClsCon.cmd.Parameters.AddWithValue("@TransportthroughRoad", ObjTransporterModel.Road);
                ClsCon.cmd.Parameters.AddWithValue("@TransportthroughRail", ObjTransporterModel.Rail);
                ClsCon.cmd.Parameters.AddWithValue("@TransportthroughAir", ObjTransporterModel.Air);
                ClsCon.cmd.Parameters.AddWithValue("@TransportthroughShip", ObjTransporterModel.Ship);

                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjTransporterModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@EntryDateTime", ObjTransporterModel.EntryDateTime);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjTransporterModel.IPAddress);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtTransporterDetail = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtTransporterDetail);

                dtTransporterDetail.TableName = "success";
            }
            catch (Exception)
            {
                dtTransporterDetail = new DataTable();
                dtTransporterDetail.TableName = "error";
                return dtTransporterDetail;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtTransporterDetail;
        }


        internal DataSet BindAll(TransporterDetailModal ObjTransporterModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPTranspoter";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjTransporterModel.Ind);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsState = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsState);
                dsState.DataSetName = "success";
            }
            catch (Exception)
            {
                dsState = new DataSet();
                dsState.DataSetName = "error";
                return dsState;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsState;
        }
    }
}