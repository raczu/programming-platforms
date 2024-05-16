using System.ComponentModel.DataAnnotations;

namespace MovieApp.Data;

public class Movie
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(255)]
    public string? Title { get; set; }
    
    [StringLength(1024)]
    public string? Description { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    
    [Range(1, 10)]
    public float? Rate { get; set; }

    public int ReviewCount { get; set; }
    
    [Url]
    public string? ImageUrl { get; set; }
}