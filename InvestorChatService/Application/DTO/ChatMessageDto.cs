namespace InvestorChatService.Application.DTOs
{
    public class ChatMessageDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
