using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Crud.Models
{
    public class MVCPOMasterModels
    {
        public string PONO { get; set; }
        public Nullable<System.DateTime> PODATE { get; set; }
        public string SUPLNO { get; set; }

        public virtual MVCSupplierModels SUPPLIER { get; set; }
    }
}