﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep_Zoologiczny.BazaDanych
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SklepEntities : DbContext
    {
        public SklepEntities()
            : base("name=SklepEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Podkategorie> Podkategorie { get; set; }
        public virtual DbSet<Producenci> Producenci { get; set; }
        public virtual DbSet<Produkty> Produkty { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
