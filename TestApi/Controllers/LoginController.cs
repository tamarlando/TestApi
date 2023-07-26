using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {


        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _loginService;

        public LoginController(ILogger<LoginController> logger, private ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService
    }

    [HttpGet("{userName}/{password}/{chatId}")]
    public ActionResult<User> Get(string  userName, string password,string chatId)
    {
        try
        {
            //_loginService.get...( userName, password,chatId)
            return Ok(new
            {
                Id : "1111",
                Name : "יוסי",
                Role: "מנהל",
                Permission : "מנהל"
            });
        }
        catch (Exception e)
        {

           return BadRequest(e.Message);
        }
     
    }
}
}