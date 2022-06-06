// Projeto Parte 1: Strategy

// É um padrão que permite definir novas operações sem alterar as classes dos elementos sobre os quais opera.

using DesignPatterns;

IImposto iss = new ISS();
IImposto icms = new ICMS();

Orcamento orcamento = new Orcamento(500.00);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);
Console.ReadKey();