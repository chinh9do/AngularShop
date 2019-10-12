using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShop.Model.Models
{
    [Table("VisistorStatistics")]
    public class VisistorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VistedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}