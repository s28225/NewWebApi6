using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace NewRestAPI.Model;

public class Animal
{
    
    public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    [Required] public string Category { get; set; }
    [Required] public string Area { get; set; }


    public Animal(int id, string name, string description, string category, string area)
    {
        Id = id;
        Name = name;
        Description = description;
        Category = category;
        Area = area;
    }

    public Animal()
    {
    }
}