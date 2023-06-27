using DailyJournalApplication.DAL.Abstract;
using DailyJournalApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyJournalApplication.DAL.Concrete
{
    public class EntryRepository : Repository<Entry>, IEntryRepository
    {
        private DJDbContext _dbContext;

        public EntryRepository(DJDbContext ctx) : base(ctx) 
        { 
            _dbContext = ctx;
        }

        public void AddOrUpdateEntry(Entry entry)
        {
            _dbContext.Add(entry);
            _dbContext.SaveChanges();
        }

        public List<Entry> GetAllEntries()
        {
            List<Entry> entries = _dbSet.Select(e => e).ToList();

            return entries;
        }

        public Entry GetEntryById (int id)
        {
            Entry entry = _dbSet.FirstOrDefault(e => e.Id == id);
            return entry;
        }
    }
}
