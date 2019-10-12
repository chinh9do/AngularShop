using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        public string TagID { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}