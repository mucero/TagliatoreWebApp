//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TagliatoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleOrdenes
    {
        public int id_detalle { get; set; }
        public int id_orden { get; set; }
        public int id_platillo { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
    
        public virtual Ordenes Ordenes { get; set; }
        public virtual Platillos Platillos { get; set; }
    }
}
