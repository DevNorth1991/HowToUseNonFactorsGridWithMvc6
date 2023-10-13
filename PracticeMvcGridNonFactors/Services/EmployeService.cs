using PracticeMvcGridNonFactors.Models;
using PracticeMvcGridNonFactors.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeMvcGridNonFactors.Services
{
    public class EmployeesService : IEmployees
    {
        private readonly DBContextFake _dbContextFake;

        public EmployeesService(DBContextFake dbContextFake)
        {
            _dbContextFake = dbContextFake;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _dbContextFake.Employes();
        }
    }
}