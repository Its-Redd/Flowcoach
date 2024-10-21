using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowCoachCardController(IRepository<FlowcoachCard> repository) : ControllerBase
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
        public IActionResult Post([FromBody] FlowcoachCard FlowcoachCard)
        {
            repository.Add(FlowcoachCard);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] FlowcoachCard FlowcoachCard)
        {
            repository.Update(FlowcoachCard);
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
