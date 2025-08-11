using Microsoft.EntityFrameworkCore;
using Models;

namespace Database
{
    public class ContactDbReader : DbReaderTemplate<ContactModel>
    {
        private ContactDbContext _context;

        public ContactDbReader(DbContextOptions<ContactDbContext> options)
        {
            _context = new ContactDbContext(options);
        }
        protected override void Connect()
        {
            _context.Database.EnsureCreated();
        }

        protected override List<ContactModel> ReadData()
        {
            return _context.Contacts.ToList();
        }

        protected override void Disconnect()
        {
            _context.Dispose();
        }
    }
}
