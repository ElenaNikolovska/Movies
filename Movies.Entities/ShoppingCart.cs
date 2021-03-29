using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public int MovieId { get; set; }
        public double Price { get; set; }
    }
}
