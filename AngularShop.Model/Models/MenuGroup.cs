﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}