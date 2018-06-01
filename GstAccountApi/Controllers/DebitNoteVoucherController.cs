using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class DebitNoteVoucherController : ApiController
    {
        DebitNoteDataAccess objDNDA = new DebitNoteDataAccess();

        //[HttpPost]
        //public DataSet AllBindings(DebitNoteModel objDNModel)
        //{
        //    DataSet dsDebitNote = new DataSet();

        //    //objDNModel.Ind = 17;
        //    objDNModel.Ind = 39;
        //    DataTable dtAccountHead = objDNDA.AccountHead(objDNModel);
        //    dtAccountHead.TableName = "AccountHead";
        //    dsDebitNote.Tables.Add(dtAccountHead);
            
        //    objDNModel.Ind = 6;
        //    DataTable dtNarration = objDNDA.LoadNarration(objDNModel);
        //    dtNarration.TableName = "Narration";
        //    dsDebitNote.Tables.Add(dtNarration);

        //    objDNModel.Ind = 7;
        //    DataTable dtLastVoucherNo = objDNDA.LastVoucherNo(objDNModel);
        //    dtLastVoucherNo.TableName = "LastVoucherNo";
        //    dsDebitNote.Tables.Add(dtLastVoucherNo);

        //    return dsDebitNote;
        //}
        
        [HttpPost]
        public DataSet BindAllDebitNoteDDL(DebitNoteModel objDNModel)
        {
            ///objDNModel.Ind = 11;

            DataSet dsDN = objDNDA.BindAllDebitNote(objDNModel); 

            dsDN.Tables[0].TableName = "AccountHead";
            dsDN.Tables[1].TableName = "Narration";
            dsDN.Tables[2].TableName = "LastVoucherNo";
            dsDN.Tables[3].TableName = "ItemUnit";
            dsDN.Tables[4].TableName = "IssueReason";
            return dsDN;
        }

        [HttpPost]
        public DataTable LoadPartyAccount(DebitNoteModel objDNModel)
        {
            DataTable dtPartyAccount = objDNDA.LoadPartyAccount(objDNModel);
            return dtPartyAccount;
        }

        [HttpPost]
        public DataTable FillGistnNo(DebitNoteModel objDNModel)
        {
            DataTable dtNarration = objDNDA.FillGistnNo(objDNModel);
            return dtNarration;
        }

        [HttpPost]
        public DataTable ItemsBinding(DebitNoteModel objDNModel)
        {
            DataTable dtItemsBinding = objDNDA.ItemsBinding(objDNModel);
            return dtItemsBinding;
        }

        [HttpPost]
        public DataTable SaveDebitNote(DebitNoteModel objDNModel)
        {
            DataTable dtNarration = objDNDA.SaveDebitNote(objDNModel);
            return dtNarration;
        }
        
        
    }
}
