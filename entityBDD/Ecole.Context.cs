﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityBDD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EcolesEntities : DbContext
    {
        public EcolesEntities()
            : base("name=EcolesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Eleve> Eleve { get; set; }
        public DbSet<Matiere> Matiere { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
