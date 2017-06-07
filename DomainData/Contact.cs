using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.DomainData
{
    [Table("Contact")]
    public class Contact : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public virtual User User { get; set; }
    }
}
