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
        public IActionResult GetAllCatPersonal()
        {
            return Ok(_dataAccessProvider.GetAllCatPersonalRecords());
        }


        [HttpGet("{id}")]
        public IActionResult GetCatPersonal(int id)
        {
            return Ok(_dataAccessProvider.GetCatPersonalRecord(id));
        }

        [HttpPost]
        public IActionResult CreateCatPersonal([FromBody] CatPersonal catPerson)
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
                var created = _dataAccessProvider.InsertCatPersonalRecord(catPerson);
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
                _dataAccessProvider.UpdateCatPersonalRecord(catPerson);
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCatPersonal(int id)
        {
            _dataAccessProvider.DeleteCatPersonalRecord(new CatPersonal {Id = id});
            return NoContent();
        }

    }
}