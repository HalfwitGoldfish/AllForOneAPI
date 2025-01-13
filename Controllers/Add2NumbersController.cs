using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
        private readonly Add2NumbersServices _add2NumbersServices;

        public Add2NumbersController (Add2NumbersServices add2NumbersServices)
        {
            _add2NumbersServices = add2NumbersServices;
        }

        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string Add(int num1, int num2)
        {
            return _add2NumbersServices.Add(num1, num2);
        }
    }
}