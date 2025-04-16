namespace TrabalhoEng2.Server.Modelos.Comida
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int Tamanho { get; set; } // 0 = pequeno, 1 = medio, 2 = grande
        public string Descricao { get; set; } = string.Empty;
        public string Ingredientes { get; set; } = string.Empty;
        public float Preco { get; set; }

        public Pizza()
        {
            Titulo = "";
            Tamanho = 0;
            Descricao = "";
            Ingredientes = "";
            Preco = 0;
        }

        public Pizza(string titulo, int tamanho, string descricao, string ingredientes, float preco)
        {
            Titulo = titulo;
            Tamanho = tamanho;
            Descricao = descricao;
            Ingredientes = ingredientes;
            Preco = preco;
        }

        public Pizza(string titulo, int tamanho, string ingredientes, float preco)
        {
            Titulo = titulo;
            Tamanho = tamanho;
            Descricao = "";
            Ingredientes = ingredientes;
            Preco = preco;
        }
    }
}
