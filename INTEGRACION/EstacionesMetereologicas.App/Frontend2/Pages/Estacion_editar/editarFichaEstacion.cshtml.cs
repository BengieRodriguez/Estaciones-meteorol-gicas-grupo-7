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
    public class editarFichaEstacionModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{ get; set; }
        public IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           estacion = _repoEstacion.GetEstacionId(Id);
           if (estacion == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoEstacion.UpdateEstacion(estacion);
        }
    }
}