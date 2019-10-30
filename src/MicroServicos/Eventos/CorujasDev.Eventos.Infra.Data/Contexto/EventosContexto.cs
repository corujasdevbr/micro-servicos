using CorujasDev.Eventos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CorujasDev.Eventos.Infra.Data.Contexto
{
    public class EventosContexto : DbContext
    {
        public DbSet<EventoEntidade> Eventos { get; set; }

        public EventosContexto()
        {
        }

        public EventosContexto(DbContextOptions<EventosContexto> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=192.168.3.54,1433;Initial Catalog=Senai_Eventos;user id=sa; password=Info@132");
                optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=CorujasDev_Eventos;user id=sa; password=Info@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
