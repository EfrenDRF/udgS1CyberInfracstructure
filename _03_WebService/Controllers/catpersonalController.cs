using Microsoft.AspNetCore.Mvc;
using _03_WebService.DataAcces;
using _03_WebService.Models;
using System.Collections.Generic;

namespace _03_WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class catpersonalController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public catpersonalController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataAccessProvider.GetAllCatPersonal());
        }


        [HttpGet("{id}")]
        public IActionResult GetCatPersonalDetails(int id)
        {
            return Ok(_dataAccessProvider.GetCatPersonalDetails(id));
        }

        [HttpPost]
        public IActionResult CreatePersonal([FromBody] CatPersonal catPerson)
        {
            if (catPerson == null)
            {
                return BadRequest();
            }
            else if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var created = _dataAccessProvider.InsertCatPersonal(catPerson);
                return Created("Created", created);
            }
        }

        [HttpPut]
        public IActionResult UpdateCatPersonal([FromBody] CatPersonal catPerson)
        {
            if (catPerson == null)
            {
                return BadRequest();
            }
            else if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _dataAccessProvider.UpdateCatPersonal(catPerson);
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCatPersonal(int id)
        {
            _dataAccessProvider.DeleteCatPersonal(new CatPersonal {Id = id});
            return NoContent();
        }

    }
}