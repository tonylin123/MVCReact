using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCData.Data;
using MVCData.ViewModels;
using MVCData.Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace MVCData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ReactController : ControllerBase
    {
        readonly ApplicationDBContext _context;

        public ReactController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people = _context.People.ToList();
            return people;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var person = _context.People.Find(id);

            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(404);
        }

        [HttpPost("create")]
        public IActionResult Create(JsonObject person)
        {
            string jsonPerson = person.ToString();

            Person personToCreate = JsonConvert.DeserializeObject<Person>(jsonPerson);

            if (personToCreate != null)
            {
                _context.People.Add(personToCreate);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(404);


        }
    }
}