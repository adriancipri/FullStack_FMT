int[] numeros = new int[10];
for (int i = 0; i < numeros.length; i++)
{
    console.write($"digite o {i + 1}º número:");
    numeros[i] = int.parse(console.readline());
}
for (int i = 0; i < numeros.length; i++)
{
    int contador = 0;

    for (int j = 1; j <= numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        console.writeline($"o numero {numeros[i]} é um numero primo, e está na posição {i}");
    }
}
