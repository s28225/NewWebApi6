using System.Collections;
using System.Drawing;
using NewRestAPI.Model;
using NewRestAPI.Repositories;

namespace NewRestAPI.Services;

public class AnimalService(IAnimalRepository animalRepository) : IAnimalService
{
    private IAnimalRepository _animalRepository = animalRepository;

    public IEnumerable<Animal> GetAnimals()
    {
       return _animalRepository.FetchAnimals();
    }

    public Animal? GetAnimal(int id)
    {
        return _animalRepository.FetchAnimal(id);
    }

    public bool RemoveAnimal(int id)
    {
        throw new NotImplementedException();
    }

    public bool EditAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public Animal ConvertDtOtoAnimal(AnimalDTO animalDto)
    {
        throw new NotImplementedException();
    }

    public Animal ConvertDtOtoAnimal(int id, AnimalDTO animalDto)
    {
        throw new NotImplementedException();
    }

    public bool AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }
}