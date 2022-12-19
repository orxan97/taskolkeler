using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Country
    {
        string name;
        int Totalpopulation = 0;
        public City[] citis;

        public Country(string name)
        {
            this.name = name;
            citis = new City[0];
        }

     public void AddCity(Country country, City city)
        {
            Array.Resize(ref country.citis, country.citis.Length + 1);
            country.citis[country.citis.Length - 1] = city;
            country.Totalpopulation += city.Population;

        }
        
        public void FindAllByPopulation(int min, int max)
        {
            foreach ( City city in citis)
            {

                if (city.Population > min)
                {
                    if (city.Population < max)
                    {
                        Console.WriteLine(city);
                    }
                }
            }

        }
         
            
    }
   
}
