using System.Xml.Linq;
using Services;
using Utils;
using Models;
using Commands;
using System.Data;

namespace WinForms
{
    public partial class MainForm : Form
    {
        private readonly IContactService _service;
        private readonly HistoryList _history;

        public MainForm(IContactService contactService)
        {
            InitializeComponent();
            _service = contactService;
            _history = new HistoryList();
            LoadContacts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            contactDataGrid.Columns.Clear();
            contactDataGrid.AutoGenerateColumns = false;
            contactDataGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            contactDataGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });
            contactDataGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            contactDataGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            contactDataGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Website", DataPropertyName = "Website" });
            
            contactDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactDataGrid.MultiSelect = false;
            
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _history.Undo();
            LoadContacts();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            _history.Redo();
            LoadContacts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contact = new ContactModel
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Website = txtWebsite.Text
            };
            var cmd = new AddContact(contact, _service);
            _history.Add(cmd);
            cmd.Execute();
            LoadContacts();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (contactDataGrid.CurrentRow?.DataBoundItem is ContactModel selectedContact)
            {
                var updatedContact = new ContactModel
                {
                    Id = selectedContact.Id,
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Website = txtWebsite.Text
                };

                var cmd = new EditContact(selectedContact, updatedContact, _service);
                _history.Add(cmd);
                cmd.Execute();
                LoadContacts();
            }
            else
            {
                MessageBox.Show("Please select a contact to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (contactDataGrid.CurrentRow?.DataBoundItem is ContactModel selectedContact)
            {
                var cmd = new RemoveContact(selectedContact, _service);
                _history.Add(cmd);
                cmd.Execute();
                LoadContacts();
            }
            else
            {
                MessageBox.Show("Please select a contact to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadContacts()
        {
            var contacts = _service.GetAll().OrderBy(contact => contact.Name).ToList();
            contactDataGrid.DataSource = contacts;
        }
    }
}
