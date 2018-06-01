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
    
    public class UpdDebitNoteVoucherController : ApiController
    {
        UpdDebitNoteDataAccess objUpdDebitNoteDA = new UpdDebitNoteDataAccess();

        [HttpPost]
        public DataSet BindAllDebitNoteDDL(UpdDebitNoteModel objUpdDNModel)
        {
            ///objDNModel.Ind = 11;

            DataSet dsDN = objUpdDebitNoteDA.BindAllDebitNote(objUpdDNModel);

            dsDN.Tables[0].TableName = "AccountHead";
            dsDN.Tables[1].TableName = "Narration";
            dsDN.Tables[2].TableName = "LastVoucherNo";
            dsDN.Tables[3].TableName = "ItemUnit";
            dsDN.Tables[4].TableName = "Issue Reason";
            return dsDN;
        }
        [HttpPost]
        public DataTable LoadPartyAccount(UpdDebitNoteModel objUpdDNModel)
        {
            DataTable dtPartyAccount = objUpdDebitNoteDA.LoadPartyAccount(objUpdDNModel);
            return dtPartyAccount;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdDebitNoteModel objUpdDNModel)
        {
            DataTable dtNarration = objUpdDebitNoteDA.FillGistnNo(objUpdDNModel);
            return dtNarration;
        }

        [HttpPost]
        public DataSet SearchData(UpdDebitNoteModel objUpdDNModel)
        {
            DataSet dsSearchdata = objUpdDebitNoteDA.SearchData(objUpdDNModel);
            return dsSearchdata;
        }

        [HttpPost]
        public DataTable UpdateDebitNote(UpdDebitNoteModel objUpdDNModel)
        {
            DataTable dtUpdDebitNote = objUpdDebitNoteDA.UpdateDebitNote(objUpdDNModel);
            return dtUpdDebitNote;
        }

        [HttpPost]
        public DataTable CancelVoucher(DebitNoteModel objDNModel)
        {
            DataTable dtCancel = objUpdDebitNoteDA.CancelVoucher(objDNModel);
            return dtCancel;
        }
    }
}
