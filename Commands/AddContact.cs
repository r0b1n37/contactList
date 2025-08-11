using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Commands
{
    public class AddContact : Command
    {
        private readonly ContactModel _contact;
        private readonly IContactService _service;

        public override string Name => $"Add {_contact.Name}";

        public AddContact(ContactModel contact, IContactService service)
        {
            _contact = contact;
            _service = service;
        }

        public override void Execute()
        {
            _service.AddContact(_contact);
        }

        public override void Undo()
        {
            _service.RemoveContact(_contact.Id);
        }
    }
}
