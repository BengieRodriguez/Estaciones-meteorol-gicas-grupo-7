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
    public class EliminarCargosModel : PageModel
    {
        [BindProperty]
        public Cargo cargo{ get; set; }
        public IRepositorioCargo _repoCargo=new RepositorioCargo(new EstacionesMetereologicas.App.Persistencia.AppContext());

        public IActionResult OnGet(int Id)
        {
           cargo = _repoCargo.GetCargoId(Id);
           if (cargo == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

         public void OnPostEliminar(int Id)
        {
          _repoCargo.DeleteCargoId(Id);
        }
    }
}