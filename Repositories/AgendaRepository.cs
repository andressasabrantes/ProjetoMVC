using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;


namespace ProjetoMVC.Repositories
{
    public class AgendaRepository : DbContext
    {
        public AgendaRepository(DbContextOptions<AgendaRepository> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}