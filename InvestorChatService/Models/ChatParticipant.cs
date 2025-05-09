namespace InvestorChatService.Models;

public class ChatParticipant
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; } // Ссылка на UserService

    public Guid ChatRoomId { get; set; }
}
