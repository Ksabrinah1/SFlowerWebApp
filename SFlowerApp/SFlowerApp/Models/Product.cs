﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SapphireApp.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ProductName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Category { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string Color { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal UnitPrice { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Description { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
