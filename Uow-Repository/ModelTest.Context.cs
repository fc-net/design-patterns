//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uow_Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PruebasEntities : DbContext
    {
        public PruebasEntities()
            : base("name=PruebasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departaments> Departaments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
