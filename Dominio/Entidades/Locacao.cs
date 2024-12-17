using Projeto_ATLAS.Dominio.ValueObjects;

namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Locacao : ModeloAbstrato
    {

        public DateTime DataInicio { get; set; }
        public DateTime DatFim { get; set; }
        public ETipoLocacao Tipo { get; set; }
        public EStatusLocacao Status { get; set; }
        public Veiculo Veiculo { get; set; }
        public Condutor Condutor { get; set; }
        public Locatario Locatario { get; set; }
        public Pagamento Pagamento { get; set; }
        public IEnumerable<PendenciaFinanceira> PendenciaFinanceiras { get; set; } = new List<PendenciaFinanceira>();
    
    }
}
