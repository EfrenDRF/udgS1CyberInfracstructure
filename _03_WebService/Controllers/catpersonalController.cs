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
        public ActionResult<IEnumerable<CatPersonal>> Get()
        {
            return Ok(_dataAccessProvider.GetAllCatPersonalRecords());
        }


        [HttpGet("{id}")]
        public ActionResult<CatPersonal> GetRecord(int id)
        {
            var record = _dataAccessProvider.GetCatPersonalRecord(id);

            if (record == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(record);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CatPersonal catPerson)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.InsertCatPersonalRecord(catPerson);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState); 
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] CatPersonal catPerson)
        {
            if (ModelState.IsValid)  
            {  
                _dataAccessProvider.UpdateCatPersonalRecord(catPerson);
                return Ok();  
            }  
            return BadRequest();  
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