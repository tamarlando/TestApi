using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipantsController : ControllerBase
    {


        private readonly ILogger<ParticipantsController> _logger;
        private readonly IParticipantsService _participantsService;

        public ParticipantsController(ILogger<ParticipantsController> logger, private IParticipantsService participantsService)
        {
            _logger = logger;
            _participantsService = participantsService
    }

    [HttpGet("{chatId}")]
    public ActionResult GetByChatId(string chatId)
    {
        try
        {
            //var result = _participantsService.get...(chatId)
            return Ok(result);
        }
        catch (Exception e)
        {

            return BadRequest(e.Message);
        }
   
    }
}
}