namespace TagliatoreWebApp.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Ordenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordenes()
        {
            this.DetalleOrdenes = new HashSet<DetalleOrdenes>();
        }

        [Display(Name = "#")]
        public int id_orden { get; set; }
        [Display(Name = "# de Cliente")]
        public Nullable<int> id_cliente { get; set; }
        [Display(Name = "# de mesero")]
        public Nullable<int> id_mesero { get; set; }
        [Display(Name = "# de Mesa ")]
        public int id_mesa { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
        [Display(Name = "Fecha de orden")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/DD/YY}")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> fecha_orden { get; set; }

        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrdenes> DetalleOrdenes { get; set; }
        public virtual Meseros Meseros { get; set; }
    }
}
