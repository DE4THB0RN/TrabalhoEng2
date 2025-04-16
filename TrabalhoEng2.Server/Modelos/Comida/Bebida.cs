namespace TrabalhoEng2.Server.Modelos.Comida
{
    public class Bebida
    {
        public int Id { get; set;  }
        public string Titulo { get; set; }
        public int Tamanho { get; set; }
        public float Preco { get; set; }

        public Bebida()
        {
            Titulo = "";
            Tamanho = 0;
            Preco = 0;
        }

        public Bebida(string titulo, int tamanho, float preco)
        {
            Titulo = titulo;
            Tamanho = tamanho;
            Preco = preco;
        }
    }
}
