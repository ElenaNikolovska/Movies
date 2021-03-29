using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [Display(Name = "User Id")]
        public int UserID { get; set; }
        [StringLength(50)]
        public string Actor { get; set; }
        [Display(Name = "Actor Id")]
        public int ActorId { get; set; }
        [Display(Name = "Film Director")]
        [StringLength(100)]
        public string FilmDirector { get; set; }
        [Display(Name = "Film Director Id")]
        public int FilmDirectorId { get; set; }
        [StringLength(100)]
        public string Writter { get; set; }
        [Display(Name = "Writter Id")]
        public int WritterId { get; set; }
        [Display(Name = "Production Company")]
        [StringLength(100)]
        public string ProductionCompany { get; set; }
        [Display(Name = "Production Company Id")]
        public int ProductionCompanyId { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        [StringLength (50)]
        public string CategoryName { get; set; }
        public double Price { get; set; }
        [StringLength(50)]
        public string Genre { get; set; }
        [Display(Name = "Plot Summary")]
        [StringLength(500)]
        public string PlotSummary { get; set; }
        [StringLength(50)]
        public string Language { get; set; }
        [Display(Name = "Country of Origin")]
        [StringLength(50)]
        public string CountryOfOrigin { get; set; }
        [StringLength(100)]
        public string Subtitles { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Running Time")]
        public int RunningTime { get; set; }
        public double Rating { get; set; }
        [StringLength(50)]
        public string Shipping { get; set; }
        [Display(Name = "Photo")]
        public string PhotoURL { get; set; }
    }
}
