using InvestorChatService.Application.DTOs;

namespace InvestorChatService.Application.Interfaces
{
    public interface IChatRoomService
    {
        Task<ChatRoomDto> GetChatRoomAsync(Guid chatRoomId);
        Task<IEnumerable<ChatRoomDto>> GetAllChatRoomsAsync();
        Task CreateChatRoomAsync(ChatRoomDto chatRoomDto);
    }
}
