using InvestorChatService.Application.Interfaces;
using InvestorChatService.Infrastructure.Persistence.DbContexts;
using InvestorChatService.Models;

namespace InvestorChatService.Infrastructure.Persistence.Repositories
{
    public class ChatParticipantRepository(ChatContext context) : Repository<ChatParticipant>(context), IChatParticipantRepository
    {
    }
}
