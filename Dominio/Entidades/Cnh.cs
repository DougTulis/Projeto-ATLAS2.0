namespace Projeto_ATLAS.Dominio.Entidades
{
    internal class Cnh 
    {
        public string NumeroRegistro { get; set; }

        public string CPF { get; set; }

        public DateTime Validade { get; set; }

        public bool VerificarValidade()
        {
            return true; // por enquanto 
        }

    }
}
