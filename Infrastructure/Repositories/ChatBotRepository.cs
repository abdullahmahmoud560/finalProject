using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChatBotRepository : IChatBotRepository
    {
        private readonly DB _db;

        public ChatBotRepository(DB db)
        {
            _db = db;
        }

        public async Task AddMessageAsync(ChatMessage chatMessage)
        {
            if (chatMessage == null)
                throw new ArgumentNullException(nameof(chatMessage), "Chat message cannot be null");
            var titleIsFound = await _db.ChatHistories.Where(x => x.StudentId == chatMessage.ChatHistoryId).AnyAsync();
            await _db.ChatMessages.AddAsync(chatMessage);
            await _db.SaveChangesAsync();
        }

        public async Task<List<ChatMessage>> GetMessagesStudentAsync(Expression<Func<ChatMessage, bool>> func)
        {
            try
            {
                return await _db.ChatMessages
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

    }
}
