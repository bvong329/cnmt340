using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Products
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
    }
}
