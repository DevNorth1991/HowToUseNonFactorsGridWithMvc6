using PracticeMvcGridNonFactors.Models;
using System.Data;
using System.Xml.Linq;

namespace PracticeMvcGridNonFactors.Data
{
    public class DBContextFake
    {
        public async Task<List<Employee>> Employes()
        {

            var result = new List<Employee>() {

                new Employee()
                {
                    Id = 1,
                    Name = "Nico",
                    Role = "admin",
                    Email ="admin@rentlySoft.com"
                },
                   new Employee()
                {
                    Id = 2,
                    Name = "Rodri",
                    Role = "user",
                    Email ="admin@rentlySoft.com"
                },
                      new Employee()
                {
                    Id = 3,
                    Name = "raul",
                    Role = "support",
                    Email ="admin@rentlySoft.com"
                },
                         new Employee()
                {
                    Id = 4,
                    Name = "Diego",
                    Role = "Quality asurance",
                    Email ="admin@rentlySoft.com"
                },new Employee()
                           {
                    Id = 5,
                    Name = "David",
                    Role = "developer",
                    Email ="david@rentlySoft.com"
                },
                         new Employee()
                  {
                    Id = 6,
                    Name = "Gatto",
                    Role = "backend",
                    Email ="gustavo@rentlySoft.com"
                },
                         new Employee()
                    {
                    Id = 7,
                    Name = "Gustavo",
                    Role = "Fullstack developer",
                    Email ="gustavo@rentlySoft.com"
                },
                         new Employee()
                  {
                    Id = 8,
                    Name = "Andres",
                    Role = "Frontend",
                    Email ="andres@rentlySoft.com"
                },
                         new Employee()
                  {
                    Id = 9,
                    Name = "Diego",
                    Role = "Quality asurance",
                    Email ="admin@rentlySoft.com"
                },
                         new Employee()
                  {
                    Id = 10,
                    Name = "Jose",
                    Role = "Frontend",
                    Email ="jose@rentlySoft.com"
                }

            };
            return result;

        }

    }
}
