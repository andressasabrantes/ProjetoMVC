using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;
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
            var contatos = _dbcontext.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Contatos.Add(contato);
                _dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
    }
}
