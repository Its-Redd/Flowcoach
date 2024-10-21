using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyFlowArticleController(IRepository<BodyFlowArticle> repository) : ControllerBase
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
        public IActionResult Post([FromBody] BodyFlowArticle BodyFlowArticle)
        {
            repository.Add(BodyFlowArticle);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] BodyFlowArticle BodyFlowArticle)
        {
            repository.Update(BodyFlowArticle);
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
