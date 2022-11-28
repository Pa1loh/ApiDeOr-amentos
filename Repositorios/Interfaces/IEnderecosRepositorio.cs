using ApiDeOrcamento.Models;

namespace ApiDeOrcamento.Repositorios.Interfaces
{
    public interface IEnderecosRepositorio :ICrudGenericoRepositorio<Endereco>
    {
        Task GetEnderecoPorClienteId(int clienteId);
    }
}
