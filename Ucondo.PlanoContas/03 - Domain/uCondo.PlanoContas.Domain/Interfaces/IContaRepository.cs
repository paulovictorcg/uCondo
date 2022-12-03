
using uCondo.PlanoContas.Domain.Entidades;

namespace uCondo.PlanoContas.Domain.Interfaces
{
    public interface IContaRepository
    {
        Task<IEnumerable<Conta>> obterTodasContasAsync();
    }
}
