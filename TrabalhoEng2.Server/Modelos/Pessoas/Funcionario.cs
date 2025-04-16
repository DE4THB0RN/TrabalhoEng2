namespace TrabalhoEng2.Server.Modelos.Pessoas
{
    public class Funcionario : Usuario
    {
        public float Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, string telefone, string senha, float salario) : base(nome, cpf, telefone, senha)
        {
            Salario = salario;
        }

        public Funcionario(string nome, string cpf, string telefone, string senha) : base(nome, cpf, telefone, senha)
        {
            Salario = 0;
        }
    }
}
