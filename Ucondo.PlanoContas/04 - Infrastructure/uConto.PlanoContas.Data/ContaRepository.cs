
using Microsoft.EntityFrameworkCore;
using uCondo.PlanoContas.Domain.Entidades;
using uCondo.PlanoContas.Domain.Interfaces;

namespace uConto.PlanoContas.Data
{
    public class ContaRepository : IContaRepository
    {
        private readonly PlanoContasContext _context;
        public ContaRepository(PlanoContasContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Conta>> obterTodasContasAsync()
        {
            return await _context.Contas.ToListAsync();
        }
        public async Task<IEnumerable<Conta>> listarContasPai()
        {
            return await _context.Contas.Where(c => !c.AceitaLancamento)
                                        .ToListAsync();
        }
    }
}
