using EstacionesMetereologicas.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Actividad> Actividades { get; set; }

        public DbSet<Actuacion> Actuaciones { get; set; }

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<DatosMeteorologicos> DatosMeteorologicosRegistrados
        { get; set;
        }

        public DbSet<Estacion> Estacion { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Reporte> Reportes { get; set; }

        public DbSet<TipoReporte> TipoDeReportes { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AppMeteorologica");
            }
        }
    }
}
