namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Pessoa : ModeloAbstrato
    {
        public string Nome { get; private set; }
        public string  Telefone { get; private set; }
        public string  Email { get; set; }

        
        public bool VerificarDado()
        {
            return false; // por enquanto
        }
    }
}
