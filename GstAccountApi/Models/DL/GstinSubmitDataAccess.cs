using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class GstinSubmitDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtGstinSubmit;
        DataSet dsGstinSubmit;

        internal DataSet FillGridGstinSubmit(GstinSubmitModel ObjGSTINSubmitModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR1";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGSTINSubmitModel.ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGSTINSubmitModel.OrgID);
                // ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjClientGSTINModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGSTINSubmitModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGSTINSubmitModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGSTINSubmitModel.TaxYear);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstinSubmit = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstinSubmit);
                dsGstinSubmit.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstinSubmit = new DataSet();
                dsGstinSubmit.DataSetName = "error";
                return dsGstinSubmit;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstinSubmit;
        }

        internal DataTable GstinSubmitProcess(GstinSubmitModel ObjGSTINSubmitModel)
        {
            #region Old
            //try
            //{
            //    ClsCon.cmd = new SqlCommand();
            //    ClsCon.cmd.CommandType = CommandType.StoredProcedure;
            //    ClsCon.cmd.CommandText = "SPGSTR1";

            //    ClsCon.cmd.CommandType = CommandType.StoredProcedure;
            //    ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGSTINSubmitModel.ind);
            //    ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGSTINSubmitModel.OrgID);
            //    //ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjGSTINSubmitModel.ItemID);
            //    ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGSTINSubmitModel.BrID);
            //    ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGSTINSubmitModel.GSTIN);
            //    ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGSTINSubmitModel.TaxYear);
            //    ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);
            //    ClsCon.cmd.Parameters.AddWithValue("@LineNo", ObjGSTINSubmitModel.LineNo);
            //    ClsCon.cmd.Parameters.AddWithValue("@ExcelNo", ObjGSTINSubmitModel.ExcelNo);
            //    ClsCon.cmd.Parameters.AddWithValue("@ImportDate", ObjGSTINSubmitModel.ImportDate);
            //    ClsCon.cmd.Parameters.AddWithValue("@CACode", ObjGSTINSubmitModel.CACode);
            //    ClsCon.cmd.Parameters.AddWithValue("@CACodeODP", ObjGSTINSubmitModel.CACodeODP);
            //    ClsCon.cmd.Parameters.AddWithValue("@BillGSTNType", ObjGSTINSubmitModel.BillGSTNType);
            //    ClsCon.cmd.Parameters.AddWithValue("@BillName", ObjGSTINSubmitModel.BillName);
            //    ClsCon.cmd.Parameters.AddWithValue("@ShippedGSTNNo", ObjGSTINSubmitModel.ShippedGSTNNo);
            //    ClsCon.cmd.Parameters.AddWithValue("@ShippedGSTNType", ObjGSTINSubmitModel.ShippedGSTNType);
            //    ClsCon.cmd.Parameters.AddWithValue("@ShippedName", ObjGSTINSubmitModel.ShippedName);
            //    ClsCon.cmd.Parameters.AddWithValue("@EcommerceDesc", ObjGSTINSubmitModel.EcommerceDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@ECommGSTNNo", ObjGSTINSubmitModel.ECommGSTNNo);
            //    ClsCon.cmd.Parameters.AddWithValue("@GSDesc", ObjGSTINSubmitModel.GSDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemCode", ObjGSTINSubmitModel.ItemCode);
            //    ClsCon.cmd.Parameters.AddWithValue("@HSNSacDesc", ObjGSTINSubmitModel.HSNSacDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemTypeCode", ObjGSTINSubmitModel.ItemTypeCode);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemIGSTOth1", ObjGSTINSubmitModel.ItemIGSTOth1);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemIGSTOth2", ObjGSTINSubmitModel.ItemIGSTOth2);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemICGSTOth1", ObjGSTINSubmitModel.ItemICGSTOth1);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemICGSTOth2", ObjGSTINSubmitModel.ItemICGSTOth2);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemISGSTOth1", ObjGSTINSubmitModel.ItemISGSTOth1);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemISGSTOth2", ObjGSTINSubmitModel.ItemISGSTOth2);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemTotTaxPaid", ObjGSTINSubmitModel.ItemTotTaxPaid);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemTotTaxPaidoth1", ObjGSTINSubmitModel.ItemTotTaxPaidoth1);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemTotTaxPaidoth2", ObjGSTINSubmitModel.ItemTotTaxPaidoth2);
            //    ClsCon.cmd.Parameters.AddWithValue("@ReverseChargeDesc", ObjGSTINSubmitModel.ReverseChargeDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemReversePer", ObjGSTINSubmitModel.ItemReversePer);
            //    ClsCon.cmd.Parameters.AddWithValue("@ItemReverseAmt", ObjGSTINSubmitModel.ItemReverseAmt);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank1", ObjGSTINSubmitModel.Blank1);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank2", ObjGSTINSubmitModel.Blank2);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank3", ObjGSTINSubmitModel.Blank3);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank4", ObjGSTINSubmitModel.Blank4);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank5", ObjGSTINSubmitModel.Blank5);
            //    ClsCon.cmd.Parameters.AddWithValue("@Blank6", ObjGSTINSubmitModel.Blank6);
            //    ClsCon.cmd.Parameters.AddWithValue("@AdvanceSaleDesc", ObjGSTINSubmitModel.AdvanceSaleDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@AdvREcvOrAdjustDesc", ObjGSTINSubmitModel.AdvREcvOrAdjustDesc);
            //    ClsCon.cmd.Parameters.AddWithValue("@ZeroDeemedSezCode", ObjGSTINSubmitModel.ZeroDeemedSezCode);
            //    ClsCon.cmd.Parameters.AddWithValue("@ErrorInd", ObjGSTINSubmitModel.ErrorInd);
            //   // ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);


            //    con = ClsCon.SqlConn();
            //    ClsCon.cmd.Connection = con;
            //    dtGstinSubmit = new DataTable();
            //    ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
            //    ClsCon.da.Fill(dtGstinSubmit);
            //    dtGstinSubmit.TableName = "success";
            //}
            //catch (Exception)
            //{
            //    dtGstinSubmit = new DataTable();
            //    dtGstinSubmit.TableName = "error";
            //    return dtGstinSubmit;
            //}
            //finally
            //{
            //    con.Close();
            //    con.Dispose();
            //    ClsCon.da.Dispose();
            //    ClsCon.cmd.Dispose();
            //}
            #endregion
            return dtGstinSubmit;
        }

        internal DataSet FillGSTR1(GstinSubmitModel ObjGSTINSubmitModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR1TabularDetail";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGSTINSubmitModel.ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGSTINSubmitModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGSTINSubmitModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGSTINSubmitModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjGSTINSubmitModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGSTINSubmitModel.TaxYear);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstinSubmit = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstinSubmit);
                dsGstinSubmit.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstinSubmit = new DataSet();
                dsGstinSubmit.DataSetName = "error";
                return dsGstinSubmit;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstinSubmit;
        }

        internal DataSet GetExcelData(GstinSubmitModel ObjGstinSubmitModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR1TabularDetailForExcel";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGstinSubmitModel.ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGstinSubmitModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGstinSubmitModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGstinSubmitModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjGstinSubmitModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGstinSubmitModel.TaxMonth);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGstinSubmitModel.TaxYear);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstinSubmit = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstinSubmit);
                dsGstinSubmit.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstinSubmit = new DataSet();
                dsGstinSubmit.DataSetName = "error";
                return dsGstinSubmit;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstinSubmit;
        }

        internal DataSet FillGSTR2(GstinSubmitModel ObjGSTINSubmitModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR2TabularDetail";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGSTINSubmitModel.ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGSTINSubmitModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGSTINSubmitModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGSTINSubmitModel.GSTIN);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjGSTINSubmitModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGSTINSubmitModel.TaxYear);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstinSubmit = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstinSubmit);
                dsGstinSubmit.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstinSubmit = new DataSet();
                dsGstinSubmit.DataSetName = "error";
                return dsGstinSubmit;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstinSubmit;
        }

        internal DataSet FillGridGSTR2(GstinSubmitModel ObjGSTINSubmitModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR2";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjGSTINSubmitModel.ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjGSTINSubmitModel.OrgID);
                // ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjClientGSTINModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjGSTINSubmitModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjGSTINSubmitModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", ObjGSTINSubmitModel.TaxYear);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", ObjGSTINSubmitModel.TaxMonth);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstinSubmit = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstinSubmit);
                dsGstinSubmit.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstinSubmit = new DataSet();
                dsGstinSubmit.DataSetName = "error";
                return dsGstinSubmit;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstinSubmit;
        }
    }
}