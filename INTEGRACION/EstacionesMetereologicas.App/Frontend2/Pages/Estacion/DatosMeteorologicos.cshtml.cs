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
    public class DatosMeteorologicosModel : PageModel
    {
        public static IRepositorioDataMeteorologica _repoDataMeteorologica=new RepositorioDataMeteorologica(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodDataMeteorologica,string NameDataMeteorologica,DateTime FechaDataMeteorologica, string TemDataMeteorologica, string HumDataMeteorologica
        , string PresAtDataMeteorologica, string VientoDataMeteorologica, string PluvDataMeteorologica, string RadDataMeteorologica)
        {
            var datameteorologica = new DataMeteorologica();
            datameteorologica.Codigo_Estacion=CodDataMeteorologica;
            datameteorologica.Nombre_Estacion=NameDataMeteorologica;
            datameteorologica.Fecha=FechaDataMeteorologica;
            datameteorologica.Temperatura=TemDataMeteorologica;
            datameteorologica.Humedad=HumDataMeteorologica;
            datameteorologica.Presion_Atmosferica=PresAtDataMeteorologica;
            datameteorologica.Velocidad_Viento=VientoDataMeteorologica;
            datameteorologica.Pluviosidad=PluvDataMeteorologica;
            datameteorologica.Radiacion_Solar=RadDataMeteorologica;
            _repoDataMeteorologica.AddDataMeteorologica(datameteorologica);
        }
    }
}

//Comentario