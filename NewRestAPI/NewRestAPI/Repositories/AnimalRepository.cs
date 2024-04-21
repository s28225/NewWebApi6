using System.Data.SqlClient;
using NewRestAPI.Model;

namespace NewRestAPI.Repositories;


public class AnimalRepository : IAnimalRepository
{
    private IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Animal? FetchAnimal(int id)
    {
        SqlConnection sqlConnection = new SqlConnection("Server=db-mssql;Database=Server=db-mssql ;Database=2019SBD;Trusted_Connection=True;Trusted_Connection=True;");
        SqlCommand sqlCommand = new SqlCommand();
        sqlConnection.Open();
        sqlCommand.Connection = sqlConnection;
        sqlCommand.CommandText = "Select id from Film";
        var sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
            Console.WriteLine(sqlDataReader["id"]);
        }

        return new Animal(1,"2","3","4","5");
    }

    public IEnumerable<Animal> FetchAnimals()
    {
        var animals = new List<Animal>();
        try
        {
            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=2019SBD;Integrated Security=True"))
            {
                con.Open();
            
                using (var cmd = new SqlCommand("SELECT IdAnimal, Name, Description, Category, Area FROM Animal", con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var grade = new Animal
                        {
                            Id = (int)dr["IdAnimal"],
                            Name = dr["Name"].ToString(),
                            Description = dr["Description"].ToString(),
                            Category = dr["Category"].ToString(),
                            Area = dr["Area"].ToString()
                        };
                        animals.Add(grade);
                    }
                }
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return animals;
    }

    public bool DeleteAnimal(int id)
    {
        return false;

    }

    public bool UpdateAnimal(Animal animal)
    {
        return false;
    }

    public bool AddAnimal(Animal animal)
    {
        return false;
    }
}