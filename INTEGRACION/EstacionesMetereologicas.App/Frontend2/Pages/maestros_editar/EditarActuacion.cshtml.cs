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
    public class EditarActuacionModel : PageModel
    {
        [BindProperty]
        public Actuacion actuacion{ get; set; }
        public IRepositorioActuacion _repoActuacion=new RepositorioActuacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           actuacion = _repoActuacion.GetActuacionId(Id);
           if (actuacion == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoActuacion.UpdateActuacion(actuacion);
        }
    }
}