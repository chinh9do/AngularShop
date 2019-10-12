using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public string TagID { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }

    }
}
