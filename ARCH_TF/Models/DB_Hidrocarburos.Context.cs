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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_HidrocarburosEntities : DbContext
    {
        public DB_HidrocarburosEntities()
            : base("name=DB_HidrocarburosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<asignacion_ruta> asignacion_ruta { get; set; }
        public virtual DbSet<coche_repartidor> coche_repartidor { get; set; }
        public virtual DbSet<creacion_usuario> creacion_usuario { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<estado_coche> estado_coche { get; set; }
        public virtual DbSet<estado_formulario> estado_formulario { get; set; }
        public virtual DbSet<form_registro> form_registro { get; set; }
        public virtual DbSet<formularios> formularios { get; set; }
        public virtual DbSet<ing_hidrocarburos> ing_hidrocarburos { get; set; }
        public virtual DbSet<proceso_registro> proceso_registro { get; set; }
        public virtual DbSet<repartidor> repartidor { get; set; }
        public virtual DbSet<ruta_ciudad> ruta_ciudad { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipo_empleado> tipo_empleado { get; set; }
        public virtual DbSet<tipo_formulario> tipo_formulario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<zona_ciudad> zona_ciudad { get; set; }
        public virtual DbSet<proceso_formularios> proceso_formularios { get; set; }
    }
}
