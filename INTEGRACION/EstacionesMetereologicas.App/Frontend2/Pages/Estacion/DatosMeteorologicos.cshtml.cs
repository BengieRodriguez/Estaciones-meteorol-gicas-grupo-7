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
    public class DatosMeteorologicosModel : PageModel
    {
        public IRepositorioDataMeteorologica _repoDataMeteorologica=new RepositorioDataMeteorologica(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<DataMeteorologica> dataMeteorologica{ get; set; }
        public void OnGet()
        {       
            dataMeteorologica = _repoDataMeteorologica.GetAllDataMeteorologica();
        }
    }
}