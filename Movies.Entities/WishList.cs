using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class WishList
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public int MovieId { get; set; }
        public int FilmDirectorId { get; set; }
        public int ProductionCompanyId { get; set; }
        public int WritterId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
