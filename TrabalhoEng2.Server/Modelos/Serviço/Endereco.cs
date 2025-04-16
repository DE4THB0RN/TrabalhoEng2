namespace TrabalhoEng2.Server.Modelos.Serviço
{
    public class Endereco
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Rua { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public int Numero { get; set; }
        public string Complemento { get; set; } = string.Empty;
        public string PontoReferencia { get; set; } = string.Empty;

        public Endereco()
        {
            Rua = "";
            Bairro = "";
            Numero = 0;
            Complemento = "";
            PontoReferencia = "";
        }

        public Endereco(string rua, string bairro, int numero, string complemento, string pontoReferencia)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            PontoReferencia = pontoReferencia;
        }

        public Endereco(int idCliente, string rua, string bairro, int numero, string complemento, string pontoReferencia)
        {
            IdCliente = idCliente;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            PontoReferencia = pontoReferencia;
        }

        public Endereco( string rua, string bairro, int numero)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
        }

    }
}
