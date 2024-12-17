using Projeto_ATLAS.Dominio.ValueObjects;

namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Veiculo : ModeloAbstrato
    {
        public string Modelo { get; set; }
        public string  Placa { get; set; }
        public string Categoria { get; set; }
        public bool Disponibilidade { get; set; }
        public decimal ValorDiaria { get; set; }



    }
}
