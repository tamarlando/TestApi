using System.Data;

namespace TestApi.Services
{
    public class LoginService: ILoginService
    {
        private readonly TestContext dbContext;
        public LoginService(private TestContext _dbContext)
        {
            dbContext = _dbContext;
    }
       public async Task<User> Get(string userName, string password, string chatId)
        {
        // get from db context the current user by user name and password' and check that user was invited to this chat
        // update the db that this user join up to this chat
    }
}
}
