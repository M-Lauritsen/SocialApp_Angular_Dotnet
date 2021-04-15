using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entities;
using API.Helpers;
using API.Interfaces;

namespace API.Data
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataContext _context;
        public MessageRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMessage(Message message)
        {
            _context.Massages.Add(message);
        }

        public void DeleteMessage(Message message)
        {
            _context.Massages.Remove(message);
        }

        public async Task<Message> GetMessage(int id)
        {
            return await _context.Massages.FindAsync(id);
        }

        public Task<PagedList<MessageDto>> GetMessagesForUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MessageDto>> GetMessageThread(int currentUserId, int recipientId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}