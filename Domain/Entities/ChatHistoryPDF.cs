namespace Domain.Entities
{
    public class ChatHistoryPDF
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Student? Student { get; set; }
        public int? StudentId { get; set; }
    }
}
