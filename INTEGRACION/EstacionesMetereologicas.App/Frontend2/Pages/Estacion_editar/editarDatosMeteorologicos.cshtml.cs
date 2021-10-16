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
    public class editarDatosMeteorologicosModel : PageModel
    {
        [BindProperty]
        public DataMeteorologica datameteorologica{ get; set; }
        public IRepositorioDataMeteorologica _repoDataMeteorologica=new RepositorioDataMeteorologica(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IActionResult OnGet(int Id)
        {
           datameteorologica = _repoDataMeteorologica.GetDataMeteorologicaId(Id);
           if (datameteorologica == null)
           {
               return RedirectToPage("../Error");
           }
           else
           return Page();
        }

        public void OnPostEditar()
        {
            _repoDataMeteorologica.UpdateDataMeteorologica(datameteorologica);
        }
    }
}
