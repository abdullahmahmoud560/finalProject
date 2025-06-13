using System.Linq;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChatPDFRepository : IChatPDFRepository
    {
        private readonly DB _db;

        public ChatPDFRepository(DB db)
        {
            _db = db;
        }

        public async Task AddMessageAsync(ChatMessagePDF chatMessage)
        {
            if (chatMessage == null)
                throw new ArgumentNullException(nameof(chatMessage), "Chat message cannot be null");
            var titleIsFound = await _db.chatMessagePDFs.Where(x => x.StudentId == chatMessage.ChatId).AnyAsync();
            await _db.chatMessagePDFs.AddAsync(chatMessage);
            await _db.SaveChangesAsync();
        }

        public async Task<List<FilePDF>> GetFileAsync(Expression<Func<FilePDF, bool>> func)
        {
            try
            {
                return await _db.Files
                     .Where(func)
                     .Where(x => x.StudentId != null)
                     .OrderBy(x => x.CreatedAt)
                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving chat messages.", ex);
            }
        }

        public async Task<List<ChatMessagePDF>> GetMessagesStudentAsync(Expression<Func<ChatMessagePDF, bool>> func)
        {
            try
            {
                return await _db.chatMessagePDFs
                    .Where(func)
                    .Where(x => x.StudentId != null)
                    .OrderBy(x => x.CreatedAt)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving chat messages.", ex);
            }
        }


        public Task SaveFileAsync(FilePDF filePDF)
        {
            try {
                if (filePDF == null || filePDF.FilePath == null || string.IsNullOrEmpty(filePDF.FileName) || string.IsNullOrEmpty(filePDF.FilePath))
                {
                    throw new ArgumentException("Invalid file data.");
                }
                _db.Files.Add(filePDF);
                return _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error uploading file: {ex.Message}");
            }
        }
    }
}
