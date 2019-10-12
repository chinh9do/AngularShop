using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobie { get; set; }

        public string CustomerMessenge { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public string PaymentMethod { get; set; }
         
        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        [ForeignKey("OrderID")]
        public virtual OrderDetail OrderDetail { get; set; }
    }
}