using PracticeMvcGridNonFactors.Models;

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
                    Name = "Test",
                    Role = "admin",
                    Email ="admin@rentlySoft.com"
                },
                   new Employee()
                {
                    Id = 2,
                    Name = "Test2",
                    Role = "user",
                    Email ="admin@rentlySoft.com"
                },
                      new Employee()
                {
                    Id = 3,
                    Name = "Test3",
                    Role = "support",
                    Email ="admin@rentlySoft.com"
                },
                         new Employee()
                {
                    Id = 4,
                    Name = "Test4",
                    Role = "Quality asurance",
                    Email ="admin@rentlySoft.com"
                }

            };
            return  result;

        }

    }
}
