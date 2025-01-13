using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;
        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("GuessItEasy/{guess}")]
        public string GuessItEasy(string guess)
        {
            return _guessItServices.GuessItEasy(guess);
        }

        [HttpGet]
        [Route("GuessItMedium/{guess}")]
        public string GuessItMedium(string guess)
        {
            return _guessItServices.GuessItMedium(guess);
        }

        [HttpGet]
        [Route("GuessItHard/{guess}")]
        public string GuessItHard(string guess)
        {
            return _guessItServices.GuessItHard(guess);
        }
    }
}