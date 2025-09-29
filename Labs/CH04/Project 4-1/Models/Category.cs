using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project4_1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
