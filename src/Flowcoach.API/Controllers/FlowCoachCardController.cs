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
            try
            {
                return Ok(repository.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(repository.GetBy(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] FlowcoachCard FlowcoachCard)
        {
            try
            {
                repository.Add(FlowcoachCard);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] FlowcoachCard FlowcoachCard)
        {
            try
            {
                repository.Update(FlowcoachCard);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
