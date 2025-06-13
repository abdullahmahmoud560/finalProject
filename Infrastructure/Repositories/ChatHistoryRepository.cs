using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChatHistoryRepository : IChatHistoryRepository
    {
        private readonly DB _db;

        public ChatHistoryRepository(DB db)
        {
            _db = db;
        }

        public async Task AddChatAsync(ChatHistory chat)
        {
            if (chat == null)
                throw new ArgumentNullException(nameof(chat), "Chat cannot be null");

            await _db.ChatHistories.AddAsync(chat);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> CheckTitle(Expression<Func<ChatHistory, bool>> func)
        {
            var chack = await _db.ChatHistories
                .AsNoTracking()
                .FirstOrDefaultAsync(func)
                .ContinueWith(task => task.Result != null);
            return chack;
        }

        public async Task<List<ChatHistory>> GetChatHistoryAsync(Expression<Func<ChatHistory, bool>> func)
        {
            return await _db.ChatHistories.Where(func).ToListAsync();
        }

        public async Task UpdateChatAsync(ChatHistory chatHistory)
        {
            var chat = await _db.ChatHistories.FindAsync(chatHistory.Id);
            if (chat == null)
                throw new KeyNotFoundException($"Chat with ID {chatHistory.Id} not found");
            chat.Title = chatHistory.Title;
            _db.ChatHistories.Update(chat);
            await _db.SaveChangesAsync();
        }


    }
}
