using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Repositories;


namespace ProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaRepository _dbcontext;

        public ContatoController(AgendaRepository dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}