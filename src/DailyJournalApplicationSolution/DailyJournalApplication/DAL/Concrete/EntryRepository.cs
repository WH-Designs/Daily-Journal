using DailyJournalApplication.DAL.Abstract;
using DailyJournalApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyJournalApplication.DAL.Concrete
{
    public class EntryRepository : Repository<Entry>, IEntryRepository
    {
        public EntryRepository(DJDbContext ctx) : base(ctx) 
        { 
        
        }

        public void AddOrUpdateEntry(Entry entry)
        {
            _dbSet.Update(entry);
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
