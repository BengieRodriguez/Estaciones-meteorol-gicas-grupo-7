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
    public class EditMantTecnModel : PageModel
    {
        [BindProperty]
        public Reporte reportes{ get; set; }
        public IRepositorioReporte _repoReportes=new RepositorioReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           reportes = _repoReportes.GetReporteId(Id);
           if (reportes == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoReportes.UpdateReporte(reportes);
        }
    }
}
