using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstacionesMetereologicas.App.Persistencia;
using EstacionesMetereologicas.App.Dominio;

namespace FrontEnd2.Pages
{
    public class TipoReportesModel : PageModel
    {
        public IRepositorioTipoReporte _repoTipoReporte=new RepositorioTipoReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<TipoReporte> tipoReporte{ get; set; }
        public void OnGet()
        {       
            tipoReporte = _repoTipoReporte.GetAllTipoReporte();
        }
    }
}
