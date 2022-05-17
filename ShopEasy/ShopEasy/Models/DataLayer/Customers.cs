using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Customers
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Fname { get; set; }
        [StringLength(50)]
        public string Lname { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Responsible { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
    }
}
