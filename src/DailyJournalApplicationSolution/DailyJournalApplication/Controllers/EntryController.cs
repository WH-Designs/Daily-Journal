using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DailyJournalApplication.DAL.Abstract;
using DailyJournalApplication.Models;

namespace DailyJournalApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {
        private readonly IEntryRepository _entryRepository;

        public EntryController(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;
        }

        // GET: api/Entry
        [HttpGet]
        public ActionResult<IEnumerable<Entry>> GetAllEntries()
        {
            List<Entry> entries = _entryRepository.GetAllEntries();
            return Ok(entries);
        }

        // POST: api/Entry
        [HttpPost]
        public ActionResult<Entry> CreateEntry([FromBody] Entry entry)
        {
            if (entry == null)
            {
                return BadRequest();
            }

            

            _entryRepository.AddOrUpdateEntry(entry);

            

            return CreatedAtAction(nameof(GetEntryById), new { id = entry.Id }, entry);
        }

        // GET: api/Entry/5
        [HttpGet("{id}")]
        public ActionResult<Entry> GetEntryById(int id)
        {
            Entry entry = _entryRepository.GetEntryById(id);

            if (entry == null)
            {
                return NotFound();
            }

            return Ok(entry);
        }
    }
}