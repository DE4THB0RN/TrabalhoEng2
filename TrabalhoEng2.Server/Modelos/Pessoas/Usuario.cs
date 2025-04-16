namespace TrabalhoEng2.Server.Modelos.Pessoas
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        
        
        public Usuario()
        {
            Nome = "";
            CPF = "";
            Telefone = "";
            Senha = "";
        }

        public Usuario(string nome, string cpf, string telefone, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Senha = senha;
        }

    }
}
