using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IMoedaRepository : IRepository<Moeda>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class MoedaRepository : Repository<Moeda>, IMoedaRepository
    {
        public MoedaRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}