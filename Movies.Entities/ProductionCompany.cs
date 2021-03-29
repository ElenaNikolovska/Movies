using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class ProductionCompany
    { 
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(500)]
        public string ShortDescription { get; set; }
        [StringLength(50)]
        public string Year { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
