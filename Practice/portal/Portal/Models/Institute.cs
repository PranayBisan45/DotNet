using System.ComponentModel.DataAnnotations;
namespace Portal.Models;

public class Institute{
    [Required,MaxLength(40)]
    public string InstituteName {get;set;}
    public string ContactName {get;set;}
    public int CountStudent {get;set;}
}