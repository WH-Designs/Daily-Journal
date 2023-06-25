using DailyJournalApplication.Models;

namespace DailyJournalApplication.DAL.Abstract
{
    public interface IEntryRepository : IRepository<Entry>
    {
        List<Entry> GetAllEntries();
        void AddOrUpdateEntry(Entry entry);
        Entry GetEntryById(int id);
    }
}
