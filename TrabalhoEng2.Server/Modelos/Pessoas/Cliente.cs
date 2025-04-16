namespace TrabalhoEng2.Server.Modelos.Pessoas
{
    public class Cliente : Usuario
    {
        public int[] HistoricoPedidos { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string telefone, string senha) : base(nome, cpf, telefone, senha)
        {
            HistoricoPedidos = new int[0];
        }
    }
}
