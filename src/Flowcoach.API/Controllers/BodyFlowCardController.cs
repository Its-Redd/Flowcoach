using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyFlowCardController(IRepository<BodyFlowCard> repository) : ControllerBase
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
        public IActionResult Post([FromBody] BodyFlowCard BodyFlowCard)
        {
            repository.Add(BodyFlowCard);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] BodyFlowCard BodyFlowCard)
        {
            repository.Update(BodyFlowCard);
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