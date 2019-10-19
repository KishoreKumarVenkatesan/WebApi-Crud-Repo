using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Crud.Models
{
    public class MVCSupplierModels
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MVCSupplierModels()
        {
            this.POMASTERs = new HashSet<MVCPOMasterModels>();
        }

        public string SUPLNO { get; set; }
        public string SUPLNAME { get; set; }
        public string SUPLADDR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MVCPOMasterModels> POMASTERs { get; set; }
    }
}