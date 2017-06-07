using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.DomainData
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
