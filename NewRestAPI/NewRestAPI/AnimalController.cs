using Microsoft.AspNetCore.Mvc;
using NewRestAPI.Model;
using NewRestAPI.Services;

namespace NewRestAPI;

[Route("animals")]
[ApiController]
public class AnimalsController(IAnimalService animalService) : ControllerBase
{
    private readonly IAnimalService _animalService = animalService;
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        Animal? animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return NotFound($"Animal with id:{id} was not found");
        }

        return Ok(animal);
    }
}