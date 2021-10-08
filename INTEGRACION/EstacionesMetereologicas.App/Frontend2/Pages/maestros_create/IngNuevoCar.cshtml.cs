using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstacionesMetereologicas.App.Dominio;
using EstacionesMetereologicas.App.Persistencia;

namespace FrontEnd2.Pages
{
    public class IngNuevoCarModel : PageModel
    {
        public static IRepositorioCargo _repoCargo=new RepositorioCargo(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodCargo,string DescripCargo,string EstCargo)
        {
            var cargo = new Cargo();
            cargo.Codigo=CodCargo;
            cargo.Descripcion=DescripCargo;
            cargo.Estado=EstCargo;
            _repoCargo.AddCargo(cargo);
        }
    }
}
