using ErpAPI.Models;

namespace ErpAPI.Repositories
{
    public interface IClienteXempresaRepository : IRepository<ClienteXempresa>
    {
        // Não há necessidade de adicionar métodos específicos, pois herda CRUD da interface genérica.
    }

    public class ClienteXempresaRepository : Repository<ClienteXempresa>, IClienteXempresaRepository
    {
        public ClienteXempresaRepository(ErpContext context) : base(context)
        {
            // Nenhuma implementação adicional necessária, pois herda métodos CRUD da classe genérica.
        }
    }
}