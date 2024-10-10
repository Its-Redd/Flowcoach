using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController(IQuestionRepository questionRepository) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(questionRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(questionRepository.GetBy(id));

        }

        [HttpPost]
        public IActionResult Post([FromBody] Question question)
        {
            questionRepository.Add(question);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Question question)
        {
            questionRepository.Update(question);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            questionRepository.Delete(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetByCategory(QuestionCategory questionCategory)
        {
            return Ok(questionRepository.GetAllQuestionsWith(questionCategory));
        }

        [HttpGet]
        public IActionResult GetFirst5QuestionsWith(QuestionCategory questionCategory)
        {
            return Ok(questionRepository.GetFirst5QuestionsWith(questionCategory));
        }

        [HttpGet]
        public IActionResult GetNext5QuestionsWith(int lastQuestionId, QuestionCategory questionCategory)
        {
            return Ok(questionRepository.GetNext5QuestionsWith(lastQuestionId, questionCategory));
        }



    }
}

