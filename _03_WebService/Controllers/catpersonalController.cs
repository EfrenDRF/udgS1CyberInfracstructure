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
            return Ok(_dataAccessProvider.GetAllCatPersonalRecords());
        }


        [HttpGet("{id}")]
        public IActionResult GetRecord(int id)
        {
            return Ok(_dataAccessProvider.GetCatPersonalRecord(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CatPersonal catPerson)
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
                _dataAccessProvider.InsertCatPersonalRecord(catPerson);
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] CatPersonal catPerson)
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
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var record = _dataAccessProvider.GetCatPersonalRecord(id);

            if (record == null)
            {
                return NotFound();
            }
            else
            {
                _dataAccessProvider.DeleteCatPersonalRecord(id);
                return Ok();
            }
        }

    }
}