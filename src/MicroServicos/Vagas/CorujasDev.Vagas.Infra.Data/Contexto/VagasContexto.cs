using Microsoft.EntityFrameworkCore;
using CorujasDev.Vagas.Dominio.Entidades;

namespace CorujasDev.Vagas.Infra.Data.Contexto
{
    public class VagasContexto : DbContext
    {
        public DbSet<VagaEntidade> Vagas { get; set; }

        public VagasContexto()
        {
        }

        public VagasContexto(DbContextOptions<VagasContexto> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=192.168.3.54,1433;Initial Catalog=Senai_Vagas;user id=sa; password=Info@132");
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=CorujasDev_Vagas;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

