#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace Core7SessionWorkshop.Models;

public class User
{
    [Required]
    [MinLength(2)]
    public string Name {get;set;}        
    
    
}