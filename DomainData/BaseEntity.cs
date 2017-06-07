using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DomainData
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
