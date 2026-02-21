using System.ComponentModel.DataAnnotations;


namespace Mission06_YourLastName.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later (first movie year).")]
        public int Year { get; set; }

        [Required]
        public bool Edited { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}