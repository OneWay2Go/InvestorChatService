using InvestorChatService.Application.Interfaces;
using InvestorChatService.Infrastructure.Persistence.DbContexts;
using InvestorChatService.Models;

namespace InvestorChatService.Infrastructure.Persistence.Repositories
{
    public class ChatRoomRepository(ChatContext context) : Repository<ChatRoom>(context), IChatRoomRepository
    {
    }
}
