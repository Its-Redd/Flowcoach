using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfcareArticleController(IRepository<SelfCareArticle> repository) : ControllerBase
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
        public IActionResult Post([FromBody] SelfCareArticle selfCareArticle)
        {
            repository.Add(selfCareArticle);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody] SelfCareArticle selfCareArticle)
        {
            repository.Update(selfCareArticle);
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
