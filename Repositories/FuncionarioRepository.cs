using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}