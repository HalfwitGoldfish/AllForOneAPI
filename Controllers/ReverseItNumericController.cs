using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumericController : ControllerBase
    {
        private readonly ReverseItNumericServices _reverseItNumericServices;
        public ReverseItNumericController (ReverseItNumericServices reverseItNumericServices)
        {
            _reverseItNumericServices = reverseItNumericServices;
        }

        [HttpGet]
        [Route("ReverseItNum/{num}")]
        public string ReverseItNum(string num)
        {
            return _reverseItNumericServices.ReverseItNum(num);
        }
    }
}