using _03_WebService.Models;
using System.Collections.Generic;


namespace _03_WebService.DataAcces
{
    /// Interface de acceso a metodos depersistencia

    public interface IDataAccessProvider
    {
        List<CatPersonal> GetAllCatPersonal();
        
        CatPersonal       GetCatPersonalDetails(int id);

        bool              InsertCatPersonal(CatPersonal catPerson);

        bool              UpdateCatPersonal(CatPersonal catPerson);
        bool              DeleteCatPersonal(CatPersonal catPerson);
    }
}