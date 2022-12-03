
using uCondo.PlanoContas.Domain.Entidades;

namespace uCondo.PlanoContas.Domain.Interfaces
{
    public interface IContaService
    {
        Task<IEnumerable<Conta>> listarTodasContasAsync();
    }
}
