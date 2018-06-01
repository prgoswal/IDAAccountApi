using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class ItemGroupModel
    {
        public int Ind { get; set; }
        public string ItemGroup { get; set; }
        public string GroupPrimary { get; set; }
        public string ItemUnderGroup { get; set; }
    }
}