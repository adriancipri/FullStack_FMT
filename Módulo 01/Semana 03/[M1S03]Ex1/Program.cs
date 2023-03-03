
using _M1S03_Ex1;

Produto produto1 = new Produto("Calculadora", 5.75, 199);
Produto produto2 = new Produto();

Console.WriteLine($"O produto 1 tem noem : {produto1.nome}, valor:{produto1.preco} e" +
    $" quantidade: {produto1.qtdade}");

Console.WriteLine($"O produto 2 tem noem : {produto2.nome}, valor:{produto2.preco} e" +
    $" quantidade: {produto2.qtdade}");
