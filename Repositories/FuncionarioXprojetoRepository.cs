using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IFuncionarioXprojetoRepository : IRepository<FuncionarioXprojeto>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class FuncionarioXprojetoRepository : Repository<FuncionarioXprojeto>, IFuncionarioXprojetoRepository
    {
        public FuncionarioXprojetoRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}