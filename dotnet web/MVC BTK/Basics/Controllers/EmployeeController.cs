using Basics.Models;
using Microsoft.AspNetCore.Mvc;
namespace Basics.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        /*private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }*/
        public IActionResult Index1(){
            string message=$"Hello, {DateTime.Now}";
            return View("Index1",message);
        }
        public IActionResult Index()
        {
            var names=new String[]{"Ahmet","Mehmet","Can"};
            return View("Index2",names);
        }
        public IActionResult Index3(){
            var  list= new List<Employee>(){
                new Employee(){Id=1,FirstName="Ahmet",LastName="Can",Age=20},
                new Employee(){Id=1,FirstName="Can",LastName="Dağ",Age=25},
                new Employee(){Id=1,FirstName="Demir",LastName="Güneş",Age=35},
            };
            return View("Index3",list);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}