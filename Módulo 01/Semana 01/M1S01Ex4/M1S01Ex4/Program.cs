//declaração arrays//
string[] nomes = new string[5];
decimal[] notas = new decimal[5];

// recebe os nomes e notas//

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomes[i] = Console.ReadLine();

    Console.Write($"Digite a nota do {i + 1}º aluno: ");
    notas[i] = decimal.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    Console.Write(nomes[i] + ": ");

    if (notas[i] >= 6)
    {
        Console.WriteLine("APROVADO");
    }
    else
    {
        Console.WriteLine("REPROVADO");
    }
}

