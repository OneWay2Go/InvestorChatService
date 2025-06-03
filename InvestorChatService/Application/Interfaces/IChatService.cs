using InvestorChatService.Application.DTOs;

namespace InvestorChatService.Application.Interfaces
{
    public interface IChatService
    {
        Task<IEnumerable<ChatMessageDto>> GetMessagesAsync(Guid chatRoomId);
        Task SendMessageAsync(Guid chatRoomId, string message);
        Task DeleteMessageAsync(Guid messageId);
    }
}
