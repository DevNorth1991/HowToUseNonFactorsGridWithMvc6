using Microsoft.AspNetCore.Mvc;
using PracticeMvcGridNonFactors.Models;
using PracticeMvcGridNonFactors.Services;

namespace PracticeMvcGridNonFactors.Controllers
{
    public class SearchController : Controller
    {

        private readonly IEmployees _servicesEmployes;
        public SearchController(IEmployees employees)
        {
                _servicesEmployes = employees;
        }


        public async Task<IActionResult> Index()
        {
            var employesList = await _servicesEmployes.GetEmployeesAsync();
            return View(employesList);
        }

    }
}
