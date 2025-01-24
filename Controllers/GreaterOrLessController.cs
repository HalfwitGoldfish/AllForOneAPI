using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLessServices _greaterOrLessServices;

        public GreaterOrLessController ( GreaterOrLessServices greaterOrLessServices )
        {
            _greaterOrLessServices = greaterOrLessServices;
        }
        
        [HttpGet]
        [Route("GreaterOrLess/{num1}/{num2}")]
        public string GreaterOrLess( string num1, string num2 )
        {
            return _greaterOrLessServices.GreaterOrLess( num1, num2 );
        }
    }
}