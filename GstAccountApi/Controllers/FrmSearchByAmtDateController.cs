using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GstAccountApi.Models.PL;
using GstAccountApi.Models.DL;

namespace GstAccountApi.Controllers
{
    public class FrmSearchByAmtDateController : ApiController
    {
        Dl_FrmSearchByAmtDate dlobjFrmSearchByAmtDate = new Dl_FrmSearchByAmtDate();
        [HttpPost]
        public DataTable Method_FrmSearchByAmtDate(Pl_FrmSearchByAmtDate plobjFrmSearchByAmtDate)
        {
            DataTable dtFrmSearchByAmtDate = dlobjFrmSearchByAmtDate.BindFrmSearchByAmtDate(plobjFrmSearchByAmtDate);
            return dtFrmSearchByAmtDate;
        }
    }
}
