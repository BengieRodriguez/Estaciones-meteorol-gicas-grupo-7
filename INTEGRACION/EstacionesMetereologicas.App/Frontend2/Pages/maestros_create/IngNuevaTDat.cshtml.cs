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
    public class IngNuevaTDatModel : PageModel
    {
        public static IRepositorioTipoDeDatos _repoTipoDeDatos=new RepositorioTipoDeDatos(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodTipoDeDatos,string DescripTipoDeDatos,string EstTipoDeDatos)
        {
            var tipodedatos = new TipoDeDatos();
            tipodedatos.Codigo=CodTipoDeDatos;
            tipodedatos.Descripcion=DescripTipoDeDatos;
            tipodedatos.Estado=EstTipoDeDatos;
            _repoTipoDeDatos.AddTipoDeDatos(tipodedatos);
        }
    }
}
