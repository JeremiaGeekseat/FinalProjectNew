using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.DomainData
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {

        }

        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActivated { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
