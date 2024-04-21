using System.ComponentModel.DataAnnotations;

namespace NewRestAPI.Model;

public class AnimalDTO
{
    public AnimalDTO(string name, string description, string category, string area)
    {
        Name = name;
        Description = description;
        Category = category;
        Area = area;
    }
    
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    [Required] public string Category { get; set; }
    [Required] public string Area { get; set; }
}