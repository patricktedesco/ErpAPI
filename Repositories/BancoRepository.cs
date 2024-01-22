using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IBancoRepository : IRepository<Banco>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class BancoRepository : Repository<Banco>, IBancoRepository
    {
        public BancoRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}

