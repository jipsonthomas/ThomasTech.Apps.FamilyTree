﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThomasTech.Apps.FamilyTreeWebApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FamilyTreeEntities : DbContext
    {
        public FamilyTreeEntities()
            : base("name=FamilyTreeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MemberDate> MemberDates { get; set; }
        public virtual DbSet<MemberRelation> MemberRelations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}