//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARCH_TF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ing_hidrocarburos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ing_hidrocarburos()
        {
            this.repartidor = new HashSet<repartidor>();
        }
    
        public int id_ingeniero { get; set; }
        public string cedula_ingeniero { get; set; }
        public string nombres_ingeniero { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<repartidor> repartidor { get; set; }
    }
}
