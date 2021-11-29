using _03_WebService.Models;
using System.Collections.Generic;


namespace _03_WebService.DataAcces
{
    /// Interface de acceso a metodos depersistencia

    public interface IDataAccessProvider
    {
        List<catpersonal> GetAllCatPersonal();
        
        catpersonal       GetCatPersonalDetails(int id);

        bool              InsertCatPersonal(catpersonal catPerson);

        bool              UpdateCatPersonal(catpersonal catPerson);
        bool              DeleteCatPersonal(catpersonal catPerson);
    }
}