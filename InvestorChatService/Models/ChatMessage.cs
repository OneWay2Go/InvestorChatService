namespace InvestorChatService.Models;

public class ChatMessage
{
    public Guid Id { get; set; }

    public Guid ChatRoomId { get; set; }

    public Guid SenderUserId { get; set; }

    public string Content { get; set; } = string.Empty;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
