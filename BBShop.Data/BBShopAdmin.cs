﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBShop.Data
{
    public class BBShopAdmin
    {
        [Key]
        public int AdminID { get; set; }
        [Required]
        public Guid OwnerID { get; set; }
        [Required]
        [Display(Name = "Admin Name")]
        public string AdminName { get; set; }

    }
}