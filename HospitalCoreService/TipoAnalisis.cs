//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalCoreService
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoAnalisis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAnalisis()
        {
            this.Analisis = new List<Analisis>();
        }
    
        public int IdTipoAnalisis { get; set; }
        public string TipoAnalisis1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Analisis> Analisis { get; set; }
    }
}
