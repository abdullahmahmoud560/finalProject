    using System.ComponentModel.DataAnnotations.Schema;

    namespace Domain.Entities
    {
    public class FilePDF
    {
        [Column("FileId")]
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ChatHistoryPDF? ChatHistoryPDF { get; set; }
        [ForeignKey(nameof(ChatHistoryPDF))]
        public int? ChatId { get; set; }
        public Student? Student { get; set; }
        [ForeignKey(nameof(Student))]
        public int? StudentId { get; set; }
    }
}
