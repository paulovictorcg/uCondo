
using uCondo.PlanoContas.Domain.Entidades;
using uCondo.PlanoContas.Domain.Interfaces;

namespace uCondo.PlanoContas.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }
        public async Task<IEnumerable<Conta>> listarTodasContasAsync()
        {
            return await _contaRepository.obterTodasContasAsync();
        }
    }
}
