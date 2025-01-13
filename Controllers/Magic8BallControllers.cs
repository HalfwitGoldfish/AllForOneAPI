using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallControllers : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8BallControllers(Magic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("MagicBall/{question}")]
        public string MagicBall(string question)
        {
            return _magic8BallServices.MagicBall(question);
        }
    }
}