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
    public class crearNovedadesModel : PageModel
    {
        public static IRepositorioNovedades _repoNovedades=new RepositorioNovedades(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodNovedad, DateTime FechaNovedad, string ActNovedad, string ObsNovedad)
        {
            var novedades = new Novedades();
            novedades.Codigo_Estacion=CodNovedad;
            novedades.Fecha_Novedad=FechaNovedad;
            novedades.Actuacion=ActNovedad;
            novedades.Observacion=ObsNovedad;
            _repoNovedades.AddNovedades(novedades);
        }
    }
}
