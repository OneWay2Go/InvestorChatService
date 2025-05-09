namespace InvestorChatService.Models;

public class ChatRoom
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public List<ChatParticipant> Participants { get; set; } = new();

    public List<ChatMessage> Messages { get; set; } = new();
}
