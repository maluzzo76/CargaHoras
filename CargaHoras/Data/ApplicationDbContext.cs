using System.Collections.Generic;
using System.Reflection.Emit;
using CargaHoras.Model;
using Microsoft.EntityFrameworkCore;

namespace CargaHoras.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dimClientes>().ToTable("dimClientes", schema: "whs");
            modelBuilder.Entity<dimAreaFuncional>().ToTable("dimAreaFuncional", schema: "whs");
            modelBuilder.Entity<dimPatentes>().ToTable("dimPatentes", schema: "whs");
            modelBuilder.Entity<dimProductos>().ToTable("dimProductos", schema: "whs");
            modelBuilder.Entity<Tareas>().ToTable("factTareas", schema: "whs");
            modelBuilder.Entity<Configuracion>().ToTable("configch", schema: "dbo");
        }

        public DbSet<dimClientes> dimClientes{ get; set; }
        public DbSet<dimAreaFuncional> dimAreaFuncional { get; set; }
        public DbSet<dimPatentes> dimPatentes { get; set; }
        public DbSet<dimProductos> dimProductos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }  

    }
}
