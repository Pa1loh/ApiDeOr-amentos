using ApiDeOrcamento.Models;

namespace ApiDeOrcamento.Repositorios.Interfaces
{
    public interface IItemRepositorio : ICrudGenericoRepositorio<Item>
    {
        List<Item> ListarPorOrdemDeAlteracao(); 
    }
}
