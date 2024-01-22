using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IPaisRepository : IRepository<Pais>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class PaisRepository : Repository<Pais>, IPaisRepository
    {
        public PaisRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}