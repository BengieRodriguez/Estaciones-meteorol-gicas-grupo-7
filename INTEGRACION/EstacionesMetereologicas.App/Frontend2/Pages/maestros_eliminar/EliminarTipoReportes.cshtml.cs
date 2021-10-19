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
    public class EliminarTipoReportesModel : PageModel
    {
        [BindProperty]
        public TipoReporte tipoReporte{ get; set; }
        public IRepositorioTipoReporte _repoTipoReporte=new RepositorioTipoReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           tipoReporte = _repoTipoReporte.GetTipoReporteId(Id);
           if (tipoReporte == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEliminar(int Id)
        {
            _repoTipoReporte.DeleteTipoReporteId(Id);
        }
    }
}
