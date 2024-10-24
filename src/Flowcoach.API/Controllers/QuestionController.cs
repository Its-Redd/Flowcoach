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
            try
            {
                return Ok(questionRepository.GetAll());
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
                return Ok(questionRepository.GetBy(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Question question)
        {
            try
            {
                questionRepository.Add(question);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Question question)
        {
            try
            {
                questionRepository.Update(question);
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
                questionRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetByCategory(QuestionCategory questionCategory)
        {
            try
            {
                return Ok(questionRepository.GetAllQuestionsWith(questionCategory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetFirst5QuestionsWith(QuestionCategory questionCategory)
        {
            try
            {
                return Ok(questionRepository.GetFirst5QuestionsWith(questionCategory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetNext5QuestionsWith(int lastQuestionId, QuestionCategory questionCategory)
        {
            try
            {
                return Ok(questionRepository.GetNext5QuestionsWith(lastQuestionId, questionCategory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

