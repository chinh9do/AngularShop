using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; } //product categoris

        [Required]
        public int Quantity { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}