using System;
using System.ComponentModel.DataAnnotations;

namespace Project4_1.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime DateAdded { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
