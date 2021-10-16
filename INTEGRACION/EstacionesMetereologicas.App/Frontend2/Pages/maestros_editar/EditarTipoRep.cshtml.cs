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
    public class EditarTipoRepModel : PageModel
    {
        [BindProperty]
        public TipoReporte tiporeporte{ get; set; }
        public IRepositorioTipoReporte _repoTipoReporte=new RepositorioTipoReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           tiporeporte = _repoTipoReporte.GetTipoReporteId(Id);
           if (tiporeporte == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoTipoReporte.UpdateTipoReporte(tiporeporte);
        }
    }
}
