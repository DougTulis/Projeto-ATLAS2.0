namespace Projeto_ATLAS.Dominio.Entidades
{
    internal abstract class ModeloAbstrato
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

    }
}
