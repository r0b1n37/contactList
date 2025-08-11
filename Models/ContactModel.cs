using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ContactModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
