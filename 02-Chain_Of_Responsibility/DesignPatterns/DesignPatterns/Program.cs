// Projeto Parte 2 : Chain Of Responsibility

// É um padrão que  visa evitar a dependência entre um objeto receptor e um objeto solicitante.

using DesignPatterns;

CalculadorDeDesconto calculadora = new CalculadorDeDesconto();

Orcamento orcamento = new Orcamento(8000);

orcamento.AdicionaItem(new Item("GELADEIRA", 1300));
orcamento.AdicionaItem(new Item("PS5", 2500));
orcamento.AdicionaItem(new Item("Xbox Série X", 1999));
orcamento.AdicionaItem(new Item("TV", 1800));
orcamento.AdicionaItem(new Item("FOGAO", 900));
//orcamento.AdicionaItem(new Item("MICROONDAS", 700)); //=> Descomente para aplicar o Desconto para mais de 5 itens

double desconto = calculadora.Calcula(orcamento);
Console.WriteLine(desconto);
Console.ReadKey();
