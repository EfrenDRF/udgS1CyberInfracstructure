using _03_WebService.Models;
using System.Collections.Generic;


namespace _03_WebService.DataAcces
{
    /// Interface de acceso a metodos depersistencia

    public interface IDataAccessProvider
    {
        List<catpersonal> GetPersonal();
    }
}