using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EstacionesMetereologicas.App.Dominio;
using EstacionesMetereologicas.App.Persistencia;

namespace Frontend2
{
    public class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());

        public static IRepositorioValidacion _repoValidacion=new RepositorioValidacion(new EstacionesMetereologicas.App.Persistencia.AppContext());

        public static IRepositorioAdministrador _repoAdministrador= new RepositorioAdministrador(new EstacionesMetereologicas.App.Persistencia.AppContext());

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //InsertarAdministrador();
            //InsertarValidacion();
        }

        private static void InsertarAdministrador()
        {
            var p=new Administrador
            {
                Identificacion="1111",
                Nombres="Stiven",
                Apellidos="Atis",
                Genero="masculino",
                Estado='A',
                Password=12345,
                Rol="Admin de perfiles"
            };
            _repoAdministrador.AddAdministrador(p);
        }
        private static void InsertarValidacion()
        {
            var p=new Validacion
            {
                Val=0
            };
            _repoValidacion.AddValidacion(p);
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
