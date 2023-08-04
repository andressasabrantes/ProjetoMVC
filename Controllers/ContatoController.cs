using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}