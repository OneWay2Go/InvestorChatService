using InvestorChatService.Application.Interfaces;
using InvestorChatService.Models;

namespace InvestorChatService.Application.Services
{
    public class ChatParticipantService(IChatParticipantRepository chatParticipantRepository) : IChatParticipantService
    {
        public async Task AddParticipantAsync(ChatParticipant chatParticipant)
        {
            if (chatParticipant is null)
            {
                throw new ArgumentNullException(nameof(chatParticipant), message:"Chat participant can not be null!");
            }

            await chatParticipantRepository.AddAsync(chatParticipant);
            await chatParticipantRepository.SaveChangesAsync();
        }

        public IList<ChatParticipant> GetAllParticipants()
        {
            var participants = chatParticipantRepository.GetAll().ToList();

            return participants;
        }

        public async Task<ChatParticipant> GetParticipantByIdAsync(int id)
        {
            var participant = await chatParticipantRepository.GetByIdAsync(id);

            if(participant is null)
            {
                throw new Exception($"There is no participant with id - {id}");
            }

            return participant;
        }
    }
}
