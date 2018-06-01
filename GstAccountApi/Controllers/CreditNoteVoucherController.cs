using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class CreditNoteVoucherController : ApiController
    {
        CreditNoteDataAccess objCNDA = new CreditNoteDataAccess();

        //[HttpPost]
        //public DataSet AllBindings(CreditNoteModel objCNModel)
        //{
        //    DataSet dsCreditNote = new DataSet();

        //    //objCNModel.Ind = 17;
        //    objCNModel.Ind = 39;
        //    DataTable dtAccountHead = objCNDA.AccountHead(objCNModel);
        //    dtAccountHead.TableName = "AccountHead";
        //    dsCreditNote.Tables.Add(dtAccountHead);

        //    //objCNModel.Ind = 18;
        //    //DataTable dtParty = objCNDA.PartyAccount(objCNModel);
        //    //dtParty.TableName = "Party";
        //    //dsCreditNote.Tables.Add(dtParty);

        //    objCNModel.Ind = 6;
        //    DataTable dtNarration = objCNDA.LoadNarration(objCNModel);
        //    dtNarration.TableName = "Narration";
        //    dsCreditNote.Tables.Add(dtNarration);

        //    objCNModel.Ind = 7;
        //    DataTable dtLastVoucherNo = objCNDA.LastVoucherNo(objCNModel);
        //    dtLastVoucherNo.TableName = "LastVoucherNo";
        //    dsCreditNote.Tables.Add(dtLastVoucherNo);

        //    return dsCreditNote;
        //} 

        [HttpPost]
        public DataSet BindAllCreditNoteDDL(DebitNoteModel objDNModel)
        {
            DataSet dsCN = objCNDA.BindAllCreditNote(objDNModel);
            return dsCN;
        }
        [HttpPost]
        public DataTable LoadPartyAccount(CreditNoteModel objDNModel)
        {
            DataTable dtPartyAccount = objCNDA.LoadPartyAccount(objDNModel);
            return dtPartyAccount;
        }
        [HttpPost]
        public DataTable FillGistnNo(CreditNoteModel objCNModel)
        {
            DataTable dtNarration = objCNDA.FillGistnNo(objCNModel);
            return dtNarration;
        }

        [HttpPost]
        public DataTable ItemsBinding(DebitNoteModel objDNModel)
        {
            DataTable dtItemsBinding = objCNDA.ItemsBinding(objDNModel);
            return dtItemsBinding;
        }

        [HttpPost]
        public DataTable SaveCreditNote(CreditNoteModel objCNModel)
        {
            DataTable dtNarration = objCNDA.SaveCreditNote(objCNModel);
            return dtNarration;
        }
    }
}
