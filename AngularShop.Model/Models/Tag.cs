using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        [ForeignKey("TagID")]
        public virtual ProductTag ProductTags { get; set; }

        [ForeignKey("TagID")]
        public virtual PostTag PostTags { get; set; }
    }
}
