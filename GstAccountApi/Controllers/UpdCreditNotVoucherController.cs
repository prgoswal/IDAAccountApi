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
    public class UpdCreditNotVoucherController : ApiController
    {
        UpdCreditNoteDataAccess objUpdCnModel = new UpdCreditNoteDataAccess();
        [HttpPost]
        public DataSet BindAllCreditNoteDDL(UpdCreditNoteModel objUpdCNModel)
        {
            DataSet dsCN = objUpdCnModel.BindAllCreditNote(objUpdCNModel);
            return dsCN;
        }
        [HttpPost] 

        public DataTable LoadPartyAccount(UpdCreditNoteModel objUpdCNModel)
        {
            DataTable dtPartyAccount = objUpdCnModel.LoadPartyAccount(objUpdCNModel);
            return dtPartyAccount;
        }
        [HttpPost] 

        public DataTable FillGistnNo(UpdCreditNoteModel objUpdCNModel)
        {
            DataTable dtNarration = objUpdCnModel.FillGistnNo(objUpdCNModel);
            return dtNarration;
        }

        [HttpPost]
        public DataTable ItemsBinding(UpdCreditNoteModel objUpdCNModel)
        {
            DataTable dtItemsBinding = objUpdCnModel.ItemsBinding(objUpdCNModel);
            return dtItemsBinding;
        }

        [HttpPost]
        public DataSet SearchData(UpdCreditNoteModel objUpdCNModel)
        {
            DataSet dsSearchdata = objUpdCnModel.SearchData(objUpdCNModel);
            return dsSearchdata;
        }

        [HttpPost]
        public DataTable UpdateCreditNote(UpdCreditNoteModel objUpdCNModel)
        {
            DataTable dtUpdCreditNote = objUpdCnModel.UpdateCreditNote(objUpdCNModel);
            return dtUpdCreditNote;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdCreditNoteModel objUpdCNModel)
        {
            DataTable dtCancel = objUpdCnModel.CancelVoucher(objUpdCNModel);
            return dtCancel;
        }
    }
}
