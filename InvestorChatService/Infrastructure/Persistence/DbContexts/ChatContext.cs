using InvestorChatService.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestorChatService.Infrastructure.Persistence.DbContexts
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions options) : base(options) { }

        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<ChatParticipant> ChatParticipants { get; set; }

        public DbSet<ChatRoom> ChatRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatMessage>(builder =>
            {
                builder.HasOne(cm => cm.ChatRoom)
                    .WithMany(cr => cr.Messages)
                    .HasForeignKey(cm => cm.ChatRoomId);

                builder.HasKey(cm => cm.Id);
            });

            modelBuilder.Entity<ChatParticipant>(builder => 
            {
                builder.HasKey(cp => cp.Id);

                builder.HasOne(cp => cp.ChatRoom)
                    .WithMany(cr => cr.Participants)
                    .HasForeignKey(cp => cp.ChatRoomId);
            });

            modelBuilder.Entity<ChatRoom>(builder => 
            {
                builder.HasKey(cr => cr.Id);
            });
        }
    }
}
