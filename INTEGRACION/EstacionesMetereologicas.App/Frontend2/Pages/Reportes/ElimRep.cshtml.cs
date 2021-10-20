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
    public class ElimRepModel : PageModel
    {
        [BindProperty]
        public Reporte reporte{ get; set;}
        public IRepositorioReporte _repoReporte=new RepositorioReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());

        public IActionResult OnGet(int Id)
        {
           reporte = _repoReporte.GetReporteId(Id);
           if (reporte == null)
           {
             return RedirectToPage("../Error");
           }
           else
           return Page();
        }         

        public void OnPostEliminar(int Id)
        {
          _repoReporte.DeleteReporteId(Id);
        }
    }
}
