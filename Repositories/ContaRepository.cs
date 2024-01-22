using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IContaRepository : IRepository<Conta>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class ContaRepository : Repository<Conta>, IContaRepository
    {
        public ContaRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}