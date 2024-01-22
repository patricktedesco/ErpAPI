namespace ErpAPI.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); //fornece uma maneira de recuperar todas as entidades presentes no repositório. 
        T GetById(int id); //Recupera todas as entidades do repositório ou uma entidade 
        void Add(T entity); //Adiciona uma nova entidade ao repositório.
        void Update(T entity); //Atualiza uma entidade existente no repositório.
        void Delete(T entity); //Remove uma entidade do repositório.
    }

}

// Esta é uma interface genérica para todas as tabelas.
