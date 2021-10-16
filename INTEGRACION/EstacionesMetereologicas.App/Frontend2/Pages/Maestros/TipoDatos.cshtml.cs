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
    public class TipoDatosModel : PageModel
    {
        public IRepositorioTipoDeDatos _repoTipoDeDatos=new RepositorioTipoDeDatos(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<TipoDeDatos> tipodedatos {get; set;}
        public void OnGet()
        {
            tipodedatos=_repoTipoDeDatos.GetAllTipoDeDatos();
        }
    }
}
