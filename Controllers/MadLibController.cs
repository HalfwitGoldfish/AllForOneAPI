using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController (MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib/{animal}/{name}/{food}/{toy}/{age}/{animal2}/{name2}/{food2}/{toy2}/{age2}")]
        public string MadLib(string animal, string name, string food, string toy, int age, string animal2, string name2, string food2, string toy2, string age2)
        {
            return _madLibServices.MadLib(animal, name, food, toy, age, animal2, name2, food2, toy2, age2);
        }
    }
}