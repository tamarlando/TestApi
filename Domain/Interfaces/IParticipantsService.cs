using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IParticipantsService
    {
         async Task<List<User>> GetByChatId(string chatId);
    }
}
