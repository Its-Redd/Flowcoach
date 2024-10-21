using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController(IRepository<JournalEntry> repository) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetBy(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] JournalEntry journalEntry)
        {
            repository.Add(journalEntry);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] JournalEntry journalEntry)
        {
            repository.Update(journalEntry);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok();
        }
    }
}
