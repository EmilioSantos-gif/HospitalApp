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
    
    public partial class Procedimiento
    {
        public int IdProcedimiento { get; set; }
        public int NumHistMedico { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal Monto { get; set; }
        public int TipoProcedimiento { get; set; }
        public string Pago { get; set; }
    
        public virtual TipoProcedimiento TipoProcedimiento1 { get; set; }
    }
}