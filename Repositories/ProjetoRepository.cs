using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IProjetoRepository : IRepository<Projeto>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class ProjetoRepository : Repository<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}