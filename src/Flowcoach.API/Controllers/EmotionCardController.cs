﻿using FlowCoach.DataAccess;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Flowcoach.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmotionCardController(IRepository<EmotionCard> repository) : ControllerBase
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
        public IActionResult Post([FromBody] EmotionCard emotionCard)
        {
            repository.Add(emotionCard);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] EmotionCard emotionCard)
        {
            repository.Update(emotionCard);
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