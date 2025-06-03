using InvestorChatService.Application.Interfaces;
using InvestorChatService.Application.DTOs;
using InvestorChatService.Models;
using System.Linq.Expressions;

namespace InvestorChatService.Application.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatMessageRepository _chatMessageRepository;

        public ChatService(IChatMessageRepository chatMessageRepository)
        {
            _chatMessageRepository = chatMessageRepository;
        }


        public async Task SendMessageAsync(Guid chatRoomId, string message)
        {
            var chatMessage = new ChatMessage
            {
                Id = Guid.NewGuid(),
                ChatRoomId = chatRoomId,
                Content = message,
            };

            await _chatMessageRepository.AddAsync(chatMessage);
        }

        public async Task DeleteMessageAsync(Guid messageId)
        {
            var message = await _chatMessageRepository.GetByIdAsync();
            if (message != null)
            {
                await _chatMessageRepository.Delete(message);
            }
        }
    }
}
