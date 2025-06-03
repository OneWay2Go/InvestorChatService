using InvestorChatService.Models;

namespace InvestorChatService.Application.Interfaces
{
    public interface IChatParticipantService
    {
        IList<ChatParticipant> GetAllParticipants();

        Task<ChatParticipant> GetParticipantByIdAsync(int id);

        Task AddParticipantAsync(ChatParticipant chatParticipant);
    }
}
