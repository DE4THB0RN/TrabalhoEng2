namespace TrabalhoEng2.Server.Modelos.Serviço
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdPizza { get; set; }
        public int IdBebida { get; set; }
        public int IdCliente { get; set; }
        public float ValorTotal { get; set; }
        public int FormadePagamento { get; set; } // 0 = Dinheiro, 1 = Cartão, 2 = Pix
        public int IdEndereco { get; set; }

        public Pedido()
        {
            IdPizza = 0;
            IdBebida = 0;
            IdCliente = 0;
            ValorTotal = 0;
            FormadePagamento = 0;
            IdEndereco = 0;
        }

        public Pedido(int idPizza, int idBebida, int idCliente, float valorTotal, int formaDePagamento, int idEndereco)
        {
            IdPizza = idPizza;
            IdBebida = idBebida;
            IdCliente = idCliente;
            ValorTotal = valorTotal;
            FormadePagamento = formaDePagamento;
            IdEndereco = idEndereco;
        }

        public Pedido(int idPizza, int idCliente, float valorTotal, int formaDePagamento, int idEndereco)
        {
            IdPizza = idPizza;
            IdCliente = idCliente;
            ValorTotal = valorTotal;
            FormadePagamento = formaDePagamento;
            IdEndereco = idEndereco;
        }

    }
}
