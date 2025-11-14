using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
