#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstMVC.Models;

public class Pet
{
    [Required(ErrorMessage = "Name is required!")]
    [MinLength(2)]
    public string Name {get;set;}
    
    [Required]
    [MinLength(2)]
    [MaxLength(100)]
    public string Species {get;set;}
    
    public bool IsFriendly {get;set;}
    
    [Required(ErrorMessage = "Age is required")]
    [Range(0,int.MaxValue)]
    public int? Age {get;set;}
}