using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Student? Student { get; set; }
        [ForeignKey(nameof(Student))]
        public int? StudentId { get; set; }
        public ChatHistory? ChatHistory { get; set; }
        [ForeignKey(nameof(ChatHistory))]
        public int? ChatHistoryId { get; set; }
    }

}
