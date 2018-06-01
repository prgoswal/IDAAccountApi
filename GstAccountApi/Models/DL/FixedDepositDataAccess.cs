using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class FixedDepositDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtFD;
        DataSet dsFD;


        internal DataTable SaveFixedDeposit(FixedDepositModel objFDModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFixedDeposit";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objFDModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objFDModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objFDModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objFDModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DespositDate", objFDModel.DespositDate);
                ClsCon.cmd.Parameters.AddWithValue("@BankCode", objFDModel.BankCode);
                ClsCon.cmd.Parameters.AddWithValue("@FDNumber", objFDModel.FDNumber);
                ClsCon.cmd.Parameters.AddWithValue("@MaturityDate", objFDModel.MaturityDate);
                ClsCon.cmd.Parameters.AddWithValue("@DepositAmount", objFDModel.DepositAmount);
                ClsCon.cmd.Parameters.AddWithValue("@MaturityAmonut", objFDModel.MaturityAmount);
                ClsCon.cmd.Parameters.AddWithValue("@ROI", objFDModel.ROI);
                ClsCon.cmd.Parameters.AddWithValue("@SchemeType", objFDModel.SchemeType);
                ClsCon.cmd.Parameters.AddWithValue("@LienAmount", objFDModel.LienAmount);
                ClsCon.cmd.Parameters.AddWithValue("@LienDate", objFDModel.LienDate);

                ClsCon.cmd.Parameters.AddWithValue("@DepositYear", objFDModel.DepositYear);
                ClsCon.cmd.Parameters.AddWithValue("@DepositMonth", objFDModel.DepositMonth);
                ClsCon.cmd.Parameters.AddWithValue("@DepositDay", objFDModel.DepositDay);




                ClsCon.cmd.Parameters.AddWithValue("@FDRAccNumber", objFDModel.FDRAccNumber);
                ClsCon.cmd.Parameters.AddWithValue("@PeriodValue", objFDModel.PeriodValue);
                ClsCon.cmd.Parameters.AddWithValue("@PeriodType", objFDModel.PeriodType);
                ClsCon.cmd.Parameters.AddWithValue("@Narration", objFDModel.Narration);
                ClsCon.cmd.Parameters.AddWithValue("@IsODLien", objFDModel.IsODLien);
                ClsCon.cmd.Parameters.AddWithValue("@User", objFDModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objFDModel.IP);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFD = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFD);
                dtFD.TableName = "success";
            }
            catch (Exception)
            {
                dtFD = new DataTable();
                dtFD.TableName = "error";
                return dtFD;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFD;
        }

        internal DataSet BindAll(FixedDepositModel objFDModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFixedDeposit";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objFDModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objFDModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objFDModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objFDModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objFDModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsFD = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsFD);
                dsFD.DataSetName = "success";
            }
            catch (Exception)
            {
                dsFD = new DataSet();
                dsFD.DataSetName = "error";
                return dsFD;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsFD;
        }
    }
}