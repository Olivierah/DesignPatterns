// Projeto Parte 5 : State

// O State é usado quando o comportamento de um objeto muda, dependendo do seu estado.

using DesignPatterns;

Orcamento reforma = new Orcamento(500);

Console.WriteLine(reforma.Valor);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Aprova();

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Finaliza();


Console.ReadKey();

