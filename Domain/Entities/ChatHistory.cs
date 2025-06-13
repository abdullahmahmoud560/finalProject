namespace Domain.Entities
{
    public class ChatHistory
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Student? Student { get; set; }
        public int? StudentId { get; set; }
        public ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();

    }
}
