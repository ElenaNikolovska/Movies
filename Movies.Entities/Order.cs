using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDirector { get; set; }
        public string MovieCountry { get; set; }
        public string MovieProductionCompany { get; set; }
        public string MovieCategory { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }
    }
}
