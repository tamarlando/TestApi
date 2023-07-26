namespace TestApi.Services
{
    public class ChatDetailsService: IChatDetailsService
    {
        private readonly TestContext dbContext;
        public ChatDetailsService(private TestContext _dbContext)
        {
            dbContext = _dbContext;
    }
       public async Task<ChatDetails> GetByChatId(string chatId)
        {
            // get from db context the chat details
        }
    }
}
