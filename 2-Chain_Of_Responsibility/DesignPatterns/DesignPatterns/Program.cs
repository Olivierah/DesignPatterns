// Projeto Parte 2 : Chain Of Responsibility

// É um padrão que 

using DesignPatterns;

IImposto iss = new ISS();
IImposto icms = new ICMS();

Orcamento orcamento = new Orcamento(500.00);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);
Console.ReadKey();