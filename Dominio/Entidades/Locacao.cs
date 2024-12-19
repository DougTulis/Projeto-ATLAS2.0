using Projeto_ATLAS.Dominio.ValueObjects;

namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Locacao : ModeloAbstrato
    {

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ETipoLocacao Tipo { get; set; }
        public EStatusLocacao Status { get; set; }
        public Pessoa Condutor { get; set; } // Incluir no diagrama
        public Pessoa Locatario { get; set; } // Incluir no diagrama
        public Veiculo Veiculo { get; set; }
        // public Condutor Condutor { get; set; } -> retirar do diagrama
        // public Locatario Locatario { get; set; } -> retirar do diagrama
         public Pagamento Pagamento { get; set; }
        public IEnumerable<PendenciaFinanceira> PendenciaFinanceiras { get; set; } = new List<PendenciaFinanceira>();
    
    }
}
