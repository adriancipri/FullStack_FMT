//Declaração das listas//
List<int> num = new List<int>();
List<int> par = new List<int>();
List<int> impar = new List<int>();

//Lê os numeros digitados pelo usuario//

Console.WriteLine("Digite 10 números inteiros:");
  for (int i = 0; i < 10; i++)
   {
       int numero = int.Parse(Console.ReadLine());
       num.Add(numero);
   }

  //classifica em par ou impar//

  foreach (int numero in num)
   {
       if (numero % 2 == 0)
        {
           par.Add(numero);
        }
       else
        {
           impar.Add(numero);
        }
   }

  //ordena as listas//

   par.Sort();
   impar.Sort();

//imprime as respostas//

   Console.WriteLine($"A lista de números pares possui {par.Count} números e a soma deles é igual a {par.Sum()}.");
   Console.WriteLine($"A lista de números ímpares possui {impar.Count} números e a soma deles é igual a {impar.Sum()}.");