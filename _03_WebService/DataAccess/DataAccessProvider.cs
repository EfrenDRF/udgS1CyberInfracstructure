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

        public List<catpersonal> GetAllCatPersonal()
        {
            return _context.catpesonales.ToList();
        }

        public catpersonal GetCatPersonalDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertCatPersonal(catpersonal catPerson)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCatPersonal(catpersonal catPerson)
        {
            throw new NotImplementedException();
        }
        public bool DeleteCatPersonal(catpersonal catPerson)
        {
            throw new NotImplementedException();
        }
    }
}