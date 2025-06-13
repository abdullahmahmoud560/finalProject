using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ChatMessagePDF
    {
        [Key]
        [Column("MessageId")]
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public Student? Student { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ChatHistoryPDF? ChatPDFHistory { get; set; }
        [ForeignKey(nameof(ChatPDFHistory))]
        public int ChatId { get; set; }
    }
}
