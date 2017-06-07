using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.DomainData
{
    [Table("Movie")]
    public class Movie : BaseEntity
    {
        public Movie()
        {

        }

        public string Title { get; set; }
        public int Viewed { get; set; }
        [Column(TypeName = "date")]
        public DateTime Released { get; set; }
        public string ThumbnailUrl { get; set; }
        public string BackgroundUrl { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
