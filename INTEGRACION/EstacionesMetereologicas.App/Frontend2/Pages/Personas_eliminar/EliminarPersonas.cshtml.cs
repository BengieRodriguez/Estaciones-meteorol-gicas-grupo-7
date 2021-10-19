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
    public class EliminarPersonasModel : PageModel
    {
        [BindProperty]
        public Persona persona{ get; set; }
        public IRepositorioPersona _repoPersona=new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           persona = _repoPersona.GetPersonaId(Id);
           if (persona == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEliminar(int Id)
        {
            _repoPersona.DeletePersonaId(Id);
        }
    }
}
