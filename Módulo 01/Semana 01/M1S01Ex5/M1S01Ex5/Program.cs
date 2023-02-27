int n;
int a = 1, b = 0, c = 0;

Console.WriteLine("Digite o numero de termos da sequencia fibonacci que deseja visualizar:");
n = int.Parse(Console.ReadLine());

Console.Write(a + " ");

for (int i = 0; i < n-1;i++)
{
    c = a + b;
 Console.Write(c + " ");
    b = a;
    a = c;

}
