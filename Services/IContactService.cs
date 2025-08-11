using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface IContactService
    {
        void AddContact(ContactModel contact);
        void RemoveContact(Guid id);
        void DetachContact(ContactModel contact);
        void UpdateContact(ContactModel contact);
        List<ContactModel> GetAll();
    }
}
