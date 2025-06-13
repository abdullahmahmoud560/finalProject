using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChatPDFHistoryRepository : IChatPDFHistoryRepository
    {
        private readonly DB _db;

        public ChatPDFHistoryRepository(DB db)
        {
            _db = db;
        }

        public async Task AddChatAsync(ChatHistoryPDF chat)
        {
            if (chat == null)
                throw new ArgumentNullException(nameof(chat), "Chat cannot be null");

            await _db.ChatHistoriesPDF.AddAsync(chat);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> CheckTitle(Expression<Func<ChatHistoryPDF, bool>> func)
        {
            var chack = await _db.ChatHistoriesPDF
                .AsNoTracking()
                .FirstOrDefaultAsync(func)
                .ContinueWith(task => task.Result != null);
            return chack;
        }

        public async Task<List<ChatHistoryPDF>> GetChatHistoryAsync(Expression<Func<ChatHistoryPDF, bool>> func)
        {
            return await _db.ChatHistoriesPDF.Where(func).ToListAsync();
        }

        public async Task UpdateChatAsync(ChatHistoryPDF chatHistory)
        {
            var chat = await _db.ChatHistoriesPDF.FindAsync(chatHistory.Id);
            if (chat == null)
                throw new KeyNotFoundException($"Chat with ID {chatHistory.Id} not found");
            chat.Title = chatHistory.Title;
            _db.ChatHistoriesPDF.Update(chat);
            await _db.SaveChangesAsync();
        }


    }
}
