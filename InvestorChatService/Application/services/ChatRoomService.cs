using InvestorChatService.Application.Interfaces;
using InvestorChatService.Application.DTOs;
using InvestorChatService.Models;

namespace InvestorChatService.Application.Services
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IChatRoomRepository _chatRoomRepository;

        public ChatRoomService(IChatRoomRepository chatRoomRepository)
        {
            _chatRoomRepository = chatRoomRepository;
        }

        public async Task<ChatRoomDto> GetChatRoomAsync(Guid chatRoomId)
        {
            var chatRoom = await _chatRoomRepository.GetByIdAsync(chatRoomId);
            return new ChatRoomDto { Id = chatRoom.Id, Name = chatRoom.Name };
        }

        public async Task<IEnumerable<ChatRoomDto>> GetAllChatRoomsAsync()
        {
            var chatRooms = await _chatRoomRepository.GetAll().ToListAsync();
            return chatRooms.Select(room => new ChatRoomDto { Id = room.Id, Name = room.Name });
        }

        public async Task CreateChatRoomAsync(ChatRoomDto chatRoomDto)
        {
            var chatRoom = new ChatRoom { Id = Guid.NewGuid(), Name = chatRoomDto.Name };
            await _chatRoomRepository.AddAsync(chatRoom);
        }
    }
}
