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
            return _context.catpersonal.ToList();
        }

        public CatPersonal GetCatPersonalRecord(int id)
        {
            return _context.catpersonal.FirstOrDefault(t => t.id == id);
        }

        public void InsertCatPersonalRecord(CatPersonal catPerson)
        {
            _context.catpersonal.Add(catPerson);  
            _context.SaveChanges(); 
        }

        public void UpdateCatPersonalRecord(CatPersonal catPerson)
        {
            _context.catpersonal.Update(catPerson);  
            _context.SaveChanges(); 
        }
        public void DeleteCatPersonalRecord(int id)
        {
            var entity = _context.catpersonal.FirstOrDefault(t => t.id == id);  
            _context.catpersonal.Remove(entity);  
            _context.SaveChanges();  
        }
    }
}