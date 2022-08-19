using Dogao_do_Jao.Context;
using Dogao_do_Jao.Models;
using Dogao_do_Jao.Repositories.Interfaces;

namespace Dogao_do_Jao.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
