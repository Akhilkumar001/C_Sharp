using System.ComponentModel.DataAnnotations;

namespace SampleConsoleApp.Models;

public class Dev
{
    [Key]
    public string UserId { get; set; } = String.Empty;

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = String.Empty;
    [Required]
    [MaxLength(100)]
     public string Name { get; set; } = String.Empty;




}