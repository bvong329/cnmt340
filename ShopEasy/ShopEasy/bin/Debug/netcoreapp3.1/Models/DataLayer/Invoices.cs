using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Invoices
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }
        public int Products { get; set; }
    }
}
