using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstacionesMetereologicas.App.Dominio;
using EstacionesMetereologicas.App.Persistencia;

namespace FrontEnd2.Pages
{
    public class FichaEstacionModel : PageModel
    {
        public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodEstacion,string NameEstacion,DateTime FechaEstacion, int LatEstacion, int LonEstacion, string MuniEstacion)
        {
            var estacion = new Estacion();
            estacion.Codigo_Estacion=CodEstacion;
            estacion.Nombre_Estacion=NameEstacion;
            estacion.Fecha_Montaje=FechaEstacion;
            estacion.Latitud=LatEstacion;
            estacion.Longitud=LonEstacion;
            estacion.Municipio=MuniEstacion;
            _repoEstacion.AddEstacion(estacion);
        }
    }
}
