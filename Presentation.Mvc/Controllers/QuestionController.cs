using Application.Questions.Models;
using Application.Services.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Presentation.Mvc.Controllers
{
    using System.Linq;

    using Application.Services.Questions.Contractors;

    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(
            IQuestionService questionService)
        {
            _questionService = questionService;
        }

        // GET: api/Question
        [HttpGet]
        public IEnumerable<QuestionModel> Get()
        {
            return _questionService.Get().QuestionModels;
        }

        // POST: api/Question
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Question/5
        [HttpGet("{questionCode}")]
        public QuestionModel GetDetails(string questionCode)
        {
            return _questionService.Get(questionCode).QuestionModels.FirstOrDefault();
        }
    }
}
