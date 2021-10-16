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
    public class editarNovedadesModel : PageModel
    {
        [BindProperty]
        public Novedades novedades{ get; set; }
        public IRepositorioNovedades _repoNovedades=new RepositorioNovedades(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           novedades = _repoNovedades.GetNovedadesId(Id);
           if (novedades == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoNovedades.UpdateNovedades(novedades);
        }
    }
}
