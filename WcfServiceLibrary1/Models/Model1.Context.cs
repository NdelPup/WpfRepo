﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dballarmiEntities : DbContext
    {
        public dballarmiEntities()
            : base("name=dballarmiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnaOperatori> AnaOperatori { get; set; }
        public virtual DbSet<AnaSensori> AnaSensori { get; set; }
        public virtual DbSet<Luoghi> Luoghi { get; set; }
        public virtual DbSet<SensoriLuogo> SensoriLuogo { get; set; }
        public virtual DbSet<StoricoAllarmi> StoricoAllarmi { get; set; }
        public virtual DbSet<TipiSensori> TipiSensori { get; set; }
    }
}
