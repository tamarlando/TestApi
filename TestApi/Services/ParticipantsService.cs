namespace TestApi.Services
{
    public class ParticipantsService: IParticipantsService
    {
        private readonly TestContext dbContext;
        public ParticipantsService(private TestContext _dbContext)
        {
            dbContext = _dbContext;
    }
       public async Task<List<User>> GetByChatId(string chatId)
        {
        // get from db context the Participants of current chat
    }
}
}
