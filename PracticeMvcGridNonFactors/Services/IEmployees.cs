using PracticeMvcGridNonFactors.Data;
using PracticeMvcGridNonFactors.Models;

namespace PracticeMvcGridNonFactors.Services
{
    public interface IEmployees
    {
        Task<List<Employee>> GetEmployeesAsync();
    }
}
