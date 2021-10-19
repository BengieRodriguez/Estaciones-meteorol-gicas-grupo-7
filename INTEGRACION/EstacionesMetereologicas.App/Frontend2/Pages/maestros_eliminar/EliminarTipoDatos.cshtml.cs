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
    public class EliminarTipoDatosModel : PageModel
    {
        [BindProperty]
        public TipoDeDatos tipodedatos{ get; set; }
        public IRepositorioTipoDeDatos _repoTipoDeDatos=new RepositorioTipoDeDatos(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           tipodedatos = _repoTipoDeDatos.GetTipoDeDatosId(Id);
           if (tipodedatos == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEliminar(int Id)
        {
            _repoTipoDeDatos.DeleteTipoDeDatosId(Id);
        }
    }
}
