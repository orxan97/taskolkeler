using System.Text.Json;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Country azerbaijan = new Country("azerbaijan");
            City Tovuz = new City("TOVUZ", 10000);
            azerbaijan.AddCity(azerbaijan, Tovuz);
            azerbaijan.FindAllByPopulation(1000, 1000000);


              

        }
    }
}