﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practika.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Educational_practice_RybakovEntities3 : DbContext
    {
        public Educational_practice_RybakovEntities3()
            : base("name=Educational_practice_RybakovEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Applicationsss> Applicationsss { get; set; }
        public virtual DbSet<Audience> Audience { get; set; }
        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Educational_institution> Educational_institution { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Load> Load { get; set; }
        public virtual DbSet<Occupation_type> Occupation_type { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Selection_committee> Selection_committee { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
    }
}
