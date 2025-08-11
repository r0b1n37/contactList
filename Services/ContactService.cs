using Database;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ContactService : IContactService
    {
        private readonly ContactDbContext _context;
        public ContactService(ContactDbContext context)
        {
            _context = context;
        }

        public void AddContact(ContactModel contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void RemoveContact(Guid id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
        }

        public void DetachContact(ContactModel contact)
        {
            var entry = _context.Entry(contact);
            if (entry.State == EntityState.Detached)
            {
                return;
            }
            entry.State = EntityState.Detached;
        }

        public void UpdateContact(ContactModel contact)
        {
            var existingContact = _context.Contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                _context.Entry(existingContact).CurrentValues.SetValues(contact);
                _context.SaveChanges();
            }
        }

        public List<ContactModel> GetAll() => _context.Contacts.ToList();
    }

}
