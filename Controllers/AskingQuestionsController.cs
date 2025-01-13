using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;

        public AskingQuestionsController (AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("NameAndTime/{name}/{time}")]
        public string NameAndTime(string name, int time)
        {
            return _askingQuestionsServices.NameAndTime(name, time);
        }
    }
}