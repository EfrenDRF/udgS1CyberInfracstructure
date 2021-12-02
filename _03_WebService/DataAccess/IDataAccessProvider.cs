using _03_WebService.Models;
using System.Collections.Generic;


namespace _03_WebService.DataAcces
{
    /// Interface de acceso a metodos depersistencia

    public interface IDataAccessProvider
    {
        List<CatPersonal> GetAllCatPersonalRecords();
        
        CatPersonal       GetCatPersonalRecord(int id);

        void              InsertCatPersonalRecord(CatPersonal catPerson);

        void              UpdateCatPersonalRecord(CatPersonal catPerson);
        void              DeleteCatPersonalRecord(int id);
    }
}