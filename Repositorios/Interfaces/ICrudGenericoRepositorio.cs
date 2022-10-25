namespace ApiDeOrcamento.Repositorios.Interfaces
{
    public interface ICrudGenericoRepositorio<T>
    {
        Task Adicionar(T Objeto);
        Task Atulizar(T Objeto);
        Task Deletar(T Objeto);
        Task<T> GetEntidadePorId(int Id);
        Task<List<T>> Listar();

    }
}
