namespace ContaBanco
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public decimal saldo = 0;

        public TipoContaEnum tipoConta;

        public void Depositar(decimal deposito)
        {
            Console.Write("Digite o valor a ser depositado: ");
            deposito = decimal.Parse(Console.ReadLine());

            if (deposito <= 0)
            {
                Console.WriteLine("Valor incorreto, o valor precisa ser positivo.");
            }
            else
            {
                saldo = saldo + deposito;
            }
        }
        public void Sacar(decimal saque)
        {
            Console.Write("Digite o valor a ser sacado: ");
            saque = decimal.Parse(Console.ReadLine());

            if (saque <= 0)
            {
                Console.WriteLine("Valor incorreto, o valor precisa ser positivo.");
            }
            else if ( saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo = saldo - saque;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de R$ {saldo} reais.");
                }
    }
}
