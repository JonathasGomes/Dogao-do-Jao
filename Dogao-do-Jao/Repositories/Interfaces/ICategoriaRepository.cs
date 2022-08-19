using Dogao_do_Jao.Models;

namespace Dogao_do_Jao.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
