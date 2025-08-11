using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Commands
{
    public class EditContact : Command
    {
        private ContactModel _oldContact;
        private ContactModel _newContact;
        private IContactService _service;

        public override string Name => $"Edit {_newContact.Name}";

        public EditContact(ContactModel oldContact, ContactModel newContact, IContactService service)
        {
            _oldContact = oldContact;
            _newContact = newContact;
            _service = service;
        }

        public override void Execute()
        {
            _service.DetachContact(_oldContact);
            _service.UpdateContact(_newContact);
        }

        public override void Undo()
        {
            _service.DetachContact(_newContact);
            _service.UpdateContact(_oldContact);
        }
    }

}
