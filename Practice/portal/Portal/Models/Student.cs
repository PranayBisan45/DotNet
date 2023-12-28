using System.ComponentModel.DataAnnotations;
namespace Portal.Models;

public class Student {
    public int id{get;set;}

    [Required,MaxLength(80)]
    public string name{get;set;}
}