using _03_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace _03_WebService.DataAcces
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public List<CatPersonal> GetAllCatPersonal()
        {
            return _context.catpesonales.ToList();
        }

        public CatPersonal GetCatPersonalDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertCatPersonal(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCatPersonal(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }
        public bool DeleteCatPersonal(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }
    }
}