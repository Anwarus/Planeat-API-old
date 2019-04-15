using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Planeat.Controllers
{
    [Route("api/recipt")]
    public class ReciptController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        
        public ReciptController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllRecipts()
        {
            try
            {
                var recipts = _repository.Recipt.GetAllRecipts();

                _logger.LogInfo("Returned all recipts from database");

                return Ok(recipts);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllRecipts action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "ReciptById")]
        public IActionResult GetReciptById(int id)
        {
            try
            {
                var recipt = _repository.Recipt.GetReciptById(id);

                if(recipt == null)
                {
                    _logger.LogError($"Recipt with id: {id}, hasn't been found in data source");

                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned recipt with id: {id}");

                    return Ok(recipt);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetReciptById action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult CreateRecipt([FromBody]Recipt recipt)
        {
            try
            {
                if(recipt == null)
                {
                    _logger.LogError("Recipt object sent from client is null");
                    return BadRequest("Recipt object is null");
                }

                if(!ModelState.IsValid)
                {
                    _logger.LogError("Invalid recipt object sent from client");
                    return BadRequest("Invalid recipt object");
                }

                _repository.Recipt.CreateRecipt(recipt);

                return CreatedAtRoute("ReciptById", new { id = recipt.Id }, recipt);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
