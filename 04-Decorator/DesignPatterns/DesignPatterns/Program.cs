// Projeto Parte 4 : Decorator

// O Decorator permite adicionar um comportamento/responsabilidades
// dinamicamente a um objeto já existente em tempo de execução.

using DesignPatterns;

// Para implementar o Decorator, a classe Imposto mudará de Interface
//para uma classe Abstrata

IImposto iss = new ISS(new ICMS());

Orcamento orcamento = new Orcamento(500);

double valor = iss.Calcula(orcamento);

Console.WriteLine(valor);
Console.ReadKey();

