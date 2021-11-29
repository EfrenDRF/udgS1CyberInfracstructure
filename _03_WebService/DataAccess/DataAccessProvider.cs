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

        public List<CatPersonal> GetAllCatPersonalRecords()
        {
            return _context.catpesonales.ToList();
        }

        public CatPersonal GetCatPersonalRecord(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertCatPersonalRecord(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCatPersonalRecord(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }
        public bool DeleteCatPersonalRecord(CatPersonal catPerson)
        {
            throw new NotImplementedException();
        }
    }
}