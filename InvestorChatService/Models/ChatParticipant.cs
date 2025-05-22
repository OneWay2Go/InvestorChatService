namespace InvestorChatService.Models;

public class ChatParticipant
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; } // Ссылка на UserService, надо доделать

    public Guid ChatRoomId { get; set; }

    public ChatRoom ChatRoom { get; set; }
}
