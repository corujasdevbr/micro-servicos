using System;
using CorujasDev.Identity.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CorujasDev.Identity.Infra.Data.Contexto
{
    public class UsuariosContexto : DbContext
    {
        public DbSet<UsuarioEntidade> Usuarios { get; set; }

        public UsuariosContexto()
        {
        }

        public UsuariosContexto(DbContextOptions<UsuariosContexto> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=192.168.3.54,1433;Initial Catalog=Senai_Vagas;user id=sa; password=Info@132");
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CorujasDev_Usuarios;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
