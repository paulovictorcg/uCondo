
using uCondo.PlanoContas.Domain.Entidades.Enums;

namespace uCondo.PlanoContas.Domain.Entidades
{
    public class Conta
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string NomeConta { get; set; }
        public TipoGasto Tipo { get; set; }
        public bool AceitaLancamento { get; set; }
    }
}
