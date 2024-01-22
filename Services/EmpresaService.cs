using ErpAPI.Models;
using ErpAPI.Repositories;

namespace ErpAPI.Services
{
    // No mesmo arquivo, considere que estamos em um arquivo chamado EmpresaService.cs

    public interface IEmpresaService : IGenericService<Empresa>
    {
        // Adicione métodos específicos para o serviço de empresa, se necessário.
    }

    public partial class EmpresaService : GenericService<Empresa>, IEmpresaService
    {
        // Construtor específico para a classe EmpresaService, se necessário.
        public EmpresaService(IRepository<Empresa> empresaRepository) : base(empresaRepository)
        {
            // Implementação específica, se necessário.
        }

        // Adicione métodos específicos para o serviço de empresa, se necessário.
    }


}
