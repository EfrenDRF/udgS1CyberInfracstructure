using Microsoft.AspNetCore.Mvc;
using _03_WebService.DataAcces;
using _03_WebService.Models;
using System.Collections.Generic;

namespace _03_WebService.Controllers
{
    [Route("api/[controller]")]

    public class catpersonalController : ControllerBase
    {

        private readonly IDataAccessProvider _dataAccessProvider;

        public catpersonalController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<catpersonal> Get()
        {
            return _dataAccessProvider.GetPersonal();
        }
    }
}