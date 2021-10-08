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
    public class IngNuevoTRepModel : PageModel
    {
        public static IRepositorioTipoReporte _repoTipoReporte=new RepositorioTipoReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodTipoReporte,string DescripTipoReporte,string EstTipoReporte)
        {
            var tiporeporte = new TipoReporte();
            tiporeporte.Codigo=CodTipoReporte;
            tiporeporte.Nombre_TipoReporte=DescripTipoReporte;
            tiporeporte.Estado=EstTipoReporte;
            _repoTipoReporte.AddTipoReporte(tiporeporte);
        }
    }
}
