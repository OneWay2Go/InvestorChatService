namespace InvestorChatService.Models;

public class ChatMessage
{
    public Guid Id { get; set; }

    public Guid ChatRoomId { get; set; }

    // Надо доделать этот кусок
    public Guid SenderUserId { get; set; }

    public string Content { get; set; } = string.Empty;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public ChatRoom ChatRoom { get; set; }
}
