namespace Projeto_ATLAS.Dominio.Entidades
{
    public abstract class ModeloAbstrato
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; } 

    }
}
