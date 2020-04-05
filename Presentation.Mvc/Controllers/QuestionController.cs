using Microsoft.AspNetCore.Mvc;
using Presentation.Mvc.Controllers.Actions;
using Presentation.Mvc.Models.Questions;
using System.Collections.Generic;

namespace Presentation.Mvc.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionAction _questionAction;

        public QuestionController(
            IQuestionAction questionAction)
        {
            _questionAction = questionAction;
        }

        // GET: api/Question
        [HttpGet]
        public IEnumerable<QuestionModel> Get()
        {
            return _questionAction.Get();
        }

        // POST: api/Question
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
