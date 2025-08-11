using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Commands
{
    public class RemoveContact : Command
    {
        private ContactModel _contact;
        private IContactService _service;

        public override string Name => $"Remove {_contact.Name}";

        public RemoveContact(ContactModel contact, IContactService service)
        {
            _contact = contact;
            _service = service;
        }

        public override void Execute()
        {
            _service.RemoveContact(_contact.Id);
        }

        public override void Undo()
        {
            _service.AddContact(_contact);
        }
    }

}
