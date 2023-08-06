using Microsoft.AspNetCore.Mvc;

namespace JoJo.Customer.API.Controllers
{
    public class CustomerController : Controller bv
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
