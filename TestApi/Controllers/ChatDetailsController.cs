using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatDetailsController : ControllerBase
    {


        private readonly ILogger<ChatDetailsController> _logger;
        private readonly IChatDetailsService _chatDetailsService;

        public ChatDetailsController(ILogger<ChatDetailsController> logger, private IChatDetailsService chatDetailsService)
        {
            _logger = logger;
            _chatDetailsService = chatDetailsService
    }

    [HttpGet("{chatId}")]
    public ActionResult GetByChatId(string chatId)
    {
        //_chatDetailsService.get...(chatId)
        return Ok(new
        {
            Id = "assf-fgmidoutirn",
            name = "test1",
            Description = "test description",
            Number = "aas-000-sn"
        });
    }
}
}