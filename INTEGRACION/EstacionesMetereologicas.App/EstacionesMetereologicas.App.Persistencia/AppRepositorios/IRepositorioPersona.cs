using System;
using System.Collections.Generic;
using System.Linq;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        Persona GetPersona(string identificacionpersona);

        Persona DeletePersona(string identificacionpersona);

        Persona GetPersonaId(int idPersona);

        Persona DeletePersonaId(int idPersona);
    }
}