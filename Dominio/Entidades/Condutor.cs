namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Condutor : ModeloAbstrato
    {
        public Pessoa Pessoa { get; set; }
        public Cnh Cnh { get; set; }

    }
}
