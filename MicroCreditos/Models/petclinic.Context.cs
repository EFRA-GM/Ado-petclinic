﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MicroCreditos.Models
{
    public partial class AzureSQLPetclinicEntities1 : DbContext
    {
        public AzureSQLPetclinicEntities1()
        : this("name=AzureSQLPetclinicEntities1")
        {
        }

        public AzureSQLPetclinicEntities1(String nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Duenos_Grid> Duenos_Grid { get; set; }
        public virtual DbSet<Dueno> Duenoes { get; set; }
        public virtual DbSet<Mascota> Mascotas { get; set; }
        public virtual DbSet<Tipo> Tipoes { get; set; }
        public virtual DbSet<Veterinario> Veterinarios { get; set; }
        public virtual DbSet<Veterinario_Especialidad> Veterinario_Especialidad { get; set; }
    }
}
