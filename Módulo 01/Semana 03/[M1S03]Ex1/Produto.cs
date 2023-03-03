namespace _M1S03_Ex1
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int qtdade;

        public Produto(string nome, double valor, int qtdade)
        {
            this.nome = nome;
            this.preco = valor;
            this.qtdade = qtdade;
        }

        public Produto()
        {
            nome = "Sem Nome";
            preco = 0;
            qtdade = 0;
        }
    }
}
